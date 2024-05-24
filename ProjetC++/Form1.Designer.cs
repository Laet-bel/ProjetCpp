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
            components = new System.ComponentModel.Container();
            PB_InitialImage = new PictureBox();
            PB_TreatedImage = new PictureBox();
            PB_TreatedImage1 = new PictureBox();
            PB_TreatedImage2 = new PictureBox();
            PB_TreatedImage3 = new PictureBox();
            PB_GroundTruth = new PictureBox();
            Lb_InitialImage = new Label();
            Lb_GroundTruth = new Label();
            Lb_TreatedImage = new Label();
            Lb_OPTIONS = new Label();
            L_TextScore = new Label();
            L_Score = new Label();
            B_Lancer = new Button();
            ofd = new OpenFileDialog();
            P_IntervalleImages = new Panel();
            L_Textà = new Label();
            Tb_FinInterval = new TextBox();
            Tb_DebutInterval = new TextBox();
            L_TextDe = new Label();
            Tb_Timer = new TrackBar();
            Lb_ValeurScore = new Label();
            PanelAffichageScore = new Panel();
            label1 = new Label();
            Lb_ValeurScoreMoy = new Label();
            PanelAffichageScoreMoy = new Panel();
            B_Quitter = new Button();
            CB_ExportCSV = new CheckBox();
            LB_Timer = new Label();
            LB_ValeurTimer = new Label();
            P_NbImages = new Panel();
            Cb_ToutesImages = new CheckBox();
            Cb_Intervalle = new CheckBox();
            Cb_ImageSeule = new CheckBox();
            P_TypeImage = new Panel();
            Cb_ImageSc = new CheckBox();
            Cb_DeuxTypes = new CheckBox();
            Cb_ImageIn = new CheckBox();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            P_Error = new Panel();
            L_Error = new Label();
            ((System.ComponentModel.ISupportInitialize)PB_InitialImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PB_TreatedImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PB_TreatedImage1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PB_TreatedImage2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PB_TreatedImage3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PB_GroundTruth).BeginInit();
            P_IntervalleImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Tb_Timer).BeginInit();
            PanelAffichageScore.SuspendLayout();
            PanelAffichageScoreMoy.SuspendLayout();
            P_NbImages.SuspendLayout();
            P_TypeImage.SuspendLayout();
            P_Error.SuspendLayout();
            SuspendLayout();
            // 
            // PB_InitialImage
            // 
            PB_InitialImage.BackColor = SystemColors.Highlight;
            PB_InitialImage.BorderStyle = BorderStyle.FixedSingle;
            PB_InitialImage.Location = new Point(15, 15);
            PB_InitialImage.Margin = new Padding(4);
            PB_InitialImage.Name = "PB_InitialImage";
            PB_InitialImage.Size = new Size(465, 417);
            PB_InitialImage.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_InitialImage.TabIndex = 0;
            PB_InitialImage.TabStop = false;
            // 
            // PB_TreatedImage
            // 
            PB_TreatedImage.BackColor = SystemColors.GradientActiveCaption;
            PB_TreatedImage.BorderStyle = BorderStyle.FixedSingle;
            PB_TreatedImage.Location = new Point(488, 15);
            PB_TreatedImage.Margin = new Padding(4);
            PB_TreatedImage.Name = "PB_TreatedImage";
            PB_TreatedImage.Size = new Size(465, 417);
            PB_TreatedImage.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_TreatedImage.TabIndex = 1;
            PB_TreatedImage.TabStop = false;
            // 
            // PB_TreatedImage1
            // 
            PB_TreatedImage1.BackColor = SystemColors.GradientActiveCaption;
            PB_TreatedImage1.BorderStyle = BorderStyle.FixedSingle;
            PB_TreatedImage1.Location = new Point(960, 15);
            PB_TreatedImage1.Name = "PB_TreatedImage1";
            PB_TreatedImage1.Size = new Size(249, 135);
            PB_TreatedImage1.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_TreatedImage1.TabIndex = 2;
            PB_TreatedImage1.TabStop = false;
            // 
            // PB_TreatedImage2
            // 
            PB_TreatedImage2.BackColor = SystemColors.GradientActiveCaption;
            PB_TreatedImage2.BorderStyle = BorderStyle.FixedSingle;
            PB_TreatedImage2.Location = new Point(960, 156);
            PB_TreatedImage2.Name = "PB_TreatedImage2";
            PB_TreatedImage2.Size = new Size(249, 135);
            PB_TreatedImage2.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_TreatedImage2.TabIndex = 3;
            PB_TreatedImage2.TabStop = false;
            // 
            // PB_TreatedImage3
            // 
            PB_TreatedImage3.BackColor = SystemColors.GradientActiveCaption;
            PB_TreatedImage3.BorderStyle = BorderStyle.FixedSingle;
            PB_TreatedImage3.Location = new Point(960, 297);
            PB_TreatedImage3.Name = "PB_TreatedImage3";
            PB_TreatedImage3.Size = new Size(249, 135);
            PB_TreatedImage3.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_TreatedImage3.TabIndex = 4;
            PB_TreatedImage3.TabStop = false;
            // 
            // PB_GroundTruth
            // 
            PB_GroundTruth.BackColor = SystemColors.ActiveCaption;
            PB_GroundTruth.BorderStyle = BorderStyle.FixedSingle;
            PB_GroundTruth.Location = new Point(1273, 15);
            PB_GroundTruth.Margin = new Padding(4);
            PB_GroundTruth.Name = "PB_GroundTruth";
            PB_GroundTruth.Size = new Size(465, 417);
            PB_GroundTruth.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_GroundTruth.TabIndex = 5;
            PB_GroundTruth.TabStop = false;
            // 
            // Lb_InitialImage
            // 
            Lb_InitialImage.AutoSize = true;
            Lb_InitialImage.Location = new Point(202, 436);
            Lb_InitialImage.Name = "Lb_InitialImage";
            Lb_InitialImage.Size = new Size(109, 25);
            Lb_InitialImage.TabIndex = 6;
            Lb_InitialImage.Text = "Initial Image";
            // 
            // Lb_GroundTruth
            // 
            Lb_GroundTruth.AutoSize = true;
            Lb_GroundTruth.Location = new Point(1482, 436);
            Lb_GroundTruth.Name = "Lb_GroundTruth";
            Lb_GroundTruth.Size = new Size(116, 25);
            Lb_GroundTruth.TabIndex = 7;
            Lb_GroundTruth.Text = "Ground Truth";
            // 
            // Lb_TreatedImage
            // 
            Lb_TreatedImage.AutoSize = true;
            Lb_TreatedImage.Location = new Point(686, 436);
            Lb_TreatedImage.Name = "Lb_TreatedImage";
            Lb_TreatedImage.Size = new Size(124, 25);
            Lb_TreatedImage.TabIndex = 8;
            Lb_TreatedImage.Text = "Treated Image";
            // 
            // Lb_OPTIONS
            // 
            Lb_OPTIONS.AutoSize = true;
            Lb_OPTIONS.Location = new Point(68, 468);
            Lb_OPTIONS.Name = "Lb_OPTIONS";
            Lb_OPTIONS.Size = new Size(87, 25);
            Lb_OPTIONS.TabIndex = 9;
            Lb_OPTIONS.Text = "OPTIONS";
            // 
            // L_TextScore
            // 
            L_TextScore.AutoSize = true;
            L_TextScore.Location = new Point(3, 15);
            L_TextScore.Name = "L_TextScore";
            L_TextScore.Size = new Size(70, 25);
            L_TextScore.TabIndex = 13;
            L_TextScore.Text = "Score : ";
            // 
            // L_Score
            // 
            L_Score.AutoSize = true;
            L_Score.Location = new Point(505, 561);
            L_Score.Name = "L_Score";
            L_Score.Size = new Size(0, 25);
            L_Score.TabIndex = 14;
            // 
            // B_Lancer
            // 
            B_Lancer.Location = new Point(911, 468);
            B_Lancer.Name = "B_Lancer";
            B_Lancer.Size = new Size(112, 34);
            B_Lancer.TabIndex = 15;
            B_Lancer.Text = "Lancer";
            B_Lancer.UseVisualStyleBackColor = true;
            B_Lancer.Click += B_Lancer_Click_1;
            // 
            // ofd
            // 
            ofd.FileName = "openFileDialog1";
            // 
            // P_IntervalleImages
            // 
            P_IntervalleImages.Controls.Add(L_Textà);
            P_IntervalleImages.Controls.Add(Tb_FinInterval);
            P_IntervalleImages.Controls.Add(Tb_DebutInterval);
            P_IntervalleImages.Controls.Add(L_TextDe);
            P_IntervalleImages.Location = new Point(20, 692);
            P_IntervalleImages.Name = "P_IntervalleImages";
            P_IntervalleImages.Size = new Size(206, 64);
            P_IntervalleImages.TabIndex = 17;
            // 
            // L_Textà
            // 
            L_Textà.AutoSize = true;
            L_Textà.Location = new Point(95, 20);
            L_Textà.Name = "L_Textà";
            L_Textà.Size = new Size(25, 25);
            L_Textà.TabIndex = 4;
            L_Textà.Text = "à:";
            // 
            // Tb_FinInterval
            // 
            Tb_FinInterval.Location = new Point(135, 17);
            Tb_FinInterval.Name = "Tb_FinInterval";
            Tb_FinInterval.Size = new Size(40, 31);
            Tb_FinInterval.TabIndex = 3;
            Tb_FinInterval.TextChanged += Tb_FinInterval_TextChanged;
            // 
            // Tb_DebutInterval
            // 
            Tb_DebutInterval.Location = new Point(45, 17);
            Tb_DebutInterval.Name = "Tb_DebutInterval";
            Tb_DebutInterval.Size = new Size(40, 31);
            Tb_DebutInterval.TabIndex = 1;
            Tb_DebutInterval.TextChanged += Tb_DebutInterval_TextChanged;
            // 
            // L_TextDe
            // 
            L_TextDe.AutoSize = true;
            L_TextDe.Location = new Point(5, 17);
            L_TextDe.Name = "L_TextDe";
            L_TextDe.Size = new Size(48, 25);
            L_TextDe.TabIndex = 0;
            L_TextDe.Text = "De : ";
            // 
            // Tb_Timer
            // 
            Tb_Timer.Location = new Point(911, 628);
            Tb_Timer.Maximum = 1000;
            Tb_Timer.Minimum = 10;
            Tb_Timer.Name = "Tb_Timer";
            Tb_Timer.Size = new Size(112, 69);
            Tb_Timer.TabIndex = 18;
            Tb_Timer.TickFrequency = 100;
            Tb_Timer.TickStyle = TickStyle.Both;
            Tb_Timer.Value = 10;
            Tb_Timer.Scroll += Tb_Timer_Scroll_1;
            // 
            // Lb_ValeurScore
            // 
            Lb_ValeurScore.AutoSize = true;
            Lb_ValeurScore.Location = new Point(106, 15);
            Lb_ValeurScore.Name = "Lb_ValeurScore";
            Lb_ValeurScore.Size = new Size(27, 25);
            Lb_ValeurScore.TabIndex = 19;
            Lb_ValeurScore.Text = "%";
            // 
            // PanelAffichageScore
            // 
            PanelAffichageScore.Controls.Add(L_TextScore);
            PanelAffichageScore.Controls.Add(Lb_ValeurScore);
            PanelAffichageScore.Location = new Point(425, 493);
            PanelAffichageScore.Name = "PanelAffichageScore";
            PanelAffichageScore.Size = new Size(177, 56);
            PanelAffichageScore.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 13;
            label1.Text = "ScoreMoy : ";
            // 
            // Lb_ValeurScoreMoy
            // 
            Lb_ValeurScoreMoy.AutoSize = true;
            Lb_ValeurScoreMoy.Location = new Point(109, 15);
            Lb_ValeurScoreMoy.Name = "Lb_ValeurScoreMoy";
            Lb_ValeurScoreMoy.Size = new Size(27, 25);
            Lb_ValeurScoreMoy.TabIndex = 19;
            Lb_ValeurScoreMoy.Text = "%";
            // 
            // PanelAffichageScoreMoy
            // 
            PanelAffichageScoreMoy.Controls.Add(label1);
            PanelAffichageScoreMoy.Controls.Add(Lb_ValeurScoreMoy);
            PanelAffichageScoreMoy.Location = new Point(422, 572);
            PanelAffichageScoreMoy.Name = "PanelAffichageScoreMoy";
            PanelAffichageScoreMoy.Size = new Size(177, 56);
            PanelAffichageScoreMoy.TabIndex = 21;
            // 
            // B_Quitter
            // 
            B_Quitter.BackColor = SystemColors.ButtonHighlight;
            B_Quitter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            B_Quitter.ForeColor = Color.Firebrick;
            B_Quitter.Location = new Point(911, 521);
            B_Quitter.Name = "B_Quitter";
            B_Quitter.Size = new Size(112, 34);
            B_Quitter.TabIndex = 22;
            B_Quitter.Text = "Quitter";
            B_Quitter.UseVisualStyleBackColor = false;
            B_Quitter.Click += B_Quitter_Click_1;
            // 
            // CB_ExportCSV
            // 
            CB_ExportCSV.AutoSize = true;
            CB_ExportCSV.Location = new Point(911, 572);
            CB_ExportCSV.Name = "CB_ExportCSV";
            CB_ExportCSV.Size = new Size(121, 29);
            CB_ExportCSV.TabIndex = 23;
            CB_ExportCSV.Text = "ExportCSV";
            CB_ExportCSV.UseVisualStyleBackColor = true;
            // 
            // LB_Timer
            // 
            LB_Timer.AutoSize = true;
            LB_Timer.Location = new Point(947, 606);
            LB_Timer.Name = "LB_Timer";
            LB_Timer.Size = new Size(56, 25);
            LB_Timer.TabIndex = 20;
            LB_Timer.Text = "Timer";
            // 
            // LB_ValeurTimer
            // 
            LB_ValeurTimer.AutoSize = true;
            LB_ValeurTimer.Location = new Point(911, 697);
            LB_ValeurTimer.Name = "LB_ValeurTimer";
            LB_ValeurTimer.Size = new Size(104, 25);
            LB_ValeurTimer.TabIndex = 25;
            LB_ValeurTimer.Text = "ValeurTimer";
            // 
            // P_NbImages
            // 
            P_NbImages.BackColor = SystemColors.ButtonHighlight;
            P_NbImages.Controls.Add(Cb_ToutesImages);
            P_NbImages.Controls.Add(Cb_Intervalle);
            P_NbImages.Controls.Add(Cb_ImageSeule);
            P_NbImages.Location = new Point(20, 597);
            P_NbImages.Name = "P_NbImages";
            P_NbImages.Size = new Size(206, 89);
            P_NbImages.TabIndex = 26;
            // 
            // Cb_ToutesImages
            // 
            Cb_ToutesImages.AutoSize = true;
            Cb_ToutesImages.Location = new Point(5, 30);
            Cb_ToutesImages.Name = "Cb_ToutesImages";
            Cb_ToutesImages.Size = new Size(189, 29);
            Cb_ToutesImages.TabIndex = 2;
            Cb_ToutesImages.Text = "Totalité des images";
            Cb_ToutesImages.UseVisualStyleBackColor = true;

            Cb_ToutesImages.CheckedChanged += Cb_ToutesImages_CheckedChanged;

            // 
            // Cb_Intervalle
            // 
            Cb_Intervalle.AutoSize = true;
            Cb_Intervalle.Location = new Point(5, 55);
            Cb_Intervalle.Name = "Cb_Intervalle";
            Cb_Intervalle.Size = new Size(109, 29);
            Cb_Intervalle.TabIndex = 1;
            Cb_Intervalle.Text = "Intervalle";
            Cb_Intervalle.UseVisualStyleBackColor = true;
            Cb_Intervalle.CheckedChanged += Cb_Intervalle_CheckedChanged;
            // 
            // Cb_ImageSeule
            // 
            Cb_ImageSeule.AutoSize = true;
            Cb_ImageSeule.Checked = true;
            Cb_ImageSeule.CheckState = CheckState.Checked;
            Cb_ImageSeule.Location = new Point(5, 5);
            Cb_ImageSeule.Name = "Cb_ImageSeule";
            Cb_ImageSeule.Size = new Size(135, 29);
            Cb_ImageSeule.TabIndex = 0;
            Cb_ImageSeule.Text = "Image Seule";
            Cb_ImageSeule.UseVisualStyleBackColor = true;

            Cb_ImageSeule.CheckedChanged += Cb_ImageSeule_CheckedChanged;

            // 
            // P_TypeImage
            // 
            P_TypeImage.BackColor = SystemColors.ButtonHighlight;
            P_TypeImage.Controls.Add(Cb_ImageSc);
            P_TypeImage.Controls.Add(Cb_DeuxTypes);
            P_TypeImage.Controls.Add(Cb_ImageIn);
            P_TypeImage.Location = new Point(20, 502);
            P_TypeImage.Name = "P_TypeImage";
            P_TypeImage.Size = new Size(206, 89);
            P_TypeImage.TabIndex = 27;
            // 
            // Cb_ImageSc
            // 
            Cb_ImageSc.AutoSize = true;
            Cb_ImageSc.Location = new Point(5, 30);
            Cb_ImageSc.Name = "Cb_ImageSc";
            Cb_ImageSc.Size = new Size(111, 29);
            Cb_ImageSc.TabIndex = 2;
            Cb_ImageSc.Text = "Image Sc";
            Cb_ImageSc.UseVisualStyleBackColor = true;
            Cb_ImageSc.CheckedChanged += Cb_ImageSc_CheckedChanged;
            // 
            // Cb_DeuxTypes
            // 
            Cb_DeuxTypes.AutoSize = true;
            Cb_DeuxTypes.Location = new Point(5, 55);
            Cb_DeuxTypes.Name = "Cb_DeuxTypes";
            Cb_DeuxTypes.Size = new Size(126, 29);
            Cb_DeuxTypes.TabIndex = 1;
            Cb_DeuxTypes.Text = "Deux types";
            Cb_DeuxTypes.UseVisualStyleBackColor = true;
            Cb_DeuxTypes.CheckedChanged += Cb_DeuxTypes_CheckedChanged;
            // 
            // Cb_ImageIn
            // 
            Cb_ImageIn.AutoSize = true;
            Cb_ImageIn.Checked = true;
            Cb_ImageIn.CheckState = CheckState.Checked;
            Cb_ImageIn.Location = new Point(5, 5);
            Cb_ImageIn.Name = "Cb_ImageIn";
            Cb_ImageIn.Size = new Size(108, 29);
            Cb_ImageIn.TabIndex = 0;
            Cb_ImageIn.Text = "Image In";
            Cb_ImageIn.UseVisualStyleBackColor = true;
            Cb_ImageIn.CheckedChanged += Cb_ImageIn_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(681, 701);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 28;
            button1.Text = "Test";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BT_Test;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // P_Error
            // 
            P_Error.Controls.Add(L_Error);
            P_Error.Location = new Point(20, 762);
            P_Error.Name = "P_Error";
            P_Error.Size = new Size(1718, 47);
            P_Error.TabIndex = 30;
            // 
            // L_Error
            // 
            L_Error.AutoSize = true;
            L_Error.Dock = DockStyle.Fill;
            L_Error.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            L_Error.ForeColor = Color.Firebrick;
            L_Error.Location = new Point(0, 0);
            L_Error.Name = "L_Error";
            L_Error.Size = new Size(0, 28);
            L_Error.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1751, 815);
            ControlBox = false;
            Controls.Add(P_Error);
            Controls.Add(button1);
            Controls.Add(P_TypeImage);
            Controls.Add(P_NbImages);
            Controls.Add(LB_ValeurTimer);
            Controls.Add(LB_Timer);
            Controls.Add(CB_ExportCSV);
            Controls.Add(B_Quitter);
            Controls.Add(PanelAffichageScoreMoy);
            Controls.Add(PanelAffichageScore);
            Controls.Add(Tb_Timer);
            Controls.Add(P_IntervalleImages);
            Controls.Add(B_Lancer);
            Controls.Add(L_Score);
            Controls.Add(Lb_OPTIONS);
            Controls.Add(Lb_TreatedImage);
            Controls.Add(Lb_GroundTruth);
            Controls.Add(Lb_InitialImage);
            Controls.Add(PB_GroundTruth);
            Controls.Add(PB_TreatedImage3);
            Controls.Add(PB_TreatedImage2);
            Controls.Add(PB_TreatedImage1);
            Controls.Add(PB_TreatedImage);
            Controls.Add(PB_InitialImage);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Projet C++";
            ((System.ComponentModel.ISupportInitialize)PB_InitialImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)PB_TreatedImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)PB_TreatedImage1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PB_TreatedImage2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PB_TreatedImage3).EndInit();
            ((System.ComponentModel.ISupportInitialize)PB_GroundTruth).EndInit();
            P_IntervalleImages.ResumeLayout(false);
            P_IntervalleImages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Tb_Timer).EndInit();
            PanelAffichageScore.ResumeLayout(false);
            PanelAffichageScore.PerformLayout();
            PanelAffichageScoreMoy.ResumeLayout(false);
            PanelAffichageScoreMoy.PerformLayout();
            P_NbImages.ResumeLayout(false);
            P_NbImages.PerformLayout();
            P_TypeImage.ResumeLayout(false);
            P_TypeImage.PerformLayout();
            P_Error.ResumeLayout(false);
            P_Error.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PB_InitialImage;
        private PictureBox PB_TreatedImage;
        private PictureBox PB_TreatedImage1;
        private PictureBox PB_TreatedImage2;
        private PictureBox PB_TreatedImage3;
        private PictureBox PB_GroundTruth;
        private Label Lb_InitialImage;
        private Label Lb_GroundTruth;
        private Label Lb_TreatedImage;
        private Label Lb_OPTIONS;
        private Label L_TextScore;
        private Label L_Score;
        private Button B_Lancer;
        private OpenFileDialog ofd;
        private Panel P_IntervalleImages;
        private TextBox Tb_FinInterval;
        private Label L_A;
        private TextBox Tb_DebutInterval;
        private Label L_TextDe;
        private TrackBar Tb_Timer;
        private Label Lb_ValeurScore;
        private Panel PanelAffichageScore;
        private Label label1;
        private Label Lb_ValeurScoreMoy;
        private Panel PanelAffichageScoreMoy;
        private Button B_Quitter;
        private CheckBox CB_ExportCSV;
        private Label LB_Timer;
        private Label LB_ValeurTimer;
        private Panel P_NbImages;
        private CheckBox Cb_ToutesImages;
        private CheckBox Cb_Intervalle;
        private CheckBox Cb_ImageSeule;
        private Panel P_TypeImage;
        private CheckBox Cb_ImageSc;
        private CheckBox Cb_DeuxTypes;
        private CheckBox Cb_ImageIn;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private Label L_Textà;
        private Panel P_Error;
        private Label L_Error;
    }
}