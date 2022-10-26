
namespace LAB03_PICBENDER_WonhyukCho
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
            this.UI_pBox = new System.Windows.Forms.PictureBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.UI_Btn_Load = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UI_rBtn_Noise = new System.Windows.Forms.RadioButton();
            this.UI_rBtn_Tint = new System.Windows.Forms.RadioButton();
            this.UI_rBtn_BW = new System.Windows.Forms.RadioButton();
            this.UI_rBtn_Contrast = new System.Windows.Forms.RadioButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.UI_Btn_Transform = new System.Windows.Forms.Button();
            this.UI_lbl_Red = new System.Windows.Forms.Label();
            this.UI_lbl_Result = new System.Windows.Forms.Label();
            this.UI_lbl_Green = new System.Windows.Forms.Label();
            this.UI_OFD = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.UI_pBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_pBox
            // 
            this.UI_pBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_pBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UI_pBox.Location = new System.Drawing.Point(68, 24);
            this.UI_pBox.Name = "UI_pBox";
            this.UI_pBox.Size = new System.Drawing.Size(1327, 427);
            this.UI_pBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UI_pBox.TabIndex = 1;
            this.UI_pBox.TabStop = false;
            // 
            // progressBar2
            // 
            this.progressBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar2.Location = new System.Drawing.Point(68, 473);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(1327, 30);
            this.progressBar2.TabIndex = 3;
            // 
            // UI_Btn_Load
            // 
            this.UI_Btn_Load.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UI_Btn_Load.Location = new System.Drawing.Point(68, 535);
            this.UI_Btn_Load.Name = "UI_Btn_Load";
            this.UI_Btn_Load.Size = new System.Drawing.Size(185, 60);
            this.UI_Btn_Load.TabIndex = 4;
            this.UI_Btn_Load.Text = "Load Picture";
            this.UI_Btn_Load.UseVisualStyleBackColor = true;
            this.UI_Btn_Load.Click += new System.EventHandler(this.UI_Btn_Load_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.UI_rBtn_Noise);
            this.groupBox1.Controls.Add(this.UI_rBtn_Tint);
            this.groupBox1.Controls.Add(this.UI_rBtn_BW);
            this.groupBox1.Controls.Add(this.UI_rBtn_Contrast);
            this.groupBox1.Location = new System.Drawing.Point(313, 535);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 140);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modification Type";
            // 
            // UI_rBtn_Noise
            // 
            this.UI_rBtn_Noise.AutoSize = true;
            this.UI_rBtn_Noise.Location = new System.Drawing.Point(160, 85);
            this.UI_rBtn_Noise.Name = "UI_rBtn_Noise";
            this.UI_rBtn_Noise.Size = new System.Drawing.Size(74, 24);
            this.UI_rBtn_Noise.TabIndex = 3;
            this.UI_rBtn_Noise.Text = "Noise";
            this.UI_rBtn_Noise.UseVisualStyleBackColor = true;
            this.UI_rBtn_Noise.CheckedChanged += new System.EventHandler(this.UI_rBtn_Contrast_CheckedChanged);
            // 
            // UI_rBtn_Tint
            // 
            this.UI_rBtn_Tint.AutoSize = true;
            this.UI_rBtn_Tint.Location = new System.Drawing.Point(160, 36);
            this.UI_rBtn_Tint.Name = "UI_rBtn_Tint";
            this.UI_rBtn_Tint.Size = new System.Drawing.Size(60, 24);
            this.UI_rBtn_Tint.TabIndex = 2;
            this.UI_rBtn_Tint.Text = "Tint";
            this.UI_rBtn_Tint.UseVisualStyleBackColor = true;
            this.UI_rBtn_Tint.CheckedChanged += new System.EventHandler(this.UI_rBtn_Contrast_CheckedChanged);
            // 
            // UI_rBtn_BW
            // 
            this.UI_rBtn_BW.AutoSize = true;
            this.UI_rBtn_BW.Location = new System.Drawing.Point(18, 85);
            this.UI_rBtn_BW.Name = "UI_rBtn_BW";
            this.UI_rBtn_BW.Size = new System.Drawing.Size(133, 24);
            this.UI_rBtn_BW.TabIndex = 1;
            this.UI_rBtn_BW.Text = "Black && White";
            this.UI_rBtn_BW.UseVisualStyleBackColor = true;
            this.UI_rBtn_BW.CheckedChanged += new System.EventHandler(this.UI_rBtn_Contrast_CheckedChanged);
            // 
            // UI_rBtn_Contrast
            // 
            this.UI_rBtn_Contrast.AutoSize = true;
            this.UI_rBtn_Contrast.Checked = true;
            this.UI_rBtn_Contrast.Location = new System.Drawing.Point(18, 36);
            this.UI_rBtn_Contrast.Name = "UI_rBtn_Contrast";
            this.UI_rBtn_Contrast.Size = new System.Drawing.Size(95, 24);
            this.UI_rBtn_Contrast.TabIndex = 0;
            this.UI_rBtn_Contrast.TabStop = true;
            this.UI_rBtn_Contrast.Text = "Contrast";
            this.UI_rBtn_Contrast.UseVisualStyleBackColor = true;
            this.UI_rBtn_Contrast.CheckedChanged += new System.EventHandler(this.UI_rBtn_Contrast_CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackBar1.Location = new System.Drawing.Point(688, 535);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(444, 69);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // UI_Btn_Transform
            // 
            this.UI_Btn_Transform.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UI_Btn_Transform.Enabled = false;
            this.UI_Btn_Transform.Location = new System.Drawing.Point(1210, 544);
            this.UI_Btn_Transform.Name = "UI_Btn_Transform";
            this.UI_Btn_Transform.Size = new System.Drawing.Size(185, 60);
            this.UI_Btn_Transform.TabIndex = 7;
            this.UI_Btn_Transform.Text = "Transform";
            this.UI_Btn_Transform.UseVisualStyleBackColor = true;
            this.UI_Btn_Transform.Click += new System.EventHandler(this.UI_Btn_Transform_Click);
            // 
            // UI_lbl_Red
            // 
            this.UI_lbl_Red.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UI_lbl_Red.AutoSize = true;
            this.UI_lbl_Red.Location = new System.Drawing.Point(684, 607);
            this.UI_lbl_Red.Name = "UI_lbl_Red";
            this.UI_lbl_Red.Size = new System.Drawing.Size(43, 20);
            this.UI_lbl_Red.TabIndex = 8;
            this.UI_lbl_Red.Text = "Less";
            // 
            // UI_lbl_Result
            // 
            this.UI_lbl_Result.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UI_lbl_Result.AutoSize = true;
            this.UI_lbl_Result.ForeColor = System.Drawing.Color.Blue;
            this.UI_lbl_Result.Location = new System.Drawing.Point(889, 607);
            this.UI_lbl_Result.Name = "UI_lbl_Result";
            this.UI_lbl_Result.Size = new System.Drawing.Size(27, 20);
            this.UI_lbl_Result.TabIndex = 9;
            this.UI_lbl_Result.Text = "50";
            // 
            // UI_lbl_Green
            // 
            this.UI_lbl_Green.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UI_lbl_Green.AutoSize = true;
            this.UI_lbl_Green.Location = new System.Drawing.Point(1081, 607);
            this.UI_lbl_Green.Name = "UI_lbl_Green";
            this.UI_lbl_Green.Size = new System.Drawing.Size(45, 20);
            this.UI_lbl_Green.TabIndex = 10;
            this.UI_lbl_Green.Text = "More";
            // 
            // UI_OFD
            // 
            this.UI_OFD.FileName = "openFileDialog1";
            this.UI_OFD.Filter = "BMP|*.bmp| JPEG |*.jpg| PNG |*.png| All files|*.*\"";
            this.UI_OFD.Title = "Open an image";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 753);
            this.Controls.Add(this.UI_lbl_Green);
            this.Controls.Add(this.UI_lbl_Result);
            this.Controls.Add(this.UI_lbl_Red);
            this.Controls.Add(this.UI_Btn_Transform);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UI_Btn_Load);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.UI_pBox);
            this.MinimumSize = new System.Drawing.Size(1519, 809);
            this.Name = "Form1";
            this.Text = "PicBender";
            ((System.ComponentModel.ISupportInitialize)(this.UI_pBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox UI_pBox;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button UI_Btn_Load;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton UI_rBtn_Noise;
        private System.Windows.Forms.RadioButton UI_rBtn_Tint;
        private System.Windows.Forms.RadioButton UI_rBtn_BW;
        private System.Windows.Forms.RadioButton UI_rBtn_Contrast;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button UI_Btn_Transform;
        private System.Windows.Forms.Label UI_lbl_Red;
        private System.Windows.Forms.Label UI_lbl_Result;
        private System.Windows.Forms.Label UI_lbl_Green;
        private System.Windows.Forms.OpenFileDialog UI_OFD;
    }
}

