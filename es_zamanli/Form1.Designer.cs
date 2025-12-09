namespace GameTheories.es_zamanli
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            hero1LBL = new Label();
            hero2LBL = new Label();
            hero1P = new PictureBox();
            hero2P = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            button5 = new Button();
            macizle = new RadioButton();
            sonucGit = new RadioButton();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)hero1P).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hero2P).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(591, 27);
            label1.Name = "label1";
            label1.Size = new Size(68, 47);
            label1.TabIndex = 2;
            label1.Text = "VS";
            // 
            // hero1LBL
            // 
            hero1LBL.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            hero1LBL.AutoSize = true;
            hero1LBL.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hero1LBL.ForeColor = SystemColors.ControlLightLight;
            hero1LBL.Location = new Point(162, 42);
            hero1LBL.Name = "hero1LBL";
            hero1LBL.Size = new Size(46, 27);
            hero1LBL.TabIndex = 3;
            hero1LBL.Text = "Siz";
            // 
            // hero2LBL
            // 
            hero2LBL.AutoSize = true;
            hero2LBL.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hero2LBL.ForeColor = SystemColors.ControlLightLight;
            hero2LBL.Location = new Point(956, 42);
            hero2LBL.Name = "hero2LBL";
            hero2LBL.Size = new Size(46, 27);
            hero2LBL.TabIndex = 4;
            hero2LBL.Text = "Siz";
            // 
            // hero1P
            // 
            hero1P.Dock = DockStyle.Left;
            hero1P.Location = new Point(0, 0);
            hero1P.Name = "hero1P";
            hero1P.Size = new Size(485, 703);
            hero1P.SizeMode = PictureBoxSizeMode.Zoom;
            hero1P.TabIndex = 5;
            hero1P.TabStop = false;
            // 
            // hero2P
            // 
            hero2P.Location = new Point(765, 0);
            hero2P.Name = "hero2P";
            hero2P.Size = new Size(467, 703);
            hero2P.SizeMode = PictureBoxSizeMode.Zoom;
            hero2P.TabIndex = 6;
            hero2P.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GrayText;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(293, 37);
            button1.Name = "button1";
            button1.Size = new Size(52, 41);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GrayText;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(104, 37);
            button2.Name = "button2";
            button2.Size = new Size(52, 41);
            button2.TabIndex = 8;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GrayText;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(898, 37);
            button3.Name = "button3";
            button3.Size = new Size(52, 41);
            button3.TabIndex = 9;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.GrayText;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(1087, 37);
            button4.Name = "button4";
            button4.Size = new Size(52, 41);
            button4.TabIndex = 10;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(546, 119);
            label2.Name = "label2";
            label2.Size = new Size(168, 18);
            label2.TabIndex = 11;
            label2.Text = "Oyun sayısını giriniz";
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = SystemColors.GrayText;
            numericUpDown1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown1.ForeColor = SystemColors.ControlLightLight;
            numericUpDown1.Location = new Point(555, 140);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 26);
            numericUpDown1.TabIndex = 12;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightCoral;
            label3.Location = new Point(524, 90);
            label3.Name = "label3";
            label3.Size = new Size(221, 18);
            label3.TabIndex = 13;
            label3.Text = "iki hero da siz olamazsiniz";
            label3.Visible = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.GrayText;
            button5.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(491, 608);
            button5.Name = "button5";
            button5.Size = new Size(268, 31);
            button5.TabIndex = 14;
            button5.Text = "Basla";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // macizle
            // 
            macizle.AutoSize = true;
            macizle.BackColor = SystemColors.GrayText;
            macizle.Enabled = false;
            macizle.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            macizle.ForeColor = SystemColors.ControlLightLight;
            macizle.Location = new Point(512, 345);
            macizle.Name = "macizle";
            macizle.Size = new Size(99, 22);
            macizle.TabIndex = 15;
            macizle.TabStop = true;
            macizle.Text = "Maçı izle";
            macizle.UseVisualStyleBackColor = false;
            // 
            // sonucGit
            // 
            sonucGit.AutoSize = true;
            sonucGit.Enabled = false;
            sonucGit.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sonucGit.ForeColor = SystemColors.ControlLightLight;
            sonucGit.Location = new Point(512, 404);
            sonucGit.Name = "sonucGit";
            sonucGit.Size = new Size(172, 22);
            sonucGit.TabIndex = 16;
            sonucGit.TabStop = true;
            sonucGit.Text = "Direkt sonuca git";
            sonucGit.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(139, 266);
            label4.Name = "label4";
            label4.Size = new Size(988, 20);
            label4.TabIndex = 17;
            label4.Text = "Yapmamız gereken şuan  oyun sayısı ekledim yeni onu ayarlicaz sonra maç izleme ve direkt sonuca gitme butonlarına göre birşeyler yapcaz bu kadar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(1232, 703);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(sonucGit);
            Controls.Add(macizle);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(hero2LBL);
            Controls.Add(hero1LBL);
            Controls.Add(hero2P);
            Controls.Add(hero1P);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "1vs1 Game Theory";
            FormClosed += Form1_FormClosed;
            ((System.ComponentModel.ISupportInitialize)hero1P).EndInit();
            ((System.ComponentModel.ISupportInitialize)hero2P).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label hero2LBL;
        private PictureBox hero1P;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Button button5;
        private RadioButton macizle;
        private RadioButton sonucGit;
        private Label label4;
        public Label hero1LBL;
        public PictureBox hero2P;
    }
}