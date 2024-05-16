using libImage;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.Linq;
using System.Timers;
using System.Windows.Forms;

namespace ProjetC__
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        //{

        //}

        private float ValeurScore=50;
        private float ValeurScoreMoyen=30;


        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
                              e.SignalTime);
        }

     

      

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

                    //PB_TreatedImage.Hide();
                    //valeurSeuilAuto.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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

        private void LB_ValeurTimer_Click_1(object sender, EventArgs e)
        {
            LB_ValeurTimer.Text = Tb_Timer.Value.ToString();
        }

        private void PanelAffichageScore_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelAffichageScoreMoy_Paint(object sender, PaintEventArgs e)
        {

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
        void AfficheScore(System.Windows.Forms.Label label, float score)
        {
           label.Text = score.ToString()+"%";
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            Test();
        }
    }

    }
