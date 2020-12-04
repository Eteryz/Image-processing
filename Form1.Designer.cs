namespace _2c_Lab4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonBinaryImage = new System.Windows.Forms.Button();
            this.buttonHough = new System.Windows.Forms.Button();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.buttonReflection = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonContrast = new System.Windows.Forms.Button();
            this.buttonBrightness = new System.Windows.Forms.Button();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.buttonDefiningBoundaries = new System.Windows.Forms.Button();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonContrastSaw = new System.Windows.Forms.Button();
            this.buttonGray = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.buttonNoise = new System.Windows.Forms.Button();
            this.buttonOpenImage = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Teal;
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.buttonBinaryImage);
            this.splitContainer1.Panel1.Controls.Add(this.buttonHough);
            this.splitContainer1.Panel1.Controls.Add(this.trackBar4);
            this.splitContainer1.Panel1.Controls.Add(this.buttonReflection);
            this.splitContainer1.Panel1.Controls.Add(this.buttonClear);
            this.splitContainer1.Panel1.Controls.Add(this.buttonContrast);
            this.splitContainer1.Panel1.Controls.Add(this.buttonBrightness);
            this.splitContainer1.Panel1.Controls.Add(this.trackBar3);
            this.splitContainer1.Panel1.Controls.Add(this.buttonDefiningBoundaries);
            this.splitContainer1.Panel1.Controls.Add(this.trackBar2);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonContrastSaw);
            this.splitContainer1.Panel1.Controls.Add(this.buttonGray);
            this.splitContainer1.Panel1.Controls.Add(this.trackBar1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonNoise);
            this.splitContainer1.Panel1.Controls.Add(this.buttonOpenImage);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(843, 542);
            this.splitContainer1.SplitterDistance = 130;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonBinaryImage
            // 
            this.buttonBinaryImage.Location = new System.Drawing.Point(21, 477);
            this.buttonBinaryImage.Name = "buttonBinaryImage";
            this.buttonBinaryImage.Size = new System.Drawing.Size(90, 23);
            this.buttonBinaryImage.TabIndex = 17;
            this.buttonBinaryImage.Text = "binary image";
            this.buttonBinaryImage.UseVisualStyleBackColor = true;
            this.buttonBinaryImage.Click += new System.EventHandler(this.buttonBinaryImage_Click);
            // 
            // buttonHough
            // 
            this.buttonHough.Location = new System.Drawing.Point(21, 449);
            this.buttonHough.Name = "buttonHough";
            this.buttonHough.Size = new System.Drawing.Size(90, 23);
            this.buttonHough.TabIndex = 16;
            this.buttonHough.Text = "hough";
            this.buttonHough.UseVisualStyleBackColor = true;
            this.buttonHough.Click += new System.EventHandler(this.buttonHough_Click);
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(11, 416);
            this.trackBar4.Maximum = 500;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(104, 45);
            this.trackBar4.TabIndex = 15;
            this.trackBar4.TickFrequency = 50;
            // 
            // buttonReflection
            // 
            this.buttonReflection.Location = new System.Drawing.Point(21, 369);
            this.buttonReflection.Name = "buttonReflection";
            this.buttonReflection.Size = new System.Drawing.Size(90, 23);
            this.buttonReflection.TabIndex = 14;
            this.buttonReflection.Text = "reflection";
            this.buttonReflection.UseVisualStyleBackColor = true;
            this.buttonReflection.Click += new System.EventHandler(this.buttonReflection_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(21, 506);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(90, 23);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonContrast
            // 
            this.buttonContrast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonContrast.Location = new System.Drawing.Point(21, 244);
            this.buttonContrast.Name = "buttonContrast";
            this.buttonContrast.Size = new System.Drawing.Size(90, 23);
            this.buttonContrast.TabIndex = 12;
            this.buttonContrast.Text = "contrast (up)";
            this.buttonContrast.UseVisualStyleBackColor = true;
            this.buttonContrast.Click += new System.EventHandler(this.buttonContrast_Click);
            // 
            // buttonBrightness
            // 
            this.buttonBrightness.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBrightness.Location = new System.Drawing.Point(21, 340);
            this.buttonBrightness.Name = "buttonBrightness";
            this.buttonBrightness.Size = new System.Drawing.Size(90, 23);
            this.buttonBrightness.TabIndex = 11;
            this.buttonBrightness.Text = "brightness";
            this.buttonBrightness.UseVisualStyleBackColor = true;
            this.buttonBrightness.Click += new System.EventHandler(this.buttonBrightness_Click);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(11, 302);
            this.trackBar3.Maximum = 100;
            this.trackBar3.Minimum = -100;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(104, 45);
            this.trackBar3.TabIndex = 10;
            this.trackBar3.TickFrequency = 10;
            // 
            // buttonDefiningBoundaries
            // 
            this.buttonDefiningBoundaries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDefiningBoundaries.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDefiningBoundaries.Location = new System.Drawing.Point(21, 273);
            this.buttonDefiningBoundaries.Name = "buttonDefiningBoundaries";
            this.buttonDefiningBoundaries.Size = new System.Drawing.Size(90, 23);
            this.buttonDefiningBoundaries.TabIndex = 9;
            this.buttonDefiningBoundaries.TabStop = false;
            this.buttonDefiningBoundaries.Text = "define border";
            this.buttonDefiningBoundaries.UseVisualStyleBackColor = true;
            this.buttonDefiningBoundaries.Click += new System.EventHandler(this.buttonDefiningBoundaries_Click);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(11, 170);
            this.trackBar2.Maximum = 20;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(104, 45);
            this.trackBar2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(5, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "number of \"saw\" peaks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "noise intensity";
            // 
            // buttonContrastSaw
            // 
            this.buttonContrastSaw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonContrastSaw.Location = new System.Drawing.Point(21, 215);
            this.buttonContrastSaw.Name = "buttonContrastSaw";
            this.buttonContrastSaw.Size = new System.Drawing.Size(90, 23);
            this.buttonContrastSaw.TabIndex = 5;
            this.buttonContrastSaw.TabStop = false;
            this.buttonContrastSaw.Text = "contrast (saw)";
            this.buttonContrastSaw.UseVisualStyleBackColor = true;
            this.buttonContrastSaw.Click += new System.EventHandler(this.buttonContrastSaw_Click);
            // 
            // buttonGray
            // 
            this.buttonGray.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGray.Location = new System.Drawing.Point(21, 128);
            this.buttonGray.Name = "buttonGray";
            this.buttonGray.Size = new System.Drawing.Size(90, 23);
            this.buttonGray.TabIndex = 3;
            this.buttonGray.TabStop = false;
            this.buttonGray.Text = "shade of gray";
            this.buttonGray.UseVisualStyleBackColor = true;
            this.buttonGray.Click += new System.EventHandler(this.buttonGray_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.Teal;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(8, 53);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(107, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.TickFrequency = 10;
            // 
            // buttonNoise
            // 
            this.buttonNoise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNoise.Location = new System.Drawing.Point(21, 99);
            this.buttonNoise.Name = "buttonNoise";
            this.buttonNoise.Size = new System.Drawing.Size(90, 23);
            this.buttonNoise.TabIndex = 1;
            this.buttonNoise.TabStop = false;
            this.buttonNoise.Text = "add noise";
            this.buttonNoise.UseVisualStyleBackColor = true;
            this.buttonNoise.Click += new System.EventHandler(this.buttonNoise_Click);
            // 
            // buttonOpenImage
            // 
            this.buttonOpenImage.AutoEllipsis = true;
            this.buttonOpenImage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonOpenImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonOpenImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonOpenImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonOpenImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenImage.Location = new System.Drawing.Point(21, 11);
            this.buttonOpenImage.Name = "buttonOpenImage";
            this.buttonOpenImage.Size = new System.Drawing.Size(90, 23);
            this.buttonOpenImage.TabIndex = 0;
            this.buttonOpenImage.TabStop = false;
            this.buttonOpenImage.Text = "open image";
            this.buttonOpenImage.UseVisualStyleBackColor = true;
            this.buttonOpenImage.Click += new System.EventHandler(this.buttunOpenImage_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.91182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.08818F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(707, 540);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MediumOrchid;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(355, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(349, 264);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.MediumOrchid;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(3, 273);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(346, 264);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.MediumOrchid;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Location = new System.Drawing.Point(355, 273);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(349, 264);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumOrchid;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Images|*.bmp;*.png;*jpg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(41, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Accuracy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(843, 542);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "      Image processing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonOpenImage;
        private System.Windows.Forms.Button buttonNoise;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button buttonGray;
        private System.Windows.Forms.Button buttonContrastSaw;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDefiningBoundaries;
        private System.Windows.Forms.Button buttonBrightness;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.Button buttonContrast;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonReflection;
        private System.Windows.Forms.Button buttonHough;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.Button buttonBinaryImage;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.Label label3;
    }
}

