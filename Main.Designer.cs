namespace GameTheories
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            okmainBT = new Button();
            pictureBox1 = new PictureBox();
            lbl1 = new Label();
            tmr1 = new System.Windows.Forms.Timer(components);
            NasilOynanirBT = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // okmainBT
            // 
            resources.ApplyResources(okmainBT, "okmainBT");
            okmainBT.BackColor = SystemColors.GrayText;
            okmainBT.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            okmainBT.FlatAppearance.BorderSize = 0;
            okmainBT.ForeColor = SystemColors.ButtonFace;
            okmainBT.Name = "okmainBT";
            okmainBT.UseVisualStyleBackColor = false;
            okmainBT.Click += okmainBT_Click;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // lbl1
            // 
            resources.ApplyResources(lbl1, "lbl1");
            lbl1.ForeColor = SystemColors.InactiveCaption;
            lbl1.Name = "lbl1";
            // 
            // tmr1
            // 
            tmr1.Interval = 20;
            tmr1.Tick += tmr1_Tick;
            // 
            // NasilOynanirBT
            // 
            resources.ApplyResources(NasilOynanirBT, "NasilOynanirBT");
            NasilOynanirBT.BackColor = SystemColors.GrayText;
            NasilOynanirBT.ForeColor = SystemColors.ControlLightLight;
            NasilOynanirBT.Name = "NasilOynanirBT";
            NasilOynanirBT.UseVisualStyleBackColor = false;
            NasilOynanirBT.Click += NasilOynanirBT_Click_1;
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(NasilOynanirBT);
            Controls.Add(okmainBT);
            Controls.Add(lbl1);
            Controls.Add(pictureBox1);
            Name = "Main";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void NasilOynanirBT_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button okmainBT;
        private PictureBox pictureBox1;
        private Label lbl1;
        private System.Windows.Forms.Timer tmr1;
        private Button NasilOynanirBT;
    }
}
