namespace GameTheories
{
    partial class GamePlay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePlay));
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            pictureBox1 = new PictureBox();
            kopyaciLBL = new Label();
            poncikLBL = new Label();
            sinsiLBL = new Label();
            hain_hafizaLBL = new Label();
            sansliLBL = new Label();
            affeden_aynaLBL = new Label();
            somurucuLBL = new Label();
            grupcuLBL = new Label();
            intikamciLBL = new Label();
            firsatciLBL = new Label();
            comboBox3 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = SystemColors.GrayText;
            button1.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(40, 622);
            button1.Name = "button1";
            button1.Size = new Size(220, 29);
            button1.TabIndex = 0;
            button1.Text = "Bilgilendirme";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = SystemColors.GrayText;
            button2.FlatStyle = FlatStyle.System;
            button2.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(1010, 622);
            button2.Name = "button2";
            button2.Size = new Size(200, 30);
            button2.TabIndex = 1;
            button2.Text = "OYUNA BASLA";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Eş zamanlı oyun " });
            comboBox1.Location = new Point(405, 549);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "Oyun çeşidini seçiniz";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1 vs 1 ", "Evrimsel " });
            comboBox2.Location = new Point(692, 549);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 3;
            comboBox2.Text = "Oyun türünü seçin";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(123, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(958, 321);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // kopyaciLBL
            // 
            kopyaciLBL.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            kopyaciLBL.BackColor = Color.CornflowerBlue;
            kopyaciLBL.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            kopyaciLBL.ForeColor = SystemColors.ControlLightLight;
            kopyaciLBL.Location = new Point(176, 327);
            kopyaciLBL.Name = "kopyaciLBL";
            kopyaciLBL.Size = new Size(66, 20);
            kopyaciLBL.TabIndex = 5;
            kopyaciLBL.Text = "Kopyacı ";
            // 
            // poncikLBL
            // 
            poncikLBL.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            poncikLBL.AutoSize = true;
            poncikLBL.BackColor = Color.Tomato;
            poncikLBL.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            poncikLBL.ForeColor = SystemColors.ControlLightLight;
            poncikLBL.Location = new Point(268, 327);
            poncikLBL.Name = "poncikLBL";
            poncikLBL.Size = new Size(55, 20);
            poncikLBL.TabIndex = 6;
            poncikLBL.Text = "Ponçik";
            // 
            // sinsiLBL
            // 
            sinsiLBL.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sinsiLBL.AutoSize = true;
            sinsiLBL.BackColor = Color.ForestGreen;
            sinsiLBL.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            sinsiLBL.ForeColor = SystemColors.ButtonHighlight;
            sinsiLBL.Location = new Point(347, 327);
            sinsiLBL.Name = "sinsiLBL";
            sinsiLBL.Size = new Size(41, 20);
            sinsiLBL.TabIndex = 7;
            sinsiLBL.Text = "Sinsi";
            // 
            // hain_hafizaLBL
            // 
            hain_hafizaLBL.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            hain_hafizaLBL.AutoSize = true;
            hain_hafizaLBL.BackColor = Color.DarkRed;
            hain_hafizaLBL.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            hain_hafizaLBL.ForeColor = SystemColors.ButtonHighlight;
            hain_hafizaLBL.Location = new Point(401, 327);
            hain_hafizaLBL.Name = "hain_hafizaLBL";
            hain_hafizaLBL.Size = new Size(87, 20);
            hain_hafizaLBL.TabIndex = 8;
            hain_hafizaLBL.Text = "Hain Hafiza";
            // 
            // sansliLBL
            // 
            sansliLBL.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sansliLBL.AutoSize = true;
            sansliLBL.BackColor = Color.Teal;
            sansliLBL.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            sansliLBL.ForeColor = SystemColors.ControlLightLight;
            sansliLBL.Location = new Point(503, 327);
            sansliLBL.Name = "sansliLBL";
            sansliLBL.Size = new Size(48, 20);
            sansliLBL.TabIndex = 9;
            sansliLBL.Text = "Şanslı";
            // 
            // affeden_aynaLBL
            // 
            affeden_aynaLBL.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            affeden_aynaLBL.AutoSize = true;
            affeden_aynaLBL.BackColor = Color.Olive;
            affeden_aynaLBL.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            affeden_aynaLBL.ForeColor = SystemColors.ControlLightLight;
            affeden_aynaLBL.Location = new Point(565, 327);
            affeden_aynaLBL.Name = "affeden_aynaLBL";
            affeden_aynaLBL.Size = new Size(100, 20);
            affeden_aynaLBL.TabIndex = 10;
            affeden_aynaLBL.Text = "Affeden Ayna";
            // 
            // somurucuLBL
            // 
            somurucuLBL.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            somurucuLBL.AutoSize = true;
            somurucuLBL.BackColor = Color.LightSeaGreen;
            somurucuLBL.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            somurucuLBL.ForeColor = SystemColors.Info;
            somurucuLBL.Location = new Point(670, 327);
            somurucuLBL.Name = "somurucuLBL";
            somurucuLBL.Size = new Size(80, 20);
            somurucuLBL.TabIndex = 11;
            somurucuLBL.Text = "Sömürücü";
            // 
            // grupcuLBL
            // 
            grupcuLBL.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grupcuLBL.AutoSize = true;
            grupcuLBL.BackColor = Color.MidnightBlue;
            grupcuLBL.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            grupcuLBL.ForeColor = SystemColors.ControlLightLight;
            grupcuLBL.Location = new Point(765, 327);
            grupcuLBL.Name = "grupcuLBL";
            grupcuLBL.Size = new Size(60, 20);
            grupcuLBL.TabIndex = 12;
            grupcuLBL.Text = "Grupçu";
            // 
            // intikamciLBL
            // 
            intikamciLBL.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            intikamciLBL.AutoSize = true;
            intikamciLBL.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            intikamciLBL.ForeColor = SystemColors.ControlLightLight;
            intikamciLBL.Location = new Point(839, 327);
            intikamciLBL.Name = "intikamciLBL";
            intikamciLBL.Size = new Size(73, 20);
            intikamciLBL.TabIndex = 13;
            intikamciLBL.Text = "İntikamcı";
            // 
            // firsatciLBL
            // 
            firsatciLBL.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            firsatciLBL.AutoSize = true;
            firsatciLBL.BackColor = Color.DarkOrchid;
            firsatciLBL.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            firsatciLBL.ForeColor = SystemColors.ControlLightLight;
            firsatciLBL.Location = new Point(938, 327);
            firsatciLBL.Name = "firsatciLBL";
            firsatciLBL.Size = new Size(56, 20);
            firsatciLBL.TabIndex = 14;
            firsatciLBL.Text = "Fırsatçı";
            // 
            // comboBox3
            // 
            comboBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Kopyacı ", "Ponçik", "Sinsi ", "Hain Hafıza", "Şanslı ", "Affeden Ayna", "Sömürücü ", "Grupçu", "İntikamcı", "Fırsatçı", "Herolar" });
            comboBox3.Location = new Point(181, 31);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(855, 28);
            comboBox3.TabIndex = 15;
            comboBox3.Text = "Bilgi almak istediğiniz Kahramanı Seçin";
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // GamePlay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1232, 703);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(comboBox3);
            Controls.Add(firsatciLBL);
            Controls.Add(intikamciLBL);
            Controls.Add(grupcuLBL);
            Controls.Add(somurucuLBL);
            Controls.Add(affeden_aynaLBL);
            Controls.Add(sansliLBL);
            Controls.Add(hain_hafizaLBL);
            Controls.Add(sinsiLBL);
            Controls.Add(poncikLBL);
            Controls.Add(kopyaciLBL);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GamePlay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Oynanış ";
            FormClosed += Form2_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private PictureBox pictureBox1;
        private Label kopyaciLBL;
        private Label poncikLBL;
        private Label sinsiLBL;
        private Label hain_hafizaLBL;
        private Label sansliLBL;
        private Label affeden_aynaLBL;
        private Label somurucuLBL;
        private Label grupcuLBL;
        private Label intikamciLBL;
        private Label firsatciLBL;
        private ComboBox comboBox3;
    }
}