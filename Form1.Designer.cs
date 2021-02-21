
namespace grafikaKom1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.trackBarRED = new System.Windows.Forms.TrackBar();
            this.trackBarGREEN = new System.Windows.Forms.TrackBar();
            this.trackBarBLUE = new System.Windows.Forms.TrackBar();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonLine = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.trackBarOutline = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonBrush = new System.Windows.Forms.Button();
            this.buttonEraser = new System.Windows.Forms.Button();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.buttonRedo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGREEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBLUE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOutline)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(849, 415);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(653, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(649, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(653, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "blue";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(561, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 67);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // trackBarRED
            // 
            this.trackBarRED.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarRED.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarRED.Location = new System.Drawing.Point(691, 12);
            this.trackBarRED.Maximum = 255;
            this.trackBarRED.Name = "trackBarRED";
            this.trackBarRED.Size = new System.Drawing.Size(171, 45);
            this.trackBarRED.TabIndex = 10;
            this.trackBarRED.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarRED.ValueChanged += new System.EventHandler(this.trackBarBLUE_ValueChanged);
            // 
            // trackBarGREEN
            // 
            this.trackBarGREEN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarGREEN.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarGREEN.Location = new System.Drawing.Point(691, 41);
            this.trackBarGREEN.Maximum = 255;
            this.trackBarGREEN.Name = "trackBarGREEN";
            this.trackBarGREEN.Size = new System.Drawing.Size(171, 45);
            this.trackBarGREEN.TabIndex = 11;
            this.trackBarGREEN.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarGREEN.ValueChanged += new System.EventHandler(this.trackBarBLUE_ValueChanged);
            // 
            // trackBarBLUE
            // 
            this.trackBarBLUE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarBLUE.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarBLUE.Location = new System.Drawing.Point(691, 73);
            this.trackBarBLUE.Maximum = 255;
            this.trackBarBLUE.Name = "trackBarBLUE";
            this.trackBarBLUE.Size = new System.Drawing.Size(171, 45);
            this.trackBarBLUE.TabIndex = 12;
            this.trackBarBLUE.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarBLUE.ValueChanged += new System.EventHandler(this.trackBarBLUE_ValueChanged);
            // 
            // buttonCircle
            // 
            this.buttonCircle.Location = new System.Drawing.Point(13, 13);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(75, 23);
            this.buttonCircle.TabIndex = 13;
            this.buttonCircle.Text = "Circle";
            this.buttonCircle.UseVisualStyleBackColor = true;
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click);
            // 
            // buttonSquare
            // 
            this.buttonSquare.Location = new System.Drawing.Point(13, 42);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(75, 23);
            this.buttonSquare.TabIndex = 14;
            this.buttonSquare.Text = "Square";
            this.buttonSquare.UseVisualStyleBackColor = true;
            this.buttonSquare.Click += new System.EventHandler(this.buttonSquare_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.Location = new System.Drawing.Point(13, 73);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(75, 23);
            this.buttonLine.TabIndex = 15;
            this.buttonLine.Text = "Line";
            this.buttonLine.UseVisualStyleBackColor = true;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonClear.Location = new System.Drawing.Point(340, 17);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 79);
            this.buttonClear.TabIndex = 16;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // trackBarOutline
            // 
            this.trackBarOutline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarOutline.Location = new System.Drawing.Point(631, 102);
            this.trackBarOutline.Maximum = 15;
            this.trackBarOutline.Minimum = 1;
            this.trackBarOutline.Name = "trackBarOutline";
            this.trackBarOutline.Size = new System.Drawing.Size(231, 45);
            this.trackBarOutline.TabIndex = 17;
            this.trackBarOutline.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarOutline.Value = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(585, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Outline";
            // 
            // buttonBrush
            // 
            this.buttonBrush.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBrush.Location = new System.Drawing.Point(94, 12);
            this.buttonBrush.Name = "buttonBrush";
            this.buttonBrush.Size = new System.Drawing.Size(75, 23);
            this.buttonBrush.TabIndex = 19;
            this.buttonBrush.Text = "Brush";
            this.buttonBrush.UseVisualStyleBackColor = true;
            this.buttonBrush.Click += new System.EventHandler(this.buttonBrush_Click);
            // 
            // buttonEraser
            // 
            this.buttonEraser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEraser.Location = new System.Drawing.Point(94, 45);
            this.buttonEraser.Name = "buttonEraser";
            this.buttonEraser.Size = new System.Drawing.Size(75, 23);
            this.buttonEraser.TabIndex = 20;
            this.buttonEraser.Text = "Eraser";
            this.buttonEraser.UseVisualStyleBackColor = true;
            this.buttonEraser.Click += new System.EventHandler(this.buttonEraser_Click);
            // 
            // buttonUndo
            // 
            this.buttonUndo.Location = new System.Drawing.Point(243, 12);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(75, 23);
            this.buttonUndo.TabIndex = 21;
            this.buttonUndo.Text = "Undo";
            this.buttonUndo.UseVisualStyleBackColor = true;
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // buttonRedo
            // 
            this.buttonRedo.Location = new System.Drawing.Point(243, 45);
            this.buttonRedo.Name = "buttonRedo";
            this.buttonRedo.Size = new System.Drawing.Size(75, 23);
            this.buttonRedo.TabIndex = 22;
            this.buttonRedo.Text = "Redo";
            this.buttonRedo.UseVisualStyleBackColor = true;
            this.buttonRedo.Click += new System.EventHandler(this.buttonRedo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 560);
            this.Controls.Add(this.buttonRedo);
            this.Controls.Add(this.buttonUndo);
            this.Controls.Add(this.buttonEraser);
            this.Controls.Add(this.buttonBrush);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.trackBarOutline);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonLine);
            this.Controls.Add(this.buttonSquare);
            this.Controls.Add(this.buttonCircle);
            this.Controls.Add(this.trackBarBLUE);
            this.Controls.Add(this.trackBarGREEN);
            this.Controls.Add(this.trackBarRED);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGREEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBLUE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOutline)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TrackBar trackBarRED;
        private System.Windows.Forms.TrackBar trackBarGREEN;
        private System.Windows.Forms.TrackBar trackBarBLUE;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TrackBar trackBarOutline;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonBrush;
        private System.Windows.Forms.Button buttonEraser;
        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.Button buttonRedo;
    }
}

