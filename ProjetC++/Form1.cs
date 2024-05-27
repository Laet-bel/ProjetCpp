using libImage;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Linq;
using System.Timers;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace ProjetC__
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MiseAJourLabelIntervalle();
            Lb_ValeurTimer.Text = Tb_Timer.Value.ToString() + " ms";
        }

        private double ValeurScore = 0;
        private double ValeurScoreMoyen = 0;
        private int ValeurIntervalleMax = 300;
        private int ValeurIntervalleMin = 1;
        private int indiceImage = 0;
        private bool deuxTypes = false;
        Bitmap initialImageBmp;
        Bitmap TreatedBmp;
        Bitmap GroundTruthBmp;

        private void B_Lancer_Click(object sender, EventArgs e)
        {
            ValeurScoreMoyen = 0;
            indiceImage = ValeurIntervalleMin;
            timer1.Start();
        }

        private void B_Quitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        //TODO LABE utiliser des variables globales
        private void ExportCSV(List<float> ValeurScore, float ValeurScoreMoy, string filepath)
        {
            using (StreamWriter file = new StreamWriter("filepath"))
            {
                // Entêtes des colonnes
                file.WriteLine("Type d'image, Numéro d'image, Score");

                for (int i = 0; i < ValeurScore.Count; i++)
                {
                    string imageType = Cb_ImageIn.Checked ? "In" : "Sc";
                    float score = ValeurScore[i];

                    // Écrire chaque ligne pour l'image
                    file.WriteLine($"{imageType}, {i + 1}, {score}");
                }

                // Écrire la moyenne en dernière ligne
                file.WriteLine($"Moyenne totale du score,,{ValeurScoreMoy}");
            }

            Lb_Error.Text = "Export CSV réussi !";
        }

        void AfficheScore(System.Windows.Forms.Label label, System.Windows.Forms.Panel panel, double score)
        {
            label.Text = score.ToString("F2") + "%";
            ColorePanel(panel, score);
        }

        //TODO LABE enlever
        private void BT_Test(object sender, EventArgs e) // but test
        {
            timer1.Start();
        }

        void ColorePanel(System.Windows.Forms.Panel panel, double score)
        {
            if (score >= 75)
                panel.BackColor = Color.Green;
            else if (score >= 50)
                panel.BackColor = Color.Orange;
            else
                panel.BackColor = Color.Red;
        }

        //private void Test()
        //{
        //    Random random = new Random();
        //    ValeurScore = random.Next(100);
        //    ValeurScoreMoyen = random.Next(100);
        //    AfficheScore(Lb_ValeurScore, ValeurScore);
        //    AfficheScore(Lb_ValeurScoreMoy, ValeurScoreMoyen);
        //    ColorePanel(P_AffichageScore, ValeurScore);
        //    ColorePanel(P_AffichageScoreMoy, ValeurScoreMoyen);
        //}

        private void Traitement()
        {
            try
            {
                ClImage processor = new ClImage();

                ValeurScore = 0;

                //TODO LABE ajouter dans IHM choix SE
                string type = "V4";
                int largeur = 3, hauteur = 3;

                unsafe
                {
                    try
                    {
                        var bmpDataImageInitial = TreatedBmp.LockBits(new Rectangle(0, 0, TreatedBmp.Width, TreatedBmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                        var bmpDataImageGroundTruth = GroundTruthBmp.LockBits(new Rectangle(0, 0, GroundTruthBmp.Width, GroundTruthBmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

                        processor.objetLibDataImgPtr(1, bmpDataImageInitial.Scan0, bmpDataImageInitial.Stride, bmpDataImageGroundTruth.Scan0, bmpDataImageGroundTruth.Stride, TreatedBmp.Height, TreatedBmp.Width, Cb_ImageIn.Checked, type, largeur, hauteur);
                        TreatedBmp.UnlockBits(bmpDataImageInitial);
                        GroundTruthBmp.UnlockBits(bmpDataImageGroundTruth);

                        ValeurScore = processor.objetLibValeurChamp(0) * 100;
                        ValeurScoreMoyen += ValeurScore;
                        AfficheScore(Lb_ValeurScore, P_AffichageScore, ValeurScore);
                    }
                    catch (Exception ex)
                    {
                        Lb_Error.Text = ex.Message;
                    }
                }
            }
            catch (Exception ex)
            {
                Lb_Error.Text = ex.Message;
            }

        }

        private void MajImages()
        {
            // Décalage des images traitées
            if (Pb_TreatedImage2.Image != null)
            {
                Pb_TreatedImage3.Image = Pb_TreatedImage2.Image;
            }
            if (Pb_TreatedImage1.Image != null)
            {
                Pb_TreatedImage2.Image = Pb_TreatedImage1.Image;
            }
            if (Pb_TreatedImage.Image != null)
            {
                Pb_TreatedImage1.Image = Pb_TreatedImage.Image;
            }

            // Mise à jour des images actuelles
            Pb_InitialImage.Image = initialImageBmp;
            Pb_TreatedImage.Image = TreatedBmp;
            Pb_GroundTruth.Image = GroundTruthBmp;
        }

        private void Tb_Timer_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = Tb_Timer.Value;
            Lb_ValeurTimer.Text = Tb_Timer.Value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            indiceImage++;
            bool firstDone = false;
            bool done = false;
            if (indiceImage > ValeurIntervalleMax)
            {
                // TODO LABE faire correctement pour gérer les deux types d'images
                if (firstDone && Cb_ToutesImages.Checked) done = true;
                else done = true;
                firstDone = true;
                if(Cb_ToutesImages.Checked) indiceImage = ValeurIntervalleMin;
                if(done) timer1.Stop();
                // ExportCSV(ValeurScore, ValeurScoreMoyen, "C:\\Users\\laetb\\OneDrive\\Bureau\\cour\\IPSI\\IPSI2\\ProjetCpp\\Image\\Resultat.csv");
            }

            // TODO LABE faire correctement 
            string solutionPath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))));
            string typeImage;
            if (!Cb_DeuxTypes.Checked) typeImage = Cb_ImageIn.Checked ? "In" : "Sc";
            else typeImage = firstDone ? "Sc" : "In";

            string InitialPath = Path.Combine(solutionPath, "Image", "Source Images - bmp", typeImage + "_" + indiceImage + ".bmp");
            string GroundTruthPath = Path.Combine(solutionPath, "Image", "Ground truth - png", typeImage + "_" + indiceImage + ".png");
            initialImageBmp = new Bitmap(InitialPath);
            TreatedBmp = new Bitmap(InitialPath);
            //string path = "C:\\Users\\laetb\\OneDrive\\Bureau\\cour\\IPSI\\IPSI2\\ProjetCpp\\Image\\Source Images - bmp\\In_"+(indiceImage + 1) + ".bmp";
            //string pathGroundTruth = "C:\\Users\\laetb\\OneDrive\\Bureau\\cour\\IPSI\\IPSI2\\ProjetCpp\\Image\\Ground truth - png\\In_" +(indiceImage + 1) + ".png";
            GroundTruthBmp = new Bitmap(GroundTruthPath);
            Traitement();
            MajImages();
            AfficheScore(Lb_ValeurScoreMoy, P_AffichageScoreMoy, ValeurScoreMoyen / indiceImage);
        }

        private void Tb_DebutInterval_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(Tb_DebutInterval.Text, out ValeurIntervalleMin))
            {
                Tb_DebutInterval.Text = "1";
            }
            ValeurIntervalleMin = int.Parse(Tb_DebutInterval.Text);
            MiseAJourIntervalle();
        }

        private void Tb_FinInterval_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(Tb_FinInterval.Text, out ValeurIntervalleMax))
            {
                Tb_FinInterval.Text = "300";
            }
            ValeurIntervalleMax = int.Parse(Tb_FinInterval.Text);
            MiseAJourIntervalle();
        }

        private void MiseAJourIntervalle()
        {
            if (Cb_ToutesImages.Checked)
            {
                ValeurIntervalleMin = 1;
                ValeurIntervalleMax = 300;
            }
            if (Cb_ImageSeule.Checked)
            {
                if (ValeurIntervalleMin > 300) ValeurIntervalleMin = 300;
                ValeurIntervalleMin = Math.Max(ValeurIntervalleMin, 1);
                ValeurIntervalleMax = ValeurIntervalleMin;
            }
            if (Cb_Intervalle.Checked)
            {
                if (ValeurIntervalleMin >= 300) ValeurIntervalleMin = 299;
                if (ValeurIntervalleMax > 300) ValeurIntervalleMax = 300;
                if (ValeurIntervalleMin < 1) ValeurIntervalleMin = 1;
                if (ValeurIntervalleMax <= 1) ValeurIntervalleMax = 2;
                if (ValeurIntervalleMax < ValeurIntervalleMin) ValeurIntervalleMax = ValeurIntervalleMin + 1;

            }
            MiseAJourLabelIntervalle();
        }

        private void MiseAJourLabelIntervalle()
        {
            Tb_DebutInterval.Text = ValeurIntervalleMin.ToString();
            Tb_FinInterval.Text = ValeurIntervalleMax.ToString();
        }

        private void Cb_ImageSeule_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_ImageSeule.Checked == true) MiseAJourCheckBoxIntervalles(Cb_ImageSeule);
        }
        private void Cb_Intervalle_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_Intervalle.Checked == true) MiseAJourCheckBoxIntervalles(Cb_Intervalle);
        }

        private void Cb_ToutesImages_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_ToutesImages.Checked == true) MiseAJourCheckBoxIntervalles(Cb_ToutesImages);
        }

        private void MiseAJourCheckBoxIntervalles(System.Windows.Forms.CheckBox checkBox)
        {
            if (Cb_ImageSeule != checkBox) Cb_ImageSeule.Checked = false;
            if (Cb_ToutesImages != checkBox) Cb_ToutesImages.Checked = false;
            if (Cb_Intervalle != checkBox) Cb_Intervalle.Checked = false;
            if (Cb_ToutesImages.Checked != true && Cb_ImageSeule.Checked != true && Cb_Intervalle.Checked != true) Cb_ImageSeule.Checked = true;
            
            MiseAJourIntervalle();
        }
        private void Cb_ImageIn_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_ImageIn.Checked == true) MiseAJourCheckBoxTypeImages(Cb_ImageIn);
        }

        private void Cb_ImageSc_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_ImageSc.Checked == true) MiseAJourCheckBoxTypeImages(Cb_ImageSc);
        }

        private void Cb_DeuxTypes_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_DeuxTypes.Checked == true) MiseAJourCheckBoxTypeImages(Cb_DeuxTypes);
        }

        private void MiseAJourCheckBoxTypeImages(System.Windows.Forms.CheckBox checkBox)
        {
            if (Cb_ImageIn != checkBox) Cb_ImageIn.Checked = false;
            if (Cb_ImageSc != checkBox) Cb_ImageSc.Checked = false;
            if (Cb_DeuxTypes != checkBox) Cb_DeuxTypes.Checked = false;
            if (Cb_ImageIn.Checked != true && Cb_ImageSc.Checked != true && Cb_DeuxTypes.Checked != true) Cb_ImageIn.Checked = true;

            deuxTypes = Cb_DeuxTypes.Checked;
        }
    }
}