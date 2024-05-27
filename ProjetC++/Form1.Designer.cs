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
            Pb_InitialImage = new PictureBox();
            Pb_TreatedImage = new PictureBox();
            Pb_TreatedImage1 = new PictureBox();
            Pb_TreatedImage2 = new PictureBox();
            Pb_TreatedImage3 = new PictureBox();
            Pb_GroundTruth = new PictureBox();
            Lb_InitialImage = new Label();
            Lb_GroundTruth = new Label();
            Lb_TreatedImage = new Label();
            Lb_Options = new Label();
            Lb_TextScore = new Label();
            Lb_Score = new Label();
            B_Lancer = new Button();
            ofd = new OpenFileDialog();
            P_IntervalleImages = new Panel();
            Lb_TextA = new Label();
            Tb_FinInterval = new TextBox();
            Tb_DebutInterval = new TextBox();
            Lb_TextDe = new Label();
            Tb_Timer = new TrackBar();
            Lb_ValeurScore = new Label();
            P_AffichageScore = new Panel();
            Lb_ScoreMoyenne = new Label();
            Lb_ValeurScoreMoy = new Label();
            P_AffichageScoreMoy = new Panel();
            B_Quitter = new Button();
            Cb_ExportCSV = new CheckBox();
            Lb_TextTimer = new Label();
            Lb_ValeurTimer = new Label();
            P_NbImages = new Panel();
            Cb_ToutesImages = new CheckBox();
            Cb_Intervalle = new CheckBox();
            Cb_ImageSeule = new CheckBox();
            P_TypeImage = new Panel();
            Cb_ImageSc = new CheckBox();
            Cb_DeuxTypes = new CheckBox();
            Cb_ImageIn = new CheckBox();
            B_Test = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            P_Error = new Panel();
            Lb_Error = new Label();
            P_Timer = new Panel();
            L_TextHistorique = new Label();
            B_Areter = new Button();
            ((System.ComponentModel.ISupportInitialize)Pb_InitialImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_TreatedImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_TreatedImage1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_TreatedImage2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_TreatedImage3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_GroundTruth).BeginInit();
            P_IntervalleImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Tb_Timer).BeginInit();
            P_AffichageScore.SuspendLayout();
            P_AffichageScoreMoy.SuspendLayout();
            P_NbImages.SuspendLayout();
            P_TypeImage.SuspendLayout();
            P_Error.SuspendLayout();
            P_Timer.SuspendLayout();
            SuspendLayout();
            // 
            // Pb_InitialImage
            // 
            Pb_InitialImage.BackColor = SystemColors.Highlight;
            Pb_InitialImage.BorderStyle = BorderStyle.Fixed3D;
            Pb_InitialImage.Location = new Point(15, 15);
            Pb_InitialImage.Margin = new Padding(4);
            Pb_InitialImage.Name = "Pb_InitialImage";
            Pb_InitialImage.Size = new Size(400, 340);
            Pb_InitialImage.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_InitialImage.TabIndex = 0;
            Pb_InitialImage.TabStop = false;
            // 
            // Pb_TreatedImage
            // 
            Pb_TreatedImage.BackColor = SystemColors.GradientActiveCaption;
            Pb_TreatedImage.BorderStyle = BorderStyle.FixedSingle;
            Pb_TreatedImage.Location = new Point(425, 15);
            Pb_TreatedImage.Margin = new Padding(4);
            Pb_TreatedImage.Name = "Pb_TreatedImage";
            Pb_TreatedImage.Size = new Size(400, 340);
            Pb_TreatedImage.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_TreatedImage.TabIndex = 1;
            Pb_TreatedImage.TabStop = false;
            // 
            // Pb_TreatedImage1
            // 
            Pb_TreatedImage1.BackColor = SystemColors.GradientActiveCaption;
            Pb_TreatedImage1.BorderStyle = BorderStyle.FixedSingle;
            Pb_TreatedImage1.Location = new Point(1307, 54);
            Pb_TreatedImage1.Name = "Pb_TreatedImage1";
            Pb_TreatedImage1.Size = new Size(180, 97);
            Pb_TreatedImage1.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_TreatedImage1.TabIndex = 2;
            Pb_TreatedImage1.TabStop = false;
            // 
            // Pb_TreatedImage2
            // 
            Pb_TreatedImage2.BackColor = SystemColors.GradientActiveCaption;
            Pb_TreatedImage2.BorderStyle = BorderStyle.FixedSingle;
            Pb_TreatedImage2.Location = new Point(1307, 156);
            Pb_TreatedImage2.Name = "Pb_TreatedImage2";
            Pb_TreatedImage2.Size = new Size(180, 97);
            Pb_TreatedImage2.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_TreatedImage2.TabIndex = 3;
            Pb_TreatedImage2.TabStop = false;
            // 
            // Pb_TreatedImage3
            // 
            Pb_TreatedImage3.BackColor = SystemColors.GradientActiveCaption;
            Pb_TreatedImage3.BorderStyle = BorderStyle.FixedSingle;
            Pb_TreatedImage3.Location = new Point(1307, 258);
            Pb_TreatedImage3.Name = "Pb_TreatedImage3";
            Pb_TreatedImage3.Size = new Size(180, 97);
            Pb_TreatedImage3.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_TreatedImage3.TabIndex = 4;
            Pb_TreatedImage3.TabStop = false;
            // 
            // Pb_GroundTruth
            // 
            Pb_GroundTruth.BackColor = SystemColors.ActiveCaption;
            Pb_GroundTruth.BorderStyle = BorderStyle.FixedSingle;
            Pb_GroundTruth.Location = new Point(833, 15);
            Pb_GroundTruth.Margin = new Padding(4);
            Pb_GroundTruth.Name = "Pb_GroundTruth";
            Pb_GroundTruth.Size = new Size(400, 340);
            Pb_GroundTruth.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_GroundTruth.TabIndex = 5;
            Pb_GroundTruth.TabStop = false;
            // 
            // Lb_InitialImage
            // 
            Lb_InitialImage.AutoSize = true;
            Lb_InitialImage.Location = new Point(155, 359);
            Lb_InitialImage.Name = "Lb_InitialImage";
            Lb_InitialImage.Size = new Size(109, 25);
            Lb_InitialImage.TabIndex = 6;
            Lb_InitialImage.Text = "Initial Image";
            // 
            // Lb_GroundTruth
            // 
            Lb_GroundTruth.AutoSize = true;
            Lb_GroundTruth.Location = new Point(976, 359);
            Lb_GroundTruth.Name = "Lb_GroundTruth";
            Lb_GroundTruth.Size = new Size(116, 25);
            Lb_GroundTruth.TabIndex = 7;
            Lb_GroundTruth.Text = "Ground Truth";
            // 
            // Lb_TreatedImage
            // 
            Lb_TreatedImage.AutoSize = true;
            Lb_TreatedImage.Location = new Point(565, 359);
            Lb_TreatedImage.Name = "Lb_TreatedImage";
            Lb_TreatedImage.Size = new Size(124, 25);
            Lb_TreatedImage.TabIndex = 8;
            Lb_TreatedImage.Text = "Treated Image";
            // 
            // Lb_Options
            // 
            Lb_Options.AutoSize = true;
            Lb_Options.Location = new Point(67, 410);
            Lb_Options.Name = "Lb_Options";
            Lb_Options.Size = new Size(87, 25);
            Lb_Options.TabIndex = 9;
            Lb_Options.Text = "OPTIONS";
            // 
            // Lb_TextScore
            // 
            Lb_TextScore.AutoSize = true;
            Lb_TextScore.Location = new Point(3, 15);
            Lb_TextScore.Name = "Lb_TextScore";
            Lb_TextScore.Size = new Size(70, 25);
            Lb_TextScore.TabIndex = 13;
            Lb_TextScore.Text = "Score : ";
            // 
            // Lb_Score
            // 
            Lb_Score.AutoSize = true;
            Lb_Score.Location = new Point(103, 15);
            Lb_Score.Name = "Lb_Score";
            Lb_Score.Size = new Size(0, 25);
            Lb_Score.TabIndex = 14;
            // 
            // B_Lancer
            // 
            B_Lancer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            B_Lancer.ForeColor = Color.Green;
            B_Lancer.Location = new Point(254, 634);
            B_Lancer.Name = "B_Lancer";
            B_Lancer.Size = new Size(112, 34);
            B_Lancer.TabIndex = 15;
            B_Lancer.Text = "Lancer";
            B_Lancer.UseVisualStyleBackColor = true;
            B_Lancer.Click += B_Lancer_Click;
            // 
            // ofd
            // 
            ofd.FileName = "openFileDialog1";
            // 
            // P_IntervalleImages
            // 
            P_IntervalleImages.Controls.Add(Lb_TextA);
            P_IntervalleImages.Controls.Add(Tb_FinInterval);
            P_IntervalleImages.Controls.Add(Tb_DebutInterval);
            P_IntervalleImages.Controls.Add(Lb_TextDe);
            P_IntervalleImages.Location = new Point(19, 642);
            P_IntervalleImages.Name = "P_IntervalleImages";
            P_IntervalleImages.Size = new Size(206, 64);
            P_IntervalleImages.TabIndex = 17;
            // 
            // Lb_TextA
            // 
            Lb_TextA.AutoSize = true;
            Lb_TextA.Location = new Point(95, 20);
            Lb_TextA.Name = "Lb_TextA";
            Lb_TextA.Size = new Size(30, 25);
            Lb_TextA.TabIndex = 4;
            Lb_TextA.Text = "à :";
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
            // Lb_TextDe
            // 
            Lb_TextDe.AutoSize = true;
            Lb_TextDe.Location = new Point(5, 17);
            Lb_TextDe.Name = "Lb_TextDe";
            Lb_TextDe.Size = new Size(48, 25);
            Lb_TextDe.TabIndex = 0;
            Lb_TextDe.Text = "De : ";
            // 
            // Tb_Timer
            // 
            Tb_Timer.Location = new Point(22, 40);
            Tb_Timer.Maximum = 1500;
            Tb_Timer.Minimum = 100;
            Tb_Timer.Name = "Tb_Timer";
            Tb_Timer.Size = new Size(112, 69);
            Tb_Timer.TabIndex = 18;
            Tb_Timer.TickFrequency = 100;
            Tb_Timer.TickStyle = TickStyle.Both;
            Tb_Timer.Value = 500;
            Tb_Timer.ValueChanged += Tb_Timer_ValueChanged;
            // 
            // Lb_ValeurScore
            // 
            Lb_ValeurScore.AutoSize = true;
            Lb_ValeurScore.Location = new Point(191, 15);
            Lb_ValeurScore.Name = "Lb_ValeurScore";
            Lb_ValeurScore.Size = new Size(27, 25);
            Lb_ValeurScore.TabIndex = 19;
            Lb_ValeurScore.Text = "%";
            // 
            // P_AffichageScore
            // 
            P_AffichageScore.Controls.Add(Lb_TextScore);
            P_AffichageScore.Controls.Add(Lb_ValeurScore);
            P_AffichageScore.Location = new Point(516, 444);
            P_AffichageScore.Name = "P_AffichageScore";
            P_AffichageScore.Size = new Size(264, 56);
            P_AffichageScore.TabIndex = 20;
            // 
            // Lb_ScoreMoyenne
            // 
            Lb_ScoreMoyenne.AutoSize = true;
            Lb_ScoreMoyenne.Location = new Point(3, 15);
            Lb_ScoreMoyenne.Name = "Lb_ScoreMoyenne";
            Lb_ScoreMoyenne.Size = new Size(188, 25);
            Lb_ScoreMoyenne.TabIndex = 13;
            Lb_ScoreMoyenne.Text = "Moyenne des scores : ";
            // 
            // Lb_ValeurScoreMoy
            // 
            Lb_ValeurScoreMoy.AutoSize = true;
            Lb_ValeurScoreMoy.Location = new Point(197, 15);
            Lb_ValeurScoreMoy.Name = "Lb_ValeurScoreMoy";
            Lb_ValeurScoreMoy.Size = new Size(27, 25);
            Lb_ValeurScoreMoy.TabIndex = 19;
            Lb_ValeurScoreMoy.Text = "%";
            // 
            // P_AffichageScoreMoy
            // 
            P_AffichageScoreMoy.Controls.Add(Lb_ScoreMoyenne);
            P_AffichageScoreMoy.Controls.Add(Lb_ValeurScoreMoy);
            P_AffichageScoreMoy.Controls.Add(Lb_Score);
            P_AffichageScoreMoy.Location = new Point(516, 506);
            P_AffichageScoreMoy.Name = "P_AffichageScoreMoy";
            P_AffichageScoreMoy.Size = new Size(264, 56);
            P_AffichageScoreMoy.TabIndex = 21;
            // 
            // B_Quitter
            // 
            B_Quitter.BackColor = SystemColors.ButtonHighlight;
            B_Quitter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            B_Quitter.ForeColor = Color.Firebrick;
            B_Quitter.Location = new Point(1377, 15);
            B_Quitter.Name = "B_Quitter";
            B_Quitter.Size = new Size(112, 34);
            B_Quitter.TabIndex = 22;
            B_Quitter.Text = "Quitter";
            B_Quitter.UseVisualStyleBackColor = false;
            B_Quitter.Click += B_Quitter_Click;
            // 
            // Cb_ExportCSV
            // 
            Cb_ExportCSV.AutoSize = true;
            Cb_ExportCSV.Location = new Point(267, 594);
            Cb_ExportCSV.Name = "Cb_ExportCSV";
            Cb_ExportCSV.Size = new Size(121, 29);
            Cb_ExportCSV.TabIndex = 23;
            Cb_ExportCSV.Text = "ExportCSV";
            Cb_ExportCSV.UseVisualStyleBackColor = true;
            // 
            // Lb_TextTimer
            // 
            Lb_TextTimer.AutoSize = true;
            Lb_TextTimer.Location = new Point(25, 6);
            Lb_TextTimer.Name = "Lb_TextTimer";
            Lb_TextTimer.Size = new Size(109, 25);
            Lb_TextTimer.TabIndex = 20;
            Lb_TextTimer.Text = "Timer (ms) : ";
            // 
            // Lb_ValeurTimer
            // 
            Lb_ValeurTimer.AutoSize = true;
            Lb_ValeurTimer.Location = new Point(65, 109);
            Lb_ValeurTimer.Name = "Lb_ValeurTimer";
            Lb_ValeurTimer.Size = new Size(0, 25);
            Lb_ValeurTimer.TabIndex = 25;
            // 
            // P_NbImages
            // 
            P_NbImages.BackColor = SystemColors.ButtonHighlight;
            P_NbImages.Controls.Add(Cb_ToutesImages);
            P_NbImages.Controls.Add(Cb_Intervalle);
            P_NbImages.Controls.Add(Cb_ImageSeule);
            P_NbImages.Location = new Point(19, 539);
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
            P_TypeImage.Location = new Point(19, 444);
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
            // B_Test
            // 
            B_Test.Location = new Point(778, 642);
            B_Test.Name = "B_Test";
            B_Test.Size = new Size(112, 34);
            B_Test.TabIndex = 28;
            B_Test.Text = "Test";
            B_Test.UseVisualStyleBackColor = true;
            B_Test.Click += BT_Test;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // P_Error
            // 
            P_Error.Controls.Add(Lb_Error);
            P_Error.Location = new Point(19, 715);
            P_Error.Name = "P_Error";
            P_Error.Size = new Size(1500, 47);
            P_Error.TabIndex = 30;
            // 
            // Lb_Error
            // 
            Lb_Error.AutoSize = true;
            Lb_Error.Dock = DockStyle.Fill;
            Lb_Error.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Lb_Error.ForeColor = Color.Firebrick;
            Lb_Error.Location = new Point(0, 0);
            Lb_Error.Name = "Lb_Error";
            Lb_Error.Size = new Size(0, 28);
            Lb_Error.TabIndex = 0;
            // 
            // P_Timer
            // 
            P_Timer.BackColor = SystemColors.GradientInactiveCaption;
            P_Timer.Controls.Add(Lb_TextTimer);
            P_Timer.Controls.Add(Tb_Timer);
            P_Timer.Controls.Add(Lb_ValeurTimer);
            P_Timer.Location = new Point(254, 444);
            P_Timer.Name = "P_Timer";
            P_Timer.Size = new Size(146, 134);
            P_Timer.TabIndex = 31;
            // 
            // L_TextHistorique
            // 
            L_TextHistorique.AutoSize = true;
            L_TextHistorique.Location = new Point(1352, 359);
            L_TextHistorique.Name = "L_TextHistorique";
            L_TextHistorique.Size = new Size(94, 25);
            L_TextHistorique.TabIndex = 32;
            L_TextHistorique.Text = "Historique";
            // 
            // B_Areter
            // 
            B_Areter.Enabled = false;
            B_Areter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            B_Areter.ForeColor = Color.Red;
            B_Areter.Location = new Point(254, 674);
            B_Areter.Name = "B_Areter";
            B_Areter.Size = new Size(112, 34);
            B_Areter.TabIndex = 33;
            B_Areter.Text = "Arrêter";
            B_Areter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1532, 772);
            ControlBox = false;
            Controls.Add(B_Areter);
            Controls.Add(L_TextHistorique);
            Controls.Add(P_Timer);
            Controls.Add(P_Error);
            Controls.Add(B_Test);
            Controls.Add(P_TypeImage);
            Controls.Add(P_NbImages);
            Controls.Add(Cb_ExportCSV);
            Controls.Add(B_Quitter);
            Controls.Add(P_AffichageScoreMoy);
            Controls.Add(P_AffichageScore);
            Controls.Add(P_IntervalleImages);
            Controls.Add(B_Lancer);
            Controls.Add(Lb_Options);
            Controls.Add(Lb_TreatedImage);
            Controls.Add(Lb_GroundTruth);
            Controls.Add(Lb_InitialImage);
            Controls.Add(Pb_GroundTruth);
            Controls.Add(Pb_TreatedImage3);
            Controls.Add(Pb_TreatedImage2);
            Controls.Add(Pb_TreatedImage1);
            Controls.Add(Pb_TreatedImage);
            Controls.Add(Pb_InitialImage);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Projet C++";
            ((System.ComponentModel.ISupportInitialize)Pb_InitialImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_TreatedImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_TreatedImage1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_TreatedImage2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_TreatedImage3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_GroundTruth).EndInit();
            P_IntervalleImages.ResumeLayout(false);
            P_IntervalleImages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Tb_Timer).EndInit();
            P_AffichageScore.ResumeLayout(false);
            P_AffichageScore.PerformLayout();
            P_AffichageScoreMoy.ResumeLayout(false);
            P_AffichageScoreMoy.PerformLayout();
            P_NbImages.ResumeLayout(false);
            P_NbImages.PerformLayout();
            P_TypeImage.ResumeLayout(false);
            P_TypeImage.PerformLayout();
            P_Error.ResumeLayout(false);
            P_Error.PerformLayout();
            P_Timer.ResumeLayout(false);
            P_Timer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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

    }
}