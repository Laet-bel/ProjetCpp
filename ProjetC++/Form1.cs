using libImage;
using System.ComponentModel;
using System.Drawing.Imaging;
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
        }

        private static System.Timers.Timer aTimer;
        private int nbImagesTraitees = 0;
        private float moyenneScore = 0;


        private void B_Lancer_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bitmap initialImageBmp, TreatedBmp, bmpGroundTruth;
                    Image img = Image.FromFile(ofd.FileName);
                    bool imageIn = false; // TODO LABE mettre en variable globale de MDD
                    if (Cb_ImageIn.Checked) imageIn = true; // TODO LABE gérer les in / sc 
                    string pathGroundTruth = Path.Combine("C:\\Users\\laetb\\OneDrive\\Bureau\\cour\\IPSI\\IPSI2\\ReelProjetCpp\\ProjetCpp\\Image\\Ground truth - png\\", Path.GetFileNameWithoutExtension(ofd.FileName) + ".png");
                    Image imgGroundTruth = Image.FromFile(pathGroundTruth);
                    initialImageBmp = new Bitmap(img);
                    TreatedBmp = new Bitmap(img);
                    bmpGroundTruth = new Bitmap(imgGroundTruth);
                    ClImage processor = new ClImage();
                    // TODO LABE prende variable globale de MDD
                    moyenneScore = 0;
                    nbImagesTraitees = 0;
                    unsafe
                    {
                        try
                        {
                            var bmpDataImageInitial = TreatedBmp.LockBits(new Rectangle(0, 0, TreatedBmp.Width, TreatedBmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                            var bmpDataImageGroundTruth = bmpGroundTruth.LockBits(new Rectangle(0, 0, bmpGroundTruth.Width, bmpGroundTruth.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                            //var bmpDataGt = bmpGt.LockBits(new Rectangle(0, 0, bmpGt.Width, bmpGt.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                            string type = "V4";
                            int largeur = 3;
                            int hauteur = 3;
                            processor.objetLibDataImgPtr(1, bmpDataImageInitial.Scan0, bmpDataImageInitial.Stride, bmpDataImageGroundTruth.Scan0, bmpDataImageGroundTruth.Stride, TreatedBmp.Height, TreatedBmp.Width, imageIn, type, largeur, hauteur);
                            TreatedBmp.UnlockBits(bmpDataImageInitial);
                            bmpGroundTruth.UnlockBits(bmpDataImageGroundTruth);

                            double score = processor.objetLibValeurChamp(0); // TODO LABE prende variable globale
                            Lb_ValeurScore.Text = (score * 100).ToString("F2") + "%";
                            nbImagesTraitees++;
                            moyenneScore += (float)score;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }



                    //PB_InitialImage.Width = bmp.Width;
                    //PB_InitialImage.Height = bmp.Height;
                    //// pour centrer image dans panel
                    //if (PB_InitialImage.Width < panel1.Width)
                    //    PB_InitialImage.Left = (panel1.Width - imageDepart.Width) / 2;

                    //if (PB_InitialImage.Height < panel1.Height)
                    //    PB_InitialImage.Top = (panel1.Height - imageDepart.Height) / 2;

                    PB_InitialImage.Image = initialImageBmp;
                    PB_TreatedImage.Image = TreatedBmp;
                    PB_GroundTruth.Image = bmpGroundTruth;

                    moyenneScore /= nbImagesTraitees; //TODO LABE remettre cette ligne
                    Lb_ValeurScoreMoy.Text = (moyenneScore * 100).ToString("F2") + "%";

                    //PB_TreatedImage.Hide();
                    //valeurSeuilAuto.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void B_Quitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Tb_Timer_Scroll(object sender, EventArgs e)
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(2000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
            LB_ValeurTimer.Text = Tb_Timer.Value.ToString();
        }
        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
                              e.SignalTime);
        }

        private void LB_ValeurTimer_Click(object sender, EventArgs e)
        {
            LB_ValeurTimer.Text = Tb_Timer.Value.ToString();
        }


        //private void seuillageAuto_Click(object sender, EventArgs e)
        //{
        //    // traitement donc transférer data bmp vers C++

        //    imageSeuillee.Show();
        //    valeurSeuilAuto.Show();

        //    Bitmap bmp = new Bitmap(imageDepart.Image);
        //    ClImage Img = new ClImage();

        //    unsafe
        //    {
        //        BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
        //        Img.objetLibDataImgPtr(1, bmpData.Scan0, bmpData.Stride, bmp.Height, bmp.Width);
        //        // 1 champ texte retour C++, le seuil auto
        //        bmp.UnlockBits(bmpData);
        //    }

        //    valeurSeuilAuto.Text = Img.objetLibValeurChamp(0).ToString();

        //    imageSeuillee.Width = bmp.Width;
        //    imageSeuillee.Height = bmp.Height;

        //    // pour centrer image dans panel
        //    if (imageSeuillee.Width < panel1.Width)
        //        imageSeuillee.Left = (panel1.Width - imageSeuillee.Width) / 2;

        //    if (imageSeuillee.Height < panel1.Height)
        //        imageSeuillee.Top = (panel1.Height - imageSeuillee.Height) / 2;

        //    // transférer C++ vers bmp
        //    imageSeuillee.Image = bmp;
        //}

    }
}