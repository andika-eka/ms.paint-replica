
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.trackBarRED = new System.Windows.Forms.TrackBar();
            this.trackBarGREEN = new System.Windows.Forms.TrackBar();
            this.trackBarBLUE = new System.Windows.Forms.TrackBar();
            this.buttonClear = new System.Windows.Forms.Button();
            this.trackBarOutline = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.buttonRedo = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonOutline = new System.Windows.Forms.RadioButton();
            this.radioButtonFill = new System.Windows.Forms.RadioButton();
            this.trackBarAlpha = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Eraser = new System.Windows.Forms.RadioButton();
            this.Brush = new System.Windows.Forms.RadioButton();
            this.Line = new System.Windows.Forms.RadioButton();
            this.Square = new System.Windows.Forms.RadioButton();
            this.Circle = new System.Windows.Forms.RadioButton();
            this.Savebtn = new System.Windows.Forms.Button();
            this.poly = new System.Windows.Forms.RadioButton();
            this.curve = new System.Windows.Forms.RadioButton();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.pathbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGREEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBLUE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOutline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAlpha)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(13, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1402, 648);
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
            this.label1.Location = new System.Drawing.Point(1206, 12);
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
            this.label2.Location = new System.Drawing.Point(1202, 36);
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
            this.label3.Location = new System.Drawing.Point(1206, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Blue";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(1106, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 85);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // trackBarRED
            // 
            this.trackBarRED.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarRED.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarRED.Location = new System.Drawing.Point(1244, 7);
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
            this.trackBarGREEN.Location = new System.Drawing.Point(1244, 33);
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
            this.trackBarBLUE.Location = new System.Drawing.Point(1244, 61);
            this.trackBarBLUE.Maximum = 255;
            this.trackBarBLUE.Name = "trackBarBLUE";
            this.trackBarBLUE.Size = new System.Drawing.Size(171, 45);
            this.trackBarBLUE.TabIndex = 12;
            this.trackBarBLUE.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarBLUE.ValueChanged += new System.EventHandler(this.trackBarBLUE_ValueChanged);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonClear.Location = new System.Drawing.Point(407, 12);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(74, 24);
            this.buttonClear.TabIndex = 16;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // trackBarOutline
            // 
            this.trackBarOutline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarOutline.Location = new System.Drawing.Point(1244, 124);
            this.trackBarOutline.Maximum = 15;
            this.trackBarOutline.Minimum = 1;
            this.trackBarOutline.Name = "trackBarOutline";
            this.trackBarOutline.Size = new System.Drawing.Size(171, 45);
            this.trackBarOutline.TabIndex = 17;
            this.trackBarOutline.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarOutline.Value = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1198, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Outline";
            // 
            // buttonUndo
            // 
            this.buttonUndo.Location = new System.Drawing.Point(326, 12);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(75, 23);
            this.buttonUndo.TabIndex = 21;
            this.buttonUndo.Text = "Undo";
            this.buttonUndo.UseVisualStyleBackColor = true;
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // buttonRedo
            // 
            this.buttonRedo.Location = new System.Drawing.Point(326, 45);
            this.buttonRedo.Name = "buttonRedo";
            this.buttonRedo.Size = new System.Drawing.Size(75, 23);
            this.buttonRedo.TabIndex = 22;
            this.buttonRedo.Text = "Redo";
            this.buttonRedo.UseVisualStyleBackColor = true;
            this.buttonRedo.Click += new System.EventHandler(this.buttonRedo_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(1119, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 64);
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioButtonOutline);
            this.groupBox1.Controls.Add(this.radioButtonFill);
            this.groupBox1.Location = new System.Drawing.Point(1108, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(92, 52);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // radioButtonOutline
            // 
            this.radioButtonOutline.AutoSize = true;
            this.radioButtonOutline.Checked = true;
            this.radioButtonOutline.Location = new System.Drawing.Point(30, 29);
            this.radioButtonOutline.Name = "radioButtonOutline";
            this.radioButtonOutline.Size = new System.Drawing.Size(56, 17);
            this.radioButtonOutline.TabIndex = 1;
            this.radioButtonOutline.TabStop = true;
            this.radioButtonOutline.Text = "outline";
            this.radioButtonOutline.UseVisualStyleBackColor = true;
            this.radioButtonOutline.CheckedChanged += new System.EventHandler(this.radioButtonOutline_CheckedChanged);
            // 
            // radioButtonFill
            // 
            this.radioButtonFill.AutoSize = true;
            this.radioButtonFill.Location = new System.Drawing.Point(30, 10);
            this.radioButtonFill.Name = "radioButtonFill";
            this.radioButtonFill.Size = new System.Drawing.Size(37, 17);
            this.radioButtonFill.TabIndex = 0;
            this.radioButtonFill.Text = "Fill";
            this.radioButtonFill.UseVisualStyleBackColor = true;
            this.radioButtonFill.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButtonFill_MouseClick);
            // 
            // trackBarAlpha
            // 
            this.trackBarAlpha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarAlpha.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarAlpha.Location = new System.Drawing.Point(1244, 88);
            this.trackBarAlpha.Maximum = 255;
            this.trackBarAlpha.Name = "trackBarAlpha";
            this.trackBarAlpha.Size = new System.Drawing.Size(171, 45);
            this.trackBarAlpha.TabIndex = 26;
            this.trackBarAlpha.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarAlpha.Value = 255;
            this.trackBarAlpha.ValueChanged += new System.EventHandler(this.trackBarBLUE_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(1206, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Alpha";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.btnconfirm);
            this.groupBox2.Controls.Add(this.curve);
            this.groupBox2.Controls.Add(this.poly);
            this.groupBox2.Controls.Add(this.Eraser);
            this.groupBox2.Controls.Add(this.Brush);
            this.groupBox2.Controls.Add(this.Line);
            this.groupBox2.Controls.Add(this.Square);
            this.groupBox2.Controls.Add(this.Circle);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(13, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 137);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tools";
            // 
            // Eraser
            // 
            this.Eraser.AutoSize = true;
            this.Eraser.Location = new System.Drawing.Point(6, 107);
            this.Eraser.Name = "Eraser";
            this.Eraser.Size = new System.Drawing.Size(55, 17);
            this.Eraser.TabIndex = 4;
            this.Eraser.Text = "Eraser";
            this.Eraser.UseVisualStyleBackColor = true;
            // 
            // Brush
            // 
            this.Brush.AutoSize = true;
            this.Brush.Checked = true;
            this.Brush.Location = new System.Drawing.Point(6, 84);
            this.Brush.Name = "Brush";
            this.Brush.Size = new System.Drawing.Size(52, 17);
            this.Brush.TabIndex = 3;
            this.Brush.TabStop = true;
            this.Brush.Text = "Brush";
            this.Brush.UseVisualStyleBackColor = true;
            // 
            // Line
            // 
            this.Line.AutoSize = true;
            this.Line.Location = new System.Drawing.Point(6, 61);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(45, 17);
            this.Line.TabIndex = 2;
            this.Line.Text = "Line";
            this.Line.UseVisualStyleBackColor = true;
            // 
            // Square
            // 
            this.Square.AutoSize = true;
            this.Square.Location = new System.Drawing.Point(6, 38);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(59, 17);
            this.Square.TabIndex = 1;
            this.Square.Text = "Squere";
            this.Square.UseVisualStyleBackColor = true;
            // 
            // Circle
            // 
            this.Circle.AutoSize = true;
            this.Circle.Location = new System.Drawing.Point(6, 15);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(51, 17);
            this.Circle.TabIndex = 0;
            this.Circle.Text = "Circle";
            this.Circle.UseVisualStyleBackColor = true;
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(1000, 11);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(75, 23);
            this.Savebtn.TabIndex = 27;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // poly
            // 
            this.poly.AutoSize = true;
            this.poly.Location = new System.Drawing.Point(83, 14);
            this.poly.Name = "poly";
            this.poly.Size = new System.Drawing.Size(62, 17);
            this.poly.TabIndex = 5;
            this.poly.Text = "polygon";
            this.poly.UseVisualStyleBackColor = true;
            this.poly.CheckedChanged += new System.EventHandler(this.poly_CheckedChanged);
            // 
            // curve
            // 
            this.curve.AutoSize = true;
            this.curve.Location = new System.Drawing.Point(83, 37);
            this.curve.Name = "curve";
            this.curve.Size = new System.Drawing.Size(52, 17);
            this.curve.TabIndex = 6;
            this.curve.Text = "curve";
            this.curve.UseVisualStyleBackColor = true;
            this.curve.CheckedChanged += new System.EventHandler(this.poly_CheckedChanged);
            // 
            // btnconfirm
            // 
            this.btnconfirm.Enabled = false;
            this.btnconfirm.Location = new System.Drawing.Point(185, 104);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(75, 23);
            this.btnconfirm.TabIndex = 28;
            this.btnconfirm.Text = "confrim";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // pathbox
            // 
            this.pathbox.Location = new System.Drawing.Point(715, 12);
            this.pathbox.Name = "pathbox";
            this.pathbox.Size = new System.Drawing.Size(279, 20);
            this.pathbox.TabIndex = 28;
            this.pathbox.Text = "d:\\\\test.jpeg";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(680, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Path :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1427, 807);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pathbox);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.buttonRedo);
            this.Controls.Add(this.buttonUndo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.trackBarOutline);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarAlpha);
            this.Controls.Add(this.trackBarBLUE);
            this.Controls.Add(this.trackBarGREEN);
            this.Controls.Add(this.trackBarRED);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Andika Paint";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGREEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBLUE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOutline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAlpha)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TrackBar trackBarOutline;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.Button buttonRedo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonFill;
        private System.Windows.Forms.RadioButton radioButtonOutline;
        private System.Windows.Forms.TrackBar trackBarAlpha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Line;
        private System.Windows.Forms.RadioButton Square;
        private System.Windows.Forms.RadioButton Circle;
        private System.Windows.Forms.RadioButton Eraser;
        private System.Windows.Forms.RadioButton Brush;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.RadioButton curve;
        private System.Windows.Forms.RadioButton poly;
        private System.Windows.Forms.TextBox pathbox;
        private System.Windows.Forms.Label label6;
    }
}

