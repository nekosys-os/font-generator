
namespace font_generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.iFontName = new System.Windows.Forms.TextBox();
            this.btnSelectFont = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.GenerationProgress = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefreshPreview = new System.Windows.Forms.Button();
            this.iPreviewChar = new System.Windows.Forms.TextBox();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.iFntFile = new System.Windows.Forms.RadioButton();
            this.iCArray = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.iHeight = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.iWidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.iYOffset = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.iXOffset = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iYOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iXOffset)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Font:";
            // 
            // iFontName
            // 
            this.iFontName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iFontName.Location = new System.Drawing.Point(87, 10);
            this.iFontName.Name = "iFontName";
            this.iFontName.ReadOnly = true;
            this.iFontName.Size = new System.Drawing.Size(192, 23);
            this.iFontName.TabIndex = 1;
            // 
            // btnSelectFont
            // 
            this.btnSelectFont.Location = new System.Drawing.Point(285, 10);
            this.btnSelectFont.Name = "btnSelectFont";
            this.btnSelectFont.Size = new System.Drawing.Size(48, 24);
            this.btnSelectFont.TabIndex = 2;
            this.btnSelectFont.Text = "...";
            this.btnSelectFont.UseVisualStyleBackColor = true;
            this.btnSelectFont.Click += new System.EventHandler(this.btnSelectFont_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 357);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(325, 23);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // GenerationProgress
            // 
            this.GenerationProgress.Location = new System.Drawing.Point(12, 386);
            this.GenerationProgress.Name = "GenerationProgress";
            this.GenerationProgress.Size = new System.Drawing.Size(325, 19);
            this.GenerationProgress.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefreshPreview);
            this.groupBox1.Controls.Add(this.iPreviewChar);
            this.groupBox1.Controls.Add(this.pbPreview);
            this.groupBox1.Location = new System.Drawing.Point(13, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 156);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview";
            // 
            // btnRefreshPreview
            // 
            this.btnRefreshPreview.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshPreview.Image")));
            this.btnRefreshPreview.Location = new System.Drawing.Point(247, 64);
            this.btnRefreshPreview.Name = "btnRefreshPreview";
            this.btnRefreshPreview.Size = new System.Drawing.Size(39, 30);
            this.btnRefreshPreview.TabIndex = 7;
            this.btnRefreshPreview.UseVisualStyleBackColor = true;
            this.btnRefreshPreview.Click += new System.EventHandler(this.btnRefreshPreview_Click);
            // 
            // iPreviewChar
            // 
            this.iPreviewChar.Location = new System.Drawing.Point(112, 121);
            this.iPreviewChar.MaxLength = 1;
            this.iPreviewChar.Name = "iPreviewChar";
            this.iPreviewChar.Size = new System.Drawing.Size(97, 23);
            this.iPreviewChar.TabIndex = 6;
            this.iPreviewChar.Text = "x";
            this.iPreviewChar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbPreview
            // 
            this.pbPreview.BackColor = System.Drawing.Color.Gray;
            this.pbPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPreview.Location = new System.Drawing.Point(112, 26);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(97, 89);
            this.pbPreview.TabIndex = 0;
            this.pbPreview.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.iFntFile);
            this.groupBox2.Controls.Add(this.iCArray);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.iHeight);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.iWidth);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.iYOffset);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.iXOffset);
            this.groupBox2.Location = new System.Drawing.Point(13, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 113);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Output format:";
            // 
            // iFntFile
            // 
            this.iFntFile.AutoSize = true;
            this.iFntFile.Location = new System.Drawing.Point(179, 86);
            this.iFntFile.Name = "iFntFile";
            this.iFntFile.Size = new System.Drawing.Size(64, 19);
            this.iFntFile.TabIndex = 9;
            this.iFntFile.Text = ".fnt File";
            this.iFntFile.UseVisualStyleBackColor = true;
            // 
            // iCArray
            // 
            this.iCArray.AutoSize = true;
            this.iCArray.Checked = true;
            this.iCArray.Location = new System.Drawing.Point(109, 86);
            this.iCArray.Name = "iCArray";
            this.iCArray.Size = new System.Drawing.Size(64, 19);
            this.iCArray.TabIndex = 8;
            this.iCArray.TabStop = true;
            this.iCArray.Text = "C Array";
            this.iCArray.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Height:";
            // 
            // iHeight
            // 
            this.iHeight.Location = new System.Drawing.Point(247, 49);
            this.iHeight.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.iHeight.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.iHeight.Name = "iHeight";
            this.iHeight.Size = new System.Drawing.Size(55, 23);
            this.iHeight.TabIndex = 6;
            this.iHeight.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Width:";
            // 
            // iWidth
            // 
            this.iWidth.Location = new System.Drawing.Point(247, 20);
            this.iWidth.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.iWidth.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.iWidth.Name = "iWidth";
            this.iWidth.Size = new System.Drawing.Size(55, 23);
            this.iWidth.TabIndex = 4;
            this.iWidth.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Y Offset:";
            // 
            // iYOffset
            // 
            this.iYOffset.Location = new System.Drawing.Point(74, 49);
            this.iYOffset.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.iYOffset.Name = "iYOffset";
            this.iYOffset.Size = new System.Drawing.Size(55, 23);
            this.iYOffset.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "X Offset:";
            // 
            // iXOffset
            // 
            this.iXOffset.Location = new System.Drawing.Point(74, 20);
            this.iXOffset.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.iXOffset.Name = "iXOffset";
            this.iXOffset.Size = new System.Drawing.Size(55, 23);
            this.iXOffset.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 415);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GenerationProgress);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnSelectFont);
            this.Controls.Add(this.iFontName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "nekosys Font Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iYOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iXOffset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox iFontName;
        private System.Windows.Forms.Button btnSelectFont;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ProgressBar GenerationProgress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.TextBox iPreviewChar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown iHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown iWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown iYOffset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown iXOffset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton iFntFile;
        private System.Windows.Forms.RadioButton iCArray;
        private System.Windows.Forms.Button btnRefreshPreview;
    }
}

