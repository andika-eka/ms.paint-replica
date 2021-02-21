using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grafikaKom1
{
    public partial class Form1 : Form
    {
        int red, green, blue; //nilai RGB untuk pen (0-255)

        int posX, posY, lengthX, lengthY; // paramater graphic.Draw...

        bool mouseDrag = false; //apakah mouse ter-drag
        
        String tool;// menyimpan tool yang dipilih

        //proses double buffer image
        Bitmap tmpimg1;
        Bitmap tmpimg2;
        Graphics bmpGraph;

        Bitmap previmg;//menyimpan bitmap untuk proses Undo


        public Form1()
        {
            InitializeComponent();
            tmpimg1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            tmpimg2 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            bmpGraph = Graphics.FromImage(tmpimg1);

            previmg = new Bitmap(pictureBox1.Width, pictureBox1.Height);

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {//mengosongkan picture box
            bmpGraph.Clear(pictureBox1.BackColor);
            tmpimg2 = (Bitmap)tmpimg1.Clone();
            pictureBox1.Image = tmpimg1;

        }

        /*
         * tool:
         *      -circle     -brush
         *      -square     -eraser
         *      -line
         *      
         *      Warna text pada tool terpilih di ubah ke Blue
         *      yang lain Black
         */

        private void buttonLine_Click(object sender, EventArgs e)
        {
            tool = "Line";
            buttonLine.ForeColor = Color.Blue;
            buttonEraser.ForeColor = Color.Black;
            buttonBrush.ForeColor = Color.Black;
            buttonCircle.ForeColor = Color.Black;
            buttonSquare.ForeColor = Color.Black;
        }

       
        private void buttonCircle_Click(object sender, EventArgs e)
        {
            tool = "Circle";
            buttonLine.ForeColor = Color.Black;
            buttonEraser.ForeColor = Color.Black;
            buttonBrush.ForeColor = Color.Black;
            buttonCircle.ForeColor = Color.Blue;
            buttonSquare.ForeColor = Color.Black;
        }

        private void buttonBrush_Click(object sender, EventArgs e)
        {
            tool = "Brush";
            buttonLine.ForeColor = Color.Black;
            buttonEraser.ForeColor = Color.Black;
            buttonBrush.ForeColor = Color.Blue;
            buttonCircle.ForeColor = Color.Black;
            buttonSquare.ForeColor = Color.Black;
        }

        private void buttonEraser_Click(object sender, EventArgs e)
        {
            tool = "Eraser";
            buttonLine.ForeColor = Color.Black;
            buttonEraser.ForeColor = Color.Blue;
            buttonBrush.ForeColor = Color.Black;
            buttonCircle.ForeColor = Color.Black;
            buttonSquare.ForeColor = Color.Black;
        }

        

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            tool = "Square";
            buttonLine.ForeColor = Color.Black;
            buttonEraser.ForeColor = Color.Black;
            buttonBrush.ForeColor = Color.Black;
            buttonCircle.ForeColor = Color.Black;
            buttonSquare.ForeColor = Color.Blue;
        }

        

        private void trackBarBLUE_ValueChanged(object sender, EventArgs e)
        {// dipanggil setiap nilai rgb trackbar berubah
         //berlaku untuk ketiga trackbar
            red = trackBarRED.Value;
            green = trackBarGREEN.Value;
            blue = trackBarBLUE.Value;
            Graphics graph = pictureBox2.CreateGraphics();
            graph.Clear(Color.FromArgb(red, green, blue));
        }

        

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDrag = false;

            lengthX = (e.X - posX);
            lengthY = (e.Y - posY);

            //proses double buffer image
            bmpGraph.Clear(pictureBox1.BackColor);
            if(tmpimg1 != null)//kalau aja null just to be safe
            {
                bmpGraph.DrawImage(tmpimg2, 0, 0);
            }

            Pen pen = new Pen(Color.FromArgb(red, green, blue)); //inisilaisasi dengan nila RGB
            pen.Width = trackBarOutline.Value;  //sesuaikan ketebalan


            if (tool == "Circle")
            {
                bmpGraph.DrawEllipse(pen, posX, posY, lengthX, lengthY);
                
            }
            else if (tool == "Square")
            {
                bmpGraph.DrawRectangle(pen, posX, posY, lengthX, lengthY);
            }
            else if (tool == "Line")
            {
                bmpGraph.DrawLine(pen, posX, posY, e.X, e.Y);
            }

            //proses double buffer image
            tmpimg2 = (Bitmap)tmpimg1.Clone();
            pictureBox1.Image = tmpimg1;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDrag = true;
            posX = e.X;
            posY = e.Y;

            //untuk Undo
            //simpan bitmap sebelum mouse kemana-mana
            previmg = (Bitmap)tmpimg2.Clone();

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {   if (mouseDrag)
            {
                lengthX = (e.X - posX);
                lengthY = (e.Y - posY);


                bmpGraph.Clear(pictureBox1.BackColor);

                if (tmpimg1 != null)
                {
                    bmpGraph.DrawImage(tmpimg2, 0, 0);
                }



                Pen pen = new Pen(Color.FromArgb(red, green, blue));
                pen.Width = trackBarOutline.Value;
                
                
                if (tool == "Circle")
                {
                    bmpGraph.DrawEllipse(pen, posX, posY, lengthX, lengthY);
                    
                }
                else if (tool == "Square")
                {
                    bmpGraph.DrawRectangle(pen, posX, posY, lengthX, lengthY);
                    
                }
                else if (tool == "Line")
                {
                    bmpGraph.DrawLine(pen, posX, posY, e.X, e.Y);
                    
                }
                else if (tool == "Brush")
                {//gumbar garis baru setiap mouse di drag
                 //NOT PERFECT YET
                    bmpGraph.DrawLine(pen, posX, posY, e.X, e.Y);
                    posX = e.X;
                    posY = e.Y;
                    tmpimg2 = (Bitmap)tmpimg1.Clone();
                    

                }
                else if (tool == "Eraser")
                {
                    //sama dengan brursh cuma pakai pictureBox1.BackColor
                    pen = new Pen(pictureBox1.BackColor);
                    pen.Width = trackBarOutline.Value;
                    bmpGraph.DrawLine(pen, posX, posY, e.X, e.Y);
                    posX = e.X;
                    posY = e.Y;
                    tmpimg2 = (Bitmap)tmpimg1.Clone();
                   
                }
                pictureBox1.Image = tmpimg1;
            }
            
        }
        private void buttonUndo_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = previmg;
            tmpimg2 = (Bitmap) previmg.Clone();
        }
        private void buttonRedo_Click(object sender, EventArgs e)
        {
            tmpimg2 = (Bitmap)tmpimg1.Clone();
            pictureBox1.Image = tmpimg1;
        }
    }
}
