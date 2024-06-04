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
using static System.Windows.Forms.LinkLabel;

namespace ProjetC__
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //initialisation de l'IHM
            MiseAJourLabelIntervalle();
            Lb_ValeurTimer.Text = Tb_Timer.Value.ToString() + " ms";
        }
        // Initialisation des variables globales
        private double ValeurScore = 0;
        private double ValeurSommeScores = 0;
        private double ValeurMoyenneScore = 0;
        private int ValeurIntervalleMax = 300;
        private int ValeurIntervalleMin = 1;
        private int indiceImage = 0;
        private Bitmap initialImageBmp;
        private Bitmap TreatedBmp;
        private Bitmap GroundTruthBmp;

        private bool firstDone = false;
        private bool done = false;
        private bool pause = false;

        private List<float> ValeurScores = new List<float>();


        
        // Bouton qui permet de lancer le traitement
        private void B_Lancer_Click(object sender, EventArgs e)
        {
            // Détecter si on a mis en pause ou si c'est un début de traitement
            if (!pause)
            {
                // Si c'est un début de traitement, on réinitialise les variables
                ValeurSommeScores = 0;
                ValeurScore = 0;
                ValeurMoyenneScore = 0;
                indiceImage = ValeurIntervalleMin;
                firstDone = false;
                done = false;
                pause = false;
                ValeurScores.Clear();
            }

            // Lancement du timer qui effectue le traitement
            timer1.Start();

            if (ValeurIntervalleMax > ValeurIntervalleMin)
            {
                MajIhmLancerStop();
            }
        }
        // Bouton qui permet de mettre en pause le traitement,de mettre à jour le traitement et de déclencher le bouton lancer 
        private void B_Areter_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MajIhmLancerStop();
            pause = true;
        }

        // Bouton qui permet de remettre toutes les fontions comme au lancement de l'IHM
        private void B_Reinitialiser_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            ValeurSommeScores = 0;
            ValeurScore = 0;
            indiceImage = 0;
            firstDone = false;
            done = false;
            pause = false;

            AfficheScore(Lb_ValeurScore, P_AffichageScore, ValeurScore);
            AfficheScore(Lb_ValeurScoreMoy, P_AffichageScoreMoy, ValeurScore);

            MajAffichage();

            Pb_InitialImage.Image = null;
            Pb_TreatedImage.Image = null;
            Pb_GroundTruth.Image = null;
            Pb_TreatedImage1.Image = null;
            Pb_TreatedImage2.Image = null;
            Pb_TreatedImage3.Image = null;

            Cb_ImageIn.Checked = true;
            Cb_ImageSeule.Checked = true;
            Cb_ExportCSV.Checked = false;

            P_AffichageScore.BackColor = Color.Empty;
            P_AffichageScoreMoy.BackColor = Color.Empty;

            Tb_Timer.Value = 10;
            Lb_ValeurTimer.Text = Tb_Timer.Value.ToString() + " ms";

            if (B_Areter.Enabled) MajIhmLancerStop();
        }

        // Fonction qui permet d'inverser les différent états des composants voulus dans l'IHM
        private void MajIhmLancerStop()
        {
            // Inverser l'état enable des checkbox, certaines textbox et des boutons lancer/arreter
            B_Areter.Enabled = !B_Areter.Enabled;
            B_Lancer.Enabled = !B_Lancer.Enabled;
            Cb_DeuxTypes.Enabled = !Cb_DeuxTypes.Enabled;
            Cb_ImageIn.Enabled = !Cb_ImageIn.Enabled;
            Cb_ImageSc.Enabled = !Cb_ImageSc.Enabled;
            Cb_ToutesImages.Enabled = !Cb_ToutesImages.Enabled;
            Cb_ImageSeule.Enabled = !Cb_ImageSeule.Enabled;
            Cb_Intervalle.Enabled = !Cb_Intervalle.Enabled;
            Cb_TypeSE.Enabled = !Cb_TypeSE.Enabled;
            Tb_LargeurSE.Enabled = !Tb_LargeurSE.Enabled;
            Tb_HauteurSE.Enabled = !Tb_HauteurSE.Enabled;
            Tb_DebutInterval.Enabled = !Tb_DebutInterval.Enabled;
            Tb_FinInterval.Enabled = !Tb_FinInterval.Enabled;

        }

        // Bouton qui permet de fermer l'application
        private void B_Quitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Fonction qui permet d'exporter sur un fichier excel avec un tableau
        // contenant sur les colonnes le Type d'image;le  Numero d'image et le Score
        // Utilisation du point-virgule comme séparateur
        private void ExportCSV(string filepath)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(filepath))
                {
                    // Entêtes des colonnes du fichier CSV
                    file.WriteLine("Type d'image; Numero d'image; Score");

                    for (int i = 0; i < ValeurScores.Count; i++)
                    {
                        string imageType;
                        if (!Cb_DeuxTypes.Checked) imageType = Cb_ImageIn.Checked ? "In" : "Sc";
                        else imageType = i < (ValeurScores.Count / 2) ? "In" : "Sc";
                        float score = ValeurScores[i];
                        float numero;
                        if (Cb_DeuxTypes.Checked) numero = i < (ValeurScores.Count / 2) ? i + 1 : i - (ValeurScores.Count / 2) + 1;
                        else numero = i + 1;

                        // Ecrire chaque ligne pour l'image
                        file.WriteLine($"{imageType}; {numero}; {score}");
                    }


                    // Ecrire la moyenne totale en dernière ligne
                    file.WriteLine($"Moyenne totale du score;;{ValeurMoyenneScore}");
                    Lb_Error.Text = "Export CSV réussi !";
                }
            }
            catch (Exception ex)
            {
                Lb_Error.Text = ex.Message;
            }
        }

        // Fonction qui permet d'afficher le score de ressemblence entre les image tratitées et les images vérités terrains 
        void AfficheScore(System.Windows.Forms.Label label, System.Windows.Forms.Panel panel, double score)
        {
            label.Text = score.ToString("F2") + "%";
            ColorePanel(panel, score);
        }
        
        // Fonction qui permet de colorer les panels selon la valeur de leur score, vert si le score est bon, orangesi c'est moyen et rouge si c'est pas bon
        void ColorePanel(System.Windows.Forms.Panel panel, double score)
        {
            if (score >= 60)
                panel.BackColor = Color.Green;
            else if (score >= 40)
                panel.BackColor = Color.Orange;
            else
                panel.BackColor = Color.Red;
        }

        // Fonction qui permet de choisir le type de traitement qu'on veut (type de défaut In / Sc
        // Options choisies : élèments structurants, la hauteur et la largeur de celui-ci
        private void Traitement()
        {
            try
            {
                ClImage processor = new ClImage(); // Création de l'objet qui va traiter les images (instance du wrapper)

                ValeurScore = 0;

                // Récupération du type d'élément structurant
                string type = "V4";
                if (Cb_TypeSE.SelectedItem != null)
                {
                    if (Cb_TypeSE.SelectedItem.ToString() == "V4") type = "V4";
                    else if (Cb_TypeSE.SelectedItem.ToString() == "V8") type = "V8";
                    else if (Cb_TypeSE.SelectedItem.ToString() == "Ligne Verticale") type = "ligV";
                    else if (Cb_TypeSE.SelectedItem.ToString() == "Ligne Horizontale") type = "ligH";
                    else if (Cb_TypeSE.SelectedItem.ToString() == "Rectangle") type = "rect";
                }

                // Récupération des dimensions de l'élément structurant
                int largeur, hauteur;
                if (!int.TryParse(Tb_LargeurSE.Text, out largeur))
                {
                    Tb_LargeurSE.Text = "3";
                    largeur = 3;
                }
                if (!int.TryParse(Tb_HauteurSE.Text, out hauteur))
                {
                    Tb_HauteurSE.Text = "3";
                    hauteur = 3;
                }

                // Récupération du type d'image à traiter
                bool boolIn;
                if (Cb_ImageIn.Checked) boolIn = true;
                else if (Cb_ImageSc.Checked) boolIn = false;
                else
                {
                    if (Cb_DeuxTypes.Checked && firstDone) boolIn = false;
                    else boolIn = true;
                }

                // Traitement de l'image
                unsafe
                {
                    try
                    {
                        // Lock des images pour les passer en paramètre
                        var bmpDataImageInitial = TreatedBmp.LockBits(new Rectangle(0, 0, TreatedBmp.Width, TreatedBmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                        var bmpDataImageGroundTruth = GroundTruthBmp.LockBits(new Rectangle(0, 0, GroundTruthBmp.Width, GroundTruthBmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

                        // Appel de la méthode de traitement de l'image
                        processor.objetLibDataImgPtr(1, bmpDataImageInitial.Scan0, bmpDataImageInitial.Stride, bmpDataImageGroundTruth.Scan0, bmpDataImageGroundTruth.Stride, TreatedBmp.Height, TreatedBmp.Width, boolIn, type, largeur, hauteur);

                        // Unlock des images
                        TreatedBmp.UnlockBits(bmpDataImageInitial);
                        GroundTruthBmp.UnlockBits(bmpDataImageGroundTruth);

                        // Affichage et calcul des scores
                        ValeurScore = processor.objetLibValeurChamp(0) * 100;
                        ValeurScores.Add((float)ValeurScore);
                        ValeurSommeScores += ValeurScore;
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

        // Fonction qui permet de mettre à jour l'affichage des images traitées et les informations
        private void MajAffichage()
        {
            MiseAJourImages();
            MiseAJourInformations();
        }

        // Fonction qui permet de décaller les images traitées sur les picturesbox une par une 
        private void MiseAJourImages()
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

        // Fonction qui permet de mettre à jour l'affichage du type d'image traitée et de son numéro
        private void MiseAJourInformations()
        {
            string type;
            if (!Cb_DeuxTypes.Checked) type = Cb_ImageIn.Checked ? "In" : "Sc";
            else type = firstDone ? "Sc" : "In";
            L_info.Text = "Image : " + indiceImage + " \t Type : " + type;
        }

        // TrackBar qui permet de mettre la valeur du timer
        private void Tb_Timer_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = Tb_Timer.Value;
            Lb_ValeurTimer.Text = Tb_Timer.Value.ToString() + " ms";
        }

        // Timer qui permet de traiter les images en série, de mettre à jour l'affichage et de calculer des scores, 
       // Il permet aussi de gérer les images dans les intervalles d'images à traiter , les types d'images à traiter, et d'exportation les résultats en fchier CSV.
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (indiceImage > ValeurIntervalleMax)
            {
                // Si on a fini de traiter toutes les images, on arrête le timer
                if (Cb_ImageIn.Checked || Cb_ImageSc.Checked) done = true;
                if (firstDone && Cb_DeuxTypes.Checked) done = true;
                firstDone = true;
                if (Cb_DeuxTypes.Checked && !done) indiceImage = ValeurIntervalleMin;
                if (done)
                {
                    timer1.Stop();
                    if (!Cb_ImageSeule.Checked) MajIhmLancerStop();
                    pause = false;

                    if (Cb_ExportCSV.Checked)
                    {
                        string solutionPath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))));
                        string filePath = Path.Combine(solutionPath, "Image", "Resultat.csv");
                        ExportCSV(filePath);
                    }
                }
            }
            if (!done) // Si on a pas fini de traiter toutes les images, on continue
            {
                // Récupération des images à traiter
                string solutionPath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))));
                
                string typeImage;
                // Si on a coché les deux types d'images, on alterne entre les deux
                if (!Cb_DeuxTypes.Checked) typeImage = Cb_ImageIn.Checked ? "In" : "Sc";
                else typeImage = firstDone ? "Sc" : "In"; // firstDone permet de savoir si on a déjà traité les images de type In

                // Récupération des images à traiter
                string InitialPath = Path.Combine(solutionPath, "Image", "Source Images - bmp", typeImage + "_" + indiceImage + ".bmp");
                string GroundTruthPath = Path.Combine(solutionPath, "Image", "Ground truth - png", typeImage + "_" + indiceImage + ".png");
                initialImageBmp = new Bitmap(InitialPath);
                TreatedBmp = new Bitmap(InitialPath);
                GroundTruthBmp = new Bitmap(GroundTruthPath);

                Traitement();
                MajAffichage();

                // Calcul de la moyenne
                if (!Cb_DeuxTypes.Checked) ValeurMoyenneScore = ValeurSommeScores / (indiceImage - ValeurIntervalleMin + 1);
                else
                {
                    if(firstDone) ValeurMoyenneScore = ValeurSommeScores / ((indiceImage - ValeurIntervalleMin + 1) * 2);
                    else ValeurMoyenneScore = ValeurSommeScores / (indiceImage - ValeurIntervalleMin + 1);
                }

                AfficheScore(Lb_ValeurScoreMoy, P_AffichageScoreMoy, ValeurMoyenneScore);
                indiceImage++;
            }
        }

        // Textbox qui permet d'écrire la valeur du début d'intervalle d'image à traiter
        // Et de véridier la coherence des intervalles
        private void Tb_DebutInterval_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(Tb_DebutInterval.Text, out ValeurIntervalleMin))
            {
                Tb_DebutInterval.Text = "1";
            }
            ValeurIntervalleMin = int.Parse(Tb_DebutInterval.Text);
            MiseAJourIntervalle();
        }

        // Textbox qui permet d'écrire la valeur de la fin d'intervalle d'image à traiter
        // Et de véridier la coherence des intervalles
        private void Tb_FinInterval_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(Tb_FinInterval.Text, out ValeurIntervalleMax))
            {
                Tb_FinInterval.Text = "300";
            }
            ValeurIntervalleMax = int.Parse(Tb_FinInterval.Text);
            MiseAJourIntervalle();
        }

        // Fonction qui permet de mettre à jour les valeur de début et de fin d'intrevalle en fonction du checkbox sélectionné
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

        // Fonction qui permet de mettre à jour le texte des textbox de début et de fin d'intervalle
        private void MiseAJourLabelIntervalle()
        {
            Tb_DebutInterval.Text = ValeurIntervalleMin.ToString();
            Tb_FinInterval.Text = ValeurIntervalleMax.ToString();
        }

        // Si on coche sur checkbox ImageSeule, on décoche les autres checkbox et on met à jour les intervalles qui seront 1 et 1
        private void Cb_ImageSeule_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_ImageSeule.Checked == true) MiseAJourCheckBoxIntervalles(Cb_ImageSeule);
        }

        //  Si on coche sur checkbox Intervalle, on décoche les autres checkbox et on met à jour les intervalles qui vont avoir des valeurs différentes
        private void Cb_Intervalle_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_Intervalle.Checked == true) MiseAJourCheckBoxIntervalles(Cb_Intervalle);
        }

        // Si on coche sur checkbox ToutesImages,on décoche les autres checkbox et on met à jour les intervalles qui seront 1 et 300
        private void Cb_ToutesImages_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_ToutesImages.Checked == true) MiseAJourCheckBoxIntervalles(Cb_ToutesImages);
        }

        // Fonction qui permet de décocher un checkbox lorsqu'on coche un autre, il permet de choisir l'intervalle d'images qu'on veut afficher
        private void MiseAJourCheckBoxIntervalles(System.Windows.Forms.CheckBox checkBox)
        {
            if (Cb_ImageSeule != checkBox) Cb_ImageSeule.Checked = false;
            if (Cb_ToutesImages != checkBox) Cb_ToutesImages.Checked = false;
            if (Cb_Intervalle != checkBox) Cb_Intervalle.Checked = false;
            if (Cb_ToutesImages.Checked != true && Cb_ImageSeule.Checked != true && Cb_Intervalle.Checked != true) Cb_ImageSeule.Checked = true;

            MiseAJourIntervalle();
        }

        // Si on coche sur checkbox ImageIn,on décoche les autres checkbox et on affichera que les images In
        private void Cb_ImageIn_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_ImageIn.Checked == true) MiseAJourCheckBoxTypeImages(Cb_ImageIn);
        }

        // Si on coche sur checkbox ImageSc,on décoche les autres checkbox et on affichera que les images Sc
        private void Cb_ImageSc_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_ImageSc.Checked == true) MiseAJourCheckBoxTypeImages(Cb_ImageSc);
        }

        // Si on coche sur checkbox DeuxTypes,on décoche les autres checkbox et on affichera tous les types d'images
        private void Cb_DeuxTypes_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_DeuxTypes.Checked == true) MiseAJourCheckBoxTypeImages(Cb_DeuxTypes);
        }

        // Fonction qui permet de décocher un checkbox lorsqu'on coche un autre, il permet de choisir le ou les types d'images qu'on veut afficher
        private void MiseAJourCheckBoxTypeImages(System.Windows.Forms.CheckBox checkBox)
        {
            if (Cb_ImageIn != checkBox) Cb_ImageIn.Checked = false;
            if (Cb_ImageSc != checkBox) Cb_ImageSc.Checked = false;
            if (Cb_DeuxTypes != checkBox) Cb_DeuxTypes.Checked = false;
            if (Cb_ImageIn.Checked != true && Cb_ImageSc.Checked != true && Cb_DeuxTypes.Checked != true) Cb_ImageIn.Checked = true;
        }
    }
}