using libImage;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using System.ComponentModel;
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
        }

        private float ValeurScore = 0;
        private float ValeurScoreMoyen = 0;
        private int ValeurIntervalleMax = 300;
        private int ValeurIntervalleMin = 1;

        //TODO LABE lancer tick du timer et extraire le tout dans une fonction traitement
        private void B_Lancer_Click_1(object sender, EventArgs e)
        {

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bitmap initialImageBmp, TreatedBmp, bmpGroundTruth;
                    Image img = Image.FromFile(ofd.FileName);
                    bool imageIn = false;
                    if (Cb_ImageIn.Checked) imageIn = true; // TODO LABE gérer les in / sc 
                    string pathGroundTruth = Path.Combine("C:\\Users\\MD272295\\Documents\\Visual Studio 2022\\ProjetCpp\\Image\\Ground truth - png\\", Path.GetFileNameWithoutExtension(ofd.FileName) + ".png");
                    Image imgGroundTruth = Image.FromFile(pathGroundTruth);
                    initialImageBmp = new Bitmap(img);
                    TreatedBmp = new Bitmap(img);
                    bmpGroundTruth = new Bitmap(imgGroundTruth);
                    ClImage processor = new ClImage();

                    //TODOO LABE mettre à la fin fonction timer Tick
                    // ajout pour export csv

                    // Choisissez le chemin pour sauvegarder le fichier CSV
                    //string csvPath =/* Path.GetFolderPath(/*"C: \\Users\\MD272295\\Documents\\Visual Studio 2022\\ProjetCpp"),*/ "Score.csv";
                    //ExportCSV(ValeurScore, ValeurScoreMoyen, csvPath);
                    //CB_ExportCSV.Checked = true;

                    unsafe
                    {
                        try
                        {
                            var bmpDataImageInitial = TreatedBmp.LockBits(new Rectangle(0, 0, TreatedBmp.Width, TreatedBmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                            var bmpDataImageGroundTruth = bmpGroundTruth.LockBits(new Rectangle(0, 0, bmpGroundTruth.Width, bmpGroundTruth.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                            //var bmpDataGt = bmpGt.LockBits(new Rectangle(0, 0, bmpGt.Width, bmpGt.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

                            processor.objetLibDataImgPtr(1, bmpDataImageInitial.Scan0, bmpDataImageInitial.Stride, bmpDataImageGroundTruth.Scan0, bmpDataImageGroundTruth.Stride, TreatedBmp.Height, TreatedBmp.Width, imageIn);
                            TreatedBmp.UnlockBits(bmpDataImageInitial);
                            bmpGroundTruth.UnlockBits(bmpDataImageGroundTruth);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }


                    PB_InitialImage.Image = initialImageBmp;
                    PB_TreatedImage.Image = TreatedBmp;
                    PB_GroundTruth.Image = bmpGroundTruth;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

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

            MessageBox.Show("Export CSV réussi !");
        }

        private void B_Quitter_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void Tb_Timer_Scroll_1(object sender, EventArgs e)
        {
            timer1.Interval = Tb_Timer.Value;
            LB_ValeurTimer.Text = Tb_Timer.Value.ToString();

        }

        void AfficheScore(System.Windows.Forms.Label label, float score)
        {
            label.Text = score.ToString() + "%";
        }

        private void BT_Test(object sender, EventArgs e) // but test
        {
            timer1.Start();
        }

        void ColorePanel(System.Windows.Forms.Panel panel, float score)
        {
            if (score >= 75)
                panel.BackColor = Color.Green;
            else if (score >= 50)
                panel.BackColor = Color.Orange;
            else
                panel.BackColor = Color.Red;
        }

        private void Test()
        {

            Random random = new Random();
            ValeurScore = random.Next(100);
            ValeurScoreMoyen = random.Next(100);
            AfficheScore(Lb_ValeurScore, ValeurScore);
            AfficheScore(Lb_ValeurScoreMoy, ValeurScoreMoyen);
            ColorePanel(PanelAffichageScore, ValeurScore);
            ColorePanel(PanelAffichageScoreMoy, ValeurScoreMoyen);
        }

        //TODO LABE appeler fonction traitement
        private void timer1_Tick(object sender, EventArgs e)
        {
            Test();
        }

        private void Tb_DebutInterval_TextChanged(object sender, EventArgs e)
        {
            ValeurIntervalleMin = int.Parse(Tb_DebutInterval.Text);
            MiseAJourIntervalle();
        }

        private void Tb_FinInterval_TextChanged(object sender, EventArgs e)
        {
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
            if(Cb_ImageSeule.Checked == true) MiseAJourCheckBoxIntervalles(Cb_ImageSeule);
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
            if(Cb_ToutesImages != checkBox) Cb_ToutesImages.Checked = false;
            if (Cb_Intervalle != checkBox) Cb_Intervalle.Checked = false;
            if(Cb_ToutesImages.Checked != true && Cb_ImageSeule.Checked != true && Cb_Intervalle.Checked != true) Cb_ImageSeule.Checked = true;
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

        }
    }
}