namespace ProjetC__
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Pb_InitialImage = new System.Windows.Forms.PictureBox();
            this.Pb_TreatedImage = new System.Windows.Forms.PictureBox();
            this.Pb_TreatedImage1 = new System.Windows.Forms.PictureBox();
            this.Pb_TreatedImage2 = new System.Windows.Forms.PictureBox();
            this.Pb_TreatedImage3 = new System.Windows.Forms.PictureBox();
            this.Pb_GroundTruth = new System.Windows.Forms.PictureBox();
            this.Lb_InitialImage = new System.Windows.Forms.Label();
            this.Lb_GroundTruth = new System.Windows.Forms.Label();
            this.Lb_TreatedImage = new System.Windows.Forms.Label();
            this.Lb_Options = new System.Windows.Forms.Label();
            this.Lb_TextScore = new System.Windows.Forms.Label();
            this.Lb_Score = new System.Windows.Forms.Label();
            this.B_Lancer = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.P_IntervalleImages = new System.Windows.Forms.Panel();
            this.Lb_TextA = new System.Windows.Forms.Label();
            this.Tb_FinInterval = new System.Windows.Forms.TextBox();
            this.Tb_DebutInterval = new System.Windows.Forms.TextBox();
            this.Lb_TextDe = new System.Windows.Forms.Label();
            this.Tb_Timer = new System.Windows.Forms.TrackBar();
            this.Lb_ValeurScore = new System.Windows.Forms.Label();
            this.P_AffichageScore = new System.Windows.Forms.Panel();
            this.Lb_ScoreMoyenne = new System.Windows.Forms.Label();
            this.Lb_ValeurScoreMoy = new System.Windows.Forms.Label();
            this.P_AffichageScoreMoy = new System.Windows.Forms.Panel();
            this.B_Quitter = new System.Windows.Forms.Button();
            this.Cb_ExportCSV = new System.Windows.Forms.CheckBox();
            this.Lb_TextTimer = new System.Windows.Forms.Label();
            this.Lb_ValeurTimer = new System.Windows.Forms.Label();
            this.P_NbImages = new System.Windows.Forms.Panel();
            this.Cb_ToutesImages = new System.Windows.Forms.CheckBox();
            this.Cb_Intervalle = new System.Windows.Forms.CheckBox();
            this.Cb_ImageSeule = new System.Windows.Forms.CheckBox();
            this.P_TypeImage = new System.Windows.Forms.Panel();
            this.Cb_ImageSc = new System.Windows.Forms.CheckBox();
            this.Cb_DeuxTypes = new System.Windows.Forms.CheckBox();
            this.Cb_ImageIn = new System.Windows.Forms.CheckBox();
            this.B_Test = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.P_Error = new System.Windows.Forms.Panel();
            this.Lb_Error = new System.Windows.Forms.Label();
            this.P_Timer = new System.Windows.Forms.Panel();
            this.L_TextHistorique = new System.Windows.Forms.Label();
            this.B_Areter = new System.Windows.Forms.Button();
            this.L_info = new System.Windows.Forms.Label();
            this.Cb_TypeSE = new System.Windows.Forms.ComboBox();
            this.P_SE = new System.Windows.Forms.Panel();
            this.Tb_LargeurSE = new System.Windows.Forms.TextBox();
            this.Tb_HauteurSE = new System.Windows.Forms.TextBox();
            this.L_TexteLargeurSE = new System.Windows.Forms.Label();
            this.L_TexteHauteurSE = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_InitialImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_TreatedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_TreatedImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_TreatedImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_TreatedImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_GroundTruth)).BeginInit();
            this.P_IntervalleImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tb_Timer)).BeginInit();
            this.P_AffichageScore.SuspendLayout();
            this.P_AffichageScoreMoy.SuspendLayout();
            this.P_NbImages.SuspendLayout();
            this.P_TypeImage.SuspendLayout();
            this.P_Error.SuspendLayout();
            this.P_Timer.SuspendLayout();
            this.P_SE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pb_InitialImage
            // 
            this.Pb_InitialImage.BackColor = System.Drawing.SystemColors.Highlight;
            this.Pb_InitialImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pb_InitialImage.Location = new System.Drawing.Point(15, 15);
            this.Pb_InitialImage.Margin = new System.Windows.Forms.Padding(4);
            this.Pb_InitialImage.Name = "Pb_InitialImage";
            this.Pb_InitialImage.Size = new System.Drawing.Size(400, 340);
            this.Pb_InitialImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_InitialImage.TabIndex = 0;
            this.Pb_InitialImage.TabStop = false;
            // 
            // Pb_TreatedImage
            // 
            this.Pb_TreatedImage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Pb_TreatedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pb_TreatedImage.Location = new System.Drawing.Point(425, 15);
            this.Pb_TreatedImage.Margin = new System.Windows.Forms.Padding(4);
            this.Pb_TreatedImage.Name = "Pb_TreatedImage";
            this.Pb_TreatedImage.Size = new System.Drawing.Size(400, 340);
            this.Pb_TreatedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_TreatedImage.TabIndex = 1;
            this.Pb_TreatedImage.TabStop = false;
            // 
            // Pb_TreatedImage1
            // 
            this.Pb_TreatedImage1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Pb_TreatedImage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pb_TreatedImage1.Location = new System.Drawing.Point(1307, 54);
            this.Pb_TreatedImage1.Name = "Pb_TreatedImage1";
            this.Pb_TreatedImage1.Size = new System.Drawing.Size(180, 97);
            this.Pb_TreatedImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_TreatedImage1.TabIndex = 2;
            this.Pb_TreatedImage1.TabStop = false;
            // 
            // Pb_TreatedImage2
            // 
            this.Pb_TreatedImage2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Pb_TreatedImage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pb_TreatedImage2.Location = new System.Drawing.Point(1307, 156);
            this.Pb_TreatedImage2.Name = "Pb_TreatedImage2";
            this.Pb_TreatedImage2.Size = new System.Drawing.Size(180, 97);
            this.Pb_TreatedImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_TreatedImage2.TabIndex = 3;
            this.Pb_TreatedImage2.TabStop = false;
            // 
            // Pb_TreatedImage3
            // 
            this.Pb_TreatedImage3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Pb_TreatedImage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pb_TreatedImage3.Location = new System.Drawing.Point(1307, 258);
            this.Pb_TreatedImage3.Name = "Pb_TreatedImage3";
            this.Pb_TreatedImage3.Size = new System.Drawing.Size(180, 97);
            this.Pb_TreatedImage3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_TreatedImage3.TabIndex = 4;
            this.Pb_TreatedImage3.TabStop = false;
            // 
            // Pb_GroundTruth
            // 
            this.Pb_GroundTruth.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Pb_GroundTruth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pb_GroundTruth.Location = new System.Drawing.Point(833, 15);
            this.Pb_GroundTruth.Margin = new System.Windows.Forms.Padding(4);
            this.Pb_GroundTruth.Name = "Pb_GroundTruth";
            this.Pb_GroundTruth.Size = new System.Drawing.Size(400, 340);
            this.Pb_GroundTruth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_GroundTruth.TabIndex = 5;
            this.Pb_GroundTruth.TabStop = false;
            // 
            // Lb_InitialImage
            // 
            this.Lb_InitialImage.AutoSize = true;
            this.Lb_InitialImage.Location = new System.Drawing.Point(155, 359);
            this.Lb_InitialImage.Name = "Lb_InitialImage";
            this.Lb_InitialImage.Size = new System.Drawing.Size(109, 25);
            this.Lb_InitialImage.TabIndex = 6;
            this.Lb_InitialImage.Text = "Initial Image";
            // 
            // Lb_GroundTruth
            // 
            this.Lb_GroundTruth.AutoSize = true;
            this.Lb_GroundTruth.Location = new System.Drawing.Point(976, 359);
            this.Lb_GroundTruth.Name = "Lb_GroundTruth";
            this.Lb_GroundTruth.Size = new System.Drawing.Size(116, 25);
            this.Lb_GroundTruth.TabIndex = 7;
            this.Lb_GroundTruth.Text = "Ground Truth";
            // 
            // Lb_TreatedImage
            // 
            this.Lb_TreatedImage.AutoSize = true;
            this.Lb_TreatedImage.Location = new System.Drawing.Point(565, 359);
            this.Lb_TreatedImage.Name = "Lb_TreatedImage";
            this.Lb_TreatedImage.Size = new System.Drawing.Size(124, 25);
            this.Lb_TreatedImage.TabIndex = 8;
            this.Lb_TreatedImage.Text = "Treated Image";
            // 
            // Lb_Options
            // 
            this.Lb_Options.AutoSize = true;
            this.Lb_Options.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_Options.Location = new System.Drawing.Point(177, 416);
            this.Lb_Options.Name = "Lb_Options";
            this.Lb_Options.Size = new System.Drawing.Size(92, 25);
            this.Lb_Options.TabIndex = 9;
            this.Lb_Options.Text = "OPTIONS";
            // 
            // Lb_TextScore
            // 
            this.Lb_TextScore.AutoSize = true;
            this.Lb_TextScore.Location = new System.Drawing.Point(3, 15);
            this.Lb_TextScore.Name = "Lb_TextScore";
            this.Lb_TextScore.Size = new System.Drawing.Size(70, 25);
            this.Lb_TextScore.TabIndex = 13;
            this.Lb_TextScore.Text = "Score : ";
            // 
            // Lb_Score
            // 
            this.Lb_Score.AutoSize = true;
            this.Lb_Score.Location = new System.Drawing.Point(103, 15);
            this.Lb_Score.Name = "Lb_Score";
            this.Lb_Score.Size = new System.Drawing.Size(0, 25);
            this.Lb_Score.TabIndex = 14;
            // 
            // B_Lancer
            // 
            this.B_Lancer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.B_Lancer.ForeColor = System.Drawing.Color.Green;
            this.B_Lancer.Location = new System.Drawing.Point(993, 503);
            this.B_Lancer.Name = "B_Lancer";
            this.B_Lancer.Size = new System.Drawing.Size(112, 34);
            this.B_Lancer.TabIndex = 15;
            this.B_Lancer.Text = "Lancer";
            this.B_Lancer.UseVisualStyleBackColor = true;
            this.B_Lancer.Click += new System.EventHandler(this.B_Lancer_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // P_IntervalleImages
            // 
            this.P_IntervalleImages.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.P_IntervalleImages.Controls.Add(this.Lb_TextA);
            this.P_IntervalleImages.Controls.Add(this.Tb_FinInterval);
            this.P_IntervalleImages.Controls.Add(this.Tb_DebutInterval);
            this.P_IntervalleImages.Controls.Add(this.Lb_TextDe);
            this.P_IntervalleImages.Location = new System.Drawing.Point(12, 649);
            this.P_IntervalleImages.Name = "P_IntervalleImages";
            this.P_IntervalleImages.Size = new System.Drawing.Size(193, 64);
            this.P_IntervalleImages.TabIndex = 17;
            // 
            // Lb_TextA
            // 
            this.Lb_TextA.AutoSize = true;
            this.Lb_TextA.Location = new System.Drawing.Point(98, 20);
            this.Lb_TextA.Name = "Lb_TextA";
            this.Lb_TextA.Size = new System.Drawing.Size(30, 25);
            this.Lb_TextA.TabIndex = 4;
            this.Lb_TextA.Text = "à :";
            // 
            // Tb_FinInterval
            // 
            this.Tb_FinInterval.Location = new System.Drawing.Point(124, 17);
            this.Tb_FinInterval.Name = "Tb_FinInterval";
            this.Tb_FinInterval.Size = new System.Drawing.Size(40, 31);
            this.Tb_FinInterval.TabIndex = 3;
            this.Tb_FinInterval.TextChanged += new System.EventHandler(this.Tb_FinInterval_TextChanged_1);
            // 
            // Tb_DebutInterval
            // 
            this.Tb_DebutInterval.Location = new System.Drawing.Point(45, 17);
            this.Tb_DebutInterval.Name = "Tb_DebutInterval";
            this.Tb_DebutInterval.Size = new System.Drawing.Size(40, 31);
            this.Tb_DebutInterval.TabIndex = 1;
            this.Tb_DebutInterval.TextChanged += new System.EventHandler(this.Tb_DebutInterval_TextChanged_1);
            // 
            // Lb_TextDe
            // 
            this.Lb_TextDe.AutoSize = true;
            this.Lb_TextDe.Location = new System.Drawing.Point(5, 17);
            this.Lb_TextDe.Name = "Lb_TextDe";
            this.Lb_TextDe.Size = new System.Drawing.Size(48, 25);
            this.Lb_TextDe.TabIndex = 0;
            this.Lb_TextDe.Text = "De : ";
            // 
            // Tb_Timer
            // 
            this.Tb_Timer.Location = new System.Drawing.Point(14, 40);
            this.Tb_Timer.Maximum = 1500;
            this.Tb_Timer.Minimum = 100;
            this.Tb_Timer.Name = "Tb_Timer";
            this.Tb_Timer.Size = new System.Drawing.Size(229, 69);
            this.Tb_Timer.TabIndex = 18;
            this.Tb_Timer.TickFrequency = 100;
            this.Tb_Timer.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.Tb_Timer.Value = 500;
            this.Tb_Timer.ValueChanged += new System.EventHandler(this.Tb_Timer_ValueChanged);
            // 
            // Lb_ValeurScore
            // 
            this.Lb_ValeurScore.AutoSize = true;
            this.Lb_ValeurScore.Location = new System.Drawing.Point(191, 15);
            this.Lb_ValeurScore.Name = "Lb_ValeurScore";
            this.Lb_ValeurScore.Size = new System.Drawing.Size(27, 25);
            this.Lb_ValeurScore.TabIndex = 19;
            this.Lb_ValeurScore.Text = "%";
            // 
            // P_AffichageScore
            // 
            this.P_AffichageScore.Controls.Add(this.Lb_TextScore);
            this.P_AffichageScore.Controls.Add(this.Lb_ValeurScore);
            this.P_AffichageScore.Location = new System.Drawing.Point(517, 499);
            this.P_AffichageScore.Name = "P_AffichageScore";
            this.P_AffichageScore.Size = new System.Drawing.Size(264, 56);
            this.P_AffichageScore.TabIndex = 20;
            // 
            // Lb_ScoreMoyenne
            // 
            this.Lb_ScoreMoyenne.AutoSize = true;
            this.Lb_ScoreMoyenne.Location = new System.Drawing.Point(3, 15);
            this.Lb_ScoreMoyenne.Name = "Lb_ScoreMoyenne";
            this.Lb_ScoreMoyenne.Size = new System.Drawing.Size(188, 25);
            this.Lb_ScoreMoyenne.TabIndex = 13;
            this.Lb_ScoreMoyenne.Text = "Moyenne des scores : ";
            // 
            // Lb_ValeurScoreMoy
            // 
            this.Lb_ValeurScoreMoy.AutoSize = true;
            this.Lb_ValeurScoreMoy.Location = new System.Drawing.Point(197, 15);
            this.Lb_ValeurScoreMoy.Name = "Lb_ValeurScoreMoy";
            this.Lb_ValeurScoreMoy.Size = new System.Drawing.Size(27, 25);
            this.Lb_ValeurScoreMoy.TabIndex = 19;
            this.Lb_ValeurScoreMoy.Text = "%";
            // 
            // P_AffichageScoreMoy
            // 
            this.P_AffichageScoreMoy.Controls.Add(this.Lb_ScoreMoyenne);
            this.P_AffichageScoreMoy.Controls.Add(this.Lb_ValeurScoreMoy);
            this.P_AffichageScoreMoy.Controls.Add(this.Lb_Score);
            this.P_AffichageScoreMoy.Location = new System.Drawing.Point(517, 561);
            this.P_AffichageScoreMoy.Name = "P_AffichageScoreMoy";
            this.P_AffichageScoreMoy.Size = new System.Drawing.Size(264, 56);
            this.P_AffichageScoreMoy.TabIndex = 21;
            // 
            // B_Quitter
            // 
            this.B_Quitter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_Quitter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.B_Quitter.ForeColor = System.Drawing.Color.Firebrick;
            this.B_Quitter.Location = new System.Drawing.Point(1377, 15);
            this.B_Quitter.Name = "B_Quitter";
            this.B_Quitter.Size = new System.Drawing.Size(112, 34);
            this.B_Quitter.TabIndex = 22;
            this.B_Quitter.Text = "Quitter";
            this.B_Quitter.UseVisualStyleBackColor = false;
            this.B_Quitter.Click += new System.EventHandler(this.B_Quitter_Click_1);
            // 
            // Cb_ExportCSV
            // 
            this.Cb_ExportCSV.AutoSize = true;
            this.Cb_ExportCSV.Location = new System.Drawing.Point(993, 583);
            this.Cb_ExportCSV.Name = "Cb_ExportCSV";
            this.Cb_ExportCSV.Size = new System.Drawing.Size(121, 29);
            this.Cb_ExportCSV.TabIndex = 23;
            this.Cb_ExportCSV.Text = "ExportCSV";
            this.Cb_ExportCSV.UseVisualStyleBackColor = true;
            // 
            // Lb_TextTimer
            // 
            this.Lb_TextTimer.AutoSize = true;
            this.Lb_TextTimer.Location = new System.Drawing.Point(63, 6);
            this.Lb_TextTimer.Name = "Lb_TextTimer";
            this.Lb_TextTimer.Size = new System.Drawing.Size(109, 25);
            this.Lb_TextTimer.TabIndex = 20;
            this.Lb_TextTimer.Text = "Timer (ms) : ";
            // 
            // Lb_ValeurTimer
            // 
            this.Lb_ValeurTimer.AutoSize = true;
            this.Lb_ValeurTimer.Location = new System.Drawing.Point(100, 104);
            this.Lb_ValeurTimer.Name = "Lb_ValeurTimer";
            this.Lb_ValeurTimer.Size = new System.Drawing.Size(0, 25);
            this.Lb_ValeurTimer.TabIndex = 25;
            // 
            // P_NbImages
            // 
            this.P_NbImages.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.P_NbImages.Controls.Add(this.Cb_ToutesImages);
            this.P_NbImages.Controls.Add(this.Cb_Intervalle);
            this.P_NbImages.Controls.Add(this.Cb_ImageSeule);
            this.P_NbImages.Location = new System.Drawing.Point(14, 546);
            this.P_NbImages.Name = "P_NbImages";
            this.P_NbImages.Size = new System.Drawing.Size(191, 89);
            this.P_NbImages.TabIndex = 26;
            // 
            // Cb_ToutesImages
            // 
            this.Cb_ToutesImages.AutoSize = true;
            this.Cb_ToutesImages.Location = new System.Drawing.Point(5, 30);
            this.Cb_ToutesImages.Name = "Cb_ToutesImages";
            this.Cb_ToutesImages.Size = new System.Drawing.Size(189, 29);
            this.Cb_ToutesImages.TabIndex = 2;
            this.Cb_ToutesImages.Text = "Totalité des images";
            this.Cb_ToutesImages.UseVisualStyleBackColor = true;
            this.Cb_ToutesImages.CheckedChanged += new System.EventHandler(this.Cb_ToutesImages_CheckedChanged_1);
            // 
            // Cb_Intervalle
            // 
            this.Cb_Intervalle.AutoSize = true;
            this.Cb_Intervalle.Location = new System.Drawing.Point(5, 55);
            this.Cb_Intervalle.Name = "Cb_Intervalle";
            this.Cb_Intervalle.Size = new System.Drawing.Size(109, 29);
            this.Cb_Intervalle.TabIndex = 1;
            this.Cb_Intervalle.Text = "Intervalle";
            this.Cb_Intervalle.UseVisualStyleBackColor = true;
            this.Cb_Intervalle.CheckedChanged += new System.EventHandler(this.Cb_Intervalle_CheckedChanged_1);
            // 
            // Cb_ImageSeule
            // 
            this.Cb_ImageSeule.AutoSize = true;
            this.Cb_ImageSeule.Checked = true;
            this.Cb_ImageSeule.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cb_ImageSeule.Location = new System.Drawing.Point(5, 5);
            this.Cb_ImageSeule.Name = "Cb_ImageSeule";
            this.Cb_ImageSeule.Size = new System.Drawing.Size(135, 29);
            this.Cb_ImageSeule.TabIndex = 0;
            this.Cb_ImageSeule.Text = "Image Seule";
            this.Cb_ImageSeule.UseVisualStyleBackColor = true;
            this.Cb_ImageSeule.CheckedChanged += new System.EventHandler(this.Cb_ImageSeule_CheckedChanged_1);
            // 
            // P_TypeImage
            // 
            this.P_TypeImage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.P_TypeImage.Controls.Add(this.Cb_ImageSc);
            this.P_TypeImage.Controls.Add(this.Cb_DeuxTypes);
            this.P_TypeImage.Controls.Add(this.Cb_ImageIn);
            this.P_TypeImage.Location = new System.Drawing.Point(14, 444);
            this.P_TypeImage.Name = "P_TypeImage";
            this.P_TypeImage.Size = new System.Drawing.Size(191, 89);
            this.P_TypeImage.TabIndex = 27;
            // 
            // Cb_ImageSc
            // 
            this.Cb_ImageSc.AutoSize = true;
            this.Cb_ImageSc.Location = new System.Drawing.Point(5, 30);
            this.Cb_ImageSc.Name = "Cb_ImageSc";
            this.Cb_ImageSc.Size = new System.Drawing.Size(111, 29);
            this.Cb_ImageSc.TabIndex = 2;
            this.Cb_ImageSc.Text = "Image Sc";
            this.Cb_ImageSc.UseVisualStyleBackColor = true;
            this.Cb_ImageSc.CheckedChanged += new System.EventHandler(this.Cb_ImageSc_CheckedChanged);
            // 
            // Cb_DeuxTypes
            // 
            this.Cb_DeuxTypes.AutoSize = true;
            this.Cb_DeuxTypes.Location = new System.Drawing.Point(5, 55);
            this.Cb_DeuxTypes.Name = "Cb_DeuxTypes";
            this.Cb_DeuxTypes.Size = new System.Drawing.Size(126, 29);
            this.Cb_DeuxTypes.TabIndex = 1;
            this.Cb_DeuxTypes.Text = "Deux types";
            this.Cb_DeuxTypes.UseVisualStyleBackColor = true;
            this.Cb_DeuxTypes.CheckedChanged += new System.EventHandler(this.Cb_DeuxTypes_CheckedChanged_1);
            // 
            // Cb_ImageIn
            // 
            this.Cb_ImageIn.AutoSize = true;
            this.Cb_ImageIn.Checked = true;
            this.Cb_ImageIn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cb_ImageIn.Location = new System.Drawing.Point(5, 5);
            this.Cb_ImageIn.Name = "Cb_ImageIn";
            this.Cb_ImageIn.Size = new System.Drawing.Size(108, 29);
            this.Cb_ImageIn.TabIndex = 0;
            this.Cb_ImageIn.Text = "Image In";
            this.Cb_ImageIn.UseVisualStyleBackColor = true;
            this.Cb_ImageIn.CheckedChanged += new System.EventHandler(this.Cb_ImageIn_CheckedChanged_1);
            // 
            // B_Test
            // 
            this.B_Test.Location = new System.Drawing.Point(806, 397);
            this.B_Test.Name = "B_Test";
            this.B_Test.Size = new System.Drawing.Size(112, 34);
            this.B_Test.TabIndex = 28;
            this.B_Test.Text = "Test";
            this.B_Test.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // P_Error
            // 
            this.P_Error.Controls.Add(this.Lb_Error);
            this.P_Error.Location = new System.Drawing.Point(12, 722);
            this.P_Error.Name = "P_Error";
            this.P_Error.Size = new System.Drawing.Size(1507, 47);
            this.P_Error.TabIndex = 30;
            // 
            // Lb_Error
            // 
            this.Lb_Error.AutoSize = true;
            this.Lb_Error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_Error.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_Error.ForeColor = System.Drawing.Color.Firebrick;
            this.Lb_Error.Location = new System.Drawing.Point(0, 0);
            this.Lb_Error.Name = "Lb_Error";
            this.Lb_Error.Size = new System.Drawing.Size(0, 28);
            this.Lb_Error.TabIndex = 0;
            // 
            // P_Timer
            // 
            this.P_Timer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.P_Timer.Controls.Add(this.Lb_TextTimer);
            this.P_Timer.Controls.Add(this.Tb_Timer);
            this.P_Timer.Controls.Add(this.Lb_ValeurTimer);
            this.P_Timer.Location = new System.Drawing.Point(209, 579);
            this.P_Timer.Name = "P_Timer";
            this.P_Timer.Size = new System.Drawing.Size(252, 134);
            this.P_Timer.TabIndex = 31;
            // 
            // L_TextHistorique
            // 
            this.L_TextHistorique.AutoSize = true;
            this.L_TextHistorique.Location = new System.Drawing.Point(1352, 359);
            this.L_TextHistorique.Name = "L_TextHistorique";
            this.L_TextHistorique.Size = new System.Drawing.Size(94, 25);
            this.L_TextHistorique.TabIndex = 32;
            this.L_TextHistorique.Text = "Historique";
            // 
            // B_Areter
            // 
            this.B_Areter.Enabled = false;
            this.B_Areter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.B_Areter.ForeColor = System.Drawing.Color.Red;
            this.B_Areter.Location = new System.Drawing.Point(993, 543);
            this.B_Areter.Name = "B_Areter";
            this.B_Areter.Size = new System.Drawing.Size(112, 34);
            this.B_Areter.TabIndex = 33;
            this.B_Areter.Text = "Arrêter";
            this.B_Areter.UseVisualStyleBackColor = true;
            // 
            // L_info
            // 
            this.L_info.AutoSize = true;
            this.L_info.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.L_info.Location = new System.Drawing.Point(517, 463);
            this.L_info.Name = "L_info";
            this.L_info.Size = new System.Drawing.Size(77, 25);
            this.L_info.TabIndex = 34;
            this.L_info.Text = "Image : ";
            // 
            // Cb_TypeSE
            // 
            this.Cb_TypeSE.FormattingEnabled = true;
            this.Cb_TypeSE.Items.AddRange(new object[] {
            "V4",
            "V8",
            "Disque",
            "Ellipse",
            "Ligne Verticale ",
            "Ligne Horizontale ",
            "Rectangle"});
            this.Cb_TypeSE.Location = new System.Drawing.Point(5, 3);
            this.Cb_TypeSE.Name = "Cb_TypeSE";
            this.Cb_TypeSE.Size = new System.Drawing.Size(238, 33);
            this.Cb_TypeSE.TabIndex = 35;
            this.Cb_TypeSE.Text = "Type Element Structurant";
            // 
            // P_SE
            // 
            this.P_SE.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.P_SE.Controls.Add(this.Tb_LargeurSE);
            this.P_SE.Controls.Add(this.Tb_HauteurSE);
            this.P_SE.Controls.Add(this.L_TexteLargeurSE);
            this.P_SE.Controls.Add(this.L_TexteHauteurSE);
            this.P_SE.Controls.Add(this.Cb_TypeSE);
            this.P_SE.Location = new System.Drawing.Point(209, 444);
            this.P_SE.Name = "P_SE";
            this.P_SE.Size = new System.Drawing.Size(252, 129);
            this.P_SE.TabIndex = 36;
            // 
            // Tb_LargeurSE
            // 
            this.Tb_LargeurSE.Location = new System.Drawing.Point(100, 87);
            this.Tb_LargeurSE.Name = "Tb_LargeurSE";
            this.Tb_LargeurSE.Size = new System.Drawing.Size(50, 31);
            this.Tb_LargeurSE.TabIndex = 39;
            this.Tb_LargeurSE.Text = "3";
            // 
            // Tb_HauteurSE
            // 
            this.Tb_HauteurSE.Location = new System.Drawing.Point(100, 47);
            this.Tb_HauteurSE.Name = "Tb_HauteurSE";
            this.Tb_HauteurSE.Size = new System.Drawing.Size(50, 31);
            this.Tb_HauteurSE.TabIndex = 38;
            this.Tb_HauteurSE.Text = "3";
            // 
            // L_TexteLargeurSE
            // 
            this.L_TexteLargeurSE.AutoSize = true;
            this.L_TexteLargeurSE.Location = new System.Drawing.Point(14, 89);
            this.L_TexteLargeurSE.Name = "L_TexteLargeurSE";
            this.L_TexteLargeurSE.Size = new System.Drawing.Size(80, 25);
            this.L_TexteLargeurSE.TabIndex = 37;
            this.L_TexteLargeurSE.Text = "Largeur :";
            // 
            // L_TexteHauteurSE
            // 
            this.L_TexteHauteurSE.AutoSize = true;
            this.L_TexteHauteurSE.Location = new System.Drawing.Point(14, 50);
            this.L_TexteHauteurSE.Name = "L_TexteHauteurSE";
            this.L_TexteHauteurSE.Size = new System.Drawing.Size(89, 25);
            this.L_TexteHauteurSE.TabIndex = 36;
            this.L_TexteHauteurSE.Text = "Hauteur : ";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 772);
            this.ControlBox = false;
            this.Controls.Add(this.P_IntervalleImages);
            this.Controls.Add(this.P_NbImages);
            this.Controls.Add(this.P_TypeImage);
            this.Controls.Add(this.Lb_Options);
            this.Controls.Add(this.L_info);
            this.Controls.Add(this.P_Timer);
            this.Controls.Add(this.P_SE);
            this.Controls.Add(this.B_Areter);
            this.Controls.Add(this.L_TextHistorique);
            this.Controls.Add(this.P_Error);
            this.Controls.Add(this.B_Test);
            this.Controls.Add(this.Cb_ExportCSV);
            this.Controls.Add(this.B_Quitter);
            this.Controls.Add(this.P_AffichageScoreMoy);
            this.Controls.Add(this.P_AffichageScore);
            this.Controls.Add(this.B_Lancer);
            this.Controls.Add(this.Lb_TreatedImage);
            this.Controls.Add(this.Lb_GroundTruth);
            this.Controls.Add(this.Lb_InitialImage);
            this.Controls.Add(this.Pb_GroundTruth);
            this.Controls.Add(this.Pb_TreatedImage3);
            this.Controls.Add(this.Pb_TreatedImage2);
            this.Controls.Add(this.Pb_TreatedImage1);
            this.Controls.Add(this.Pb_TreatedImage);
            this.Controls.Add(this.Pb_InitialImage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projet C++";
            ((System.ComponentModel.ISupportInitialize)(this.Pb_InitialImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_TreatedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_TreatedImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_TreatedImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_TreatedImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_GroundTruth)).EndInit();
            this.P_IntervalleImages.ResumeLayout(false);
            this.P_IntervalleImages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tb_Timer)).EndInit();
            this.P_AffichageScore.ResumeLayout(false);
            this.P_AffichageScore.PerformLayout();
            this.P_AffichageScoreMoy.ResumeLayout(false);
            this.P_AffichageScoreMoy.PerformLayout();
            this.P_NbImages.ResumeLayout(false);
            this.P_NbImages.PerformLayout();
            this.P_TypeImage.ResumeLayout(false);
            this.P_TypeImage.PerformLayout();
            this.P_Error.ResumeLayout(false);
            this.P_Error.PerformLayout();
            this.P_Timer.ResumeLayout(false);
            this.P_Timer.PerformLayout();
            this.P_SE.ResumeLayout(false);
            this.P_SE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Pb_InitialImage;
        private PictureBox Pb_TreatedImage;
        private PictureBox Pb_TreatedImage1;
        private PictureBox Pb_TreatedImage2;
        private PictureBox Pb_TreatedImage3;
        private PictureBox Pb_GroundTruth;
        private Label Lb_InitialImage;
        private Label Lb_GroundTruth;
        private Label Lb_TreatedImage;
        private Label Lb_Options;
        private Label Lb_TextScore;
        private Label Lb_Score;
        private Button B_Lancer;
        private OpenFileDialog ofd;
        private Panel P_IntervalleImages;
        private TextBox Tb_FinInterval;
        private Label L_A;
        private TextBox Tb_DebutInterval;
        private Label Lb_TextDe;
        private TrackBar Tb_Timer;
        private Label Lb_ValeurScore;

        private Panel P_AffichageScore;
        private Label Lb_ScoreMoyenne;
        private Label Lb_ValeurScoreMoy;
        private Panel P_AffichageScoreMoy;

        private Button B_Quitter;
        private CheckBox Cb_ExportCSV;
        private Label Lb_TextTimer;
        private Label Lb_ValeurTimer;
        private Panel P_NbImages;
        private CheckBox Cb_ToutesImages;
        private CheckBox Cb_Intervalle;
        private CheckBox Cb_ImageSeule;
        private Panel P_TypeImage;
        private CheckBox Cb_ImageSc;
        private CheckBox Cb_DeuxTypes;
        private CheckBox Cb_ImageIn;

        private Button B_Test;
        private System.Windows.Forms.Timer timer1;
        private Label Lb_TextA;
        private Panel P_Error;
        private Label Lb_Error;
        private Panel P_Timer;
        private Label L_TextHistorique;
        private Button B_Areter;
        private Label L_info;
        private ComboBox Cb_TypeSE;
        private Panel P_SE;
        private Label L_TexteLargeurSE;
        private Label L_TexteHauteurSE;
        private TextBox Tb_LargeurSE;
        private TextBox Tb_HauteurSE;
        private FileSystemWatcher fileSystemWatcher1;
    }
}