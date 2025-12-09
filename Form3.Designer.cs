namespace GameTheories
{
    partial class NasilOynanir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NasilOynanir));
            vsRDBTN = new RadioButton();
            groupRDBTN = new RadioButton();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // vsRDBTN
            // 
            vsRDBTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            vsRDBTN.AutoSize = true;
            vsRDBTN.BackColor = SystemColors.GrayText;
            vsRDBTN.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vsRDBTN.ForeColor = SystemColors.ControlLightLight;
            vsRDBTN.Location = new Point(952, 607);
            vsRDBTN.Name = "vsRDBTN";
            vsRDBTN.Size = new Size(76, 22);
            vsRDBTN.TabIndex = 0;
            vsRDBTN.TabStop = true;
            vsRDBTN.Text = "1 VS 1 ";
            vsRDBTN.UseVisualStyleBackColor = false;
            vsRDBTN.CheckedChanged += vsRDBTN_CheckedChanged;
            // 
            // groupRDBTN
            // 
            groupRDBTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupRDBTN.AutoSize = true;
            groupRDBTN.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupRDBTN.ForeColor = SystemColors.ControlLightLight;
            groupRDBTN.Location = new Point(222, 607);
            groupRDBTN.Name = "groupRDBTN";
            groupRDBTN.Size = new Size(72, 22);
            groupRDBTN.TabIndex = 1;
            groupRDBTN.TabStop = true;
            groupRDBTN.Text = "Grup ";
            groupRDBTN.UseVisualStyleBackColor = true;
            groupRDBTN.CheckedChanged += groupRDBTN_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(369, 703);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.GrayText;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(369, 0);
            label1.Name = "label1";
            label1.Size = new Size(863, 703);
            label1.TabIndex = 3;
            label1.Text = resources.GetString("label1.Text");
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GrayText;
            button1.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(46, 600);
            button1.Name = "button1";
            button1.Size = new Size(128, 29);
            button1.TabIndex = 4;
            button1.Text = "Oyuna Geç";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // NasilOynanir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(1232, 703);
            Controls.Add(button1);
            Controls.Add(groupRDBTN);
            Controls.Add(vsRDBTN);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NasilOynanir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nasıl oynanır ? ";
            FormClosed += Form3_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton vsRDBTN;
        private RadioButton groupRDBTN;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
    }
}