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
        int red, green, blue, alpha; //nilai RGB untuk pen (0-255)

        int posX, posY, lengthX, lengthY; // paramater graphic.Draw...

        bool mouseDrag = false; //apakah mouse ter-drag

        int nodecount = 0;
        Point[] arrnode = new Point[255]; 
        

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

            groupBox2.BackColor = Color.FromArgb(220, 255, 255, 255);

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {//mengosongkan picture box
            bmpGraph.Clear(pictureBox1.BackColor);
            tmpimg2 = (Bitmap)tmpimg1.Clone();
            pictureBox1.Image = tmpimg1;
            arrnode = new Point[255];
            nodecount = 0;
        }

        /*
         * tool:
         *      -circle     -brush
         *      -square     -eraser
         *      -line       -poligon
         *      
         *      Warna text pada tool terpilih di ubah ke Blue
         *      yang lain Black
         */

        
        

        private void trackBarBLUE_ValueChanged(object sender, EventArgs e)
        {// dipanggil setiap nilai rgb trackbar berubah
         //berlaku untuk ketiga trackbar
            if (radioButtonOutline.Checked)
            {
                red = trackBarRED.Value;
                green = trackBarGREEN.Value;
                blue = trackBarBLUE.Value;
                alpha = trackBarAlpha.Value;
                pictureBox2.BackColor = Color.FromArgb(alpha, red, green, blue);
                //Graphics graph = pictureBox2.CreateGraphics();
                //graph.Clear(Color.FromArgb(red, green, blue));
            }
            if (radioButtonFill.Checked)
            {
                red = trackBarRED.Value;
                green = trackBarGREEN.Value;
                blue = trackBarBLUE.Value;
                alpha = trackBarAlpha.Value;
                pictureBox3.BackColor = Color.FromArgb(alpha, red, green, blue);
                //Graphics graph = pictureBox3.CreateGraphics();
                //graph.Clear(Color.FromArgb(red, green, blue));
            }
                
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("test");
        }

        private void radioButtonFill_MouseClick(object sender, MouseEventArgs e)
        {
            Color fill = pictureBox3.BackColor;
            trackBarRED.Value = fill.R;
            trackBarGREEN.Value = fill.G;
            trackBarBLUE.Value = fill.B;
            trackBarAlpha.Value = fill.A;
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            Image saved = pictureBox1.Image;
            
            try
            {
                if (saved != null)
                {
                    saved.Save(pathbox.Text , System.Drawing.Imaging.ImageFormat.Jpeg);
                    MessageBox.Show("file saved in : \n"+pathbox.Text +"\n"+ "as a jpeg file" );

                }
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem saving the file." +
                    "Check the file permissions.");
            }

        }

        private void poly_CheckedChanged(object sender, EventArgs e)
        {
            if(poly.Checked || curve.Checked)
            {
                btnconfirm.Enabled = true;
            }
            else
            {
                arrnode = new Point[255];
                nodecount = 0;
                btnconfirm.Enabled = false;
            }
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(pictureBox2.BackColor); //inisilaisasi dengan nila RGB
            pen.Width = trackBarOutline.Value;  //sesuaikan ketebalan
            SolidBrush brush = new SolidBrush(pictureBox3.BackColor);
            if (poly.Checked )
            {
                //Point[] drawnode = new Point[nodecount + 1];
                //drawnode[0] = arrnode[0];
                //for (int i = 0; i < nodecount; i++)
                //{
                //    drawnode[i + 1] = arrnode[i];
                //}
               
                //bmpGraph.DrawPolygon(pen, drawnode);
                //bmpGraph.FillPolygon(brush, drawnode);
                tmpimg2 = (Bitmap)tmpimg1.Clone();
                pictureBox1.Image = tmpimg1;
                Brush.Checked = true;
                arrnode = new Point[255];
                nodecount = 0;

            }
        }

        private void radioButtonOutline_CheckedChanged(object sender, EventArgs e)
        {
            Color fill = pictureBox2.BackColor;
            trackBarRED.Value = fill.R;
            trackBarGREEN.Value = fill.G;
            trackBarBLUE.Value = fill.B;
            trackBarAlpha.Value = fill.A;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDrag = false;

            lengthX = (e.X - posX);
            lengthY = (e.Y - posY);


            if (!poly.Checked)
            {
                bmpGraph.Clear(pictureBox1.BackColor);
                if (tmpimg1 != null)//kalau aja null just to be safe
                {

                    bmpGraph.DrawImage(tmpimg2, 0, 0);
                }
            }
            //proses double buffer image
           

            Pen pen = new Pen(pictureBox2.BackColor); //inisilaisasi dengan nila RGB
            pen.Width = trackBarOutline.Value;  //sesuaikan ketebalan
            SolidBrush brush = new SolidBrush(pictureBox3.BackColor);



            if (Circle.Checked)
            {
                bmpGraph.DrawEllipse(pen, posX, posY, lengthX, lengthY);
                bmpGraph.FillEllipse(brush, posX, posY, lengthX, lengthY);


            }
            else if (Square.Checked)
            {
                //spcial case
                if (lengthX < 0)
                {
                    posX = e.X;
                    lengthX = Math.Abs(lengthX);
                }

                if (lengthY < 0)
                {
                    posY = e.Y;
                    lengthY = Math.Abs(lengthY);
                }
                bmpGraph.DrawRectangle(pen, posX, posY, lengthX, lengthY);
                bmpGraph.FillRectangle(brush, posX, posY, lengthX, lengthY);
            }
            else if (Line.Checked)
            {
                bmpGraph.DrawLine(pen, posX, posY, e.X, e.Y);
            }
            
            if (!poly.Checked)
            {
                tmpimg2 = (Bitmap)tmpimg1.Clone();
            }
            //proses double buffer image
           
            pictureBox1.Image = tmpimg1;

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDrag = true;
            posX = e.X;
            posY = e.Y;

            bmpGraph.Clear(pictureBox1.BackColor);

            if (tmpimg1 != null)
            {
                bmpGraph.DrawImage(tmpimg2, 0, 0);
            }

            //untuk Undo
            //simpan bitmap sebelum mouse kemana-mana
            previmg = (Bitmap)tmpimg2.Clone();

            Pen pen = new Pen(pictureBox2.BackColor); //inisilaisasi dengan nila RGB
            pen.Width = trackBarOutline.Value;  //sesuaikan ketebalan
            SolidBrush brush = new SolidBrush(pictureBox3.BackColor);
            if (poly.Checked)
            {
                arrnode[nodecount] = new Point(e.X, e.Y);
                

                Point[] drawnode = new Point[nodecount +2];
                drawnode[0] = new Point(e.X, e.Y);
                drawnode[1] = new Point(e.X, e.Y);
                for (int i = 0; i < nodecount; i++)
                {
                    drawnode[i+2] = arrnode[i];
                }

                bmpGraph.DrawPolygon(pen, drawnode);
                bmpGraph.FillPolygon(brush, drawnode);
                nodecount++;
            }
            pictureBox1.Image = tmpimg1;

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {   if (mouseDrag)
            {
                lengthX = (e.X - posX);
                lengthY = (e.Y - posY);

                if (!poly.Checked)
                {
                    bmpGraph.Clear(pictureBox1.BackColor);

                    if (tmpimg1 != null)
                    {
                        bmpGraph.DrawImage(tmpimg2, 0, 0);
                    }
                }
               



                Pen pen = new Pen(pictureBox2.BackColor);
                pen.Width = trackBarOutline.Value;
                SolidBrush brush = new SolidBrush(pictureBox3.BackColor);



                if (Circle.Checked)
                {
                    bmpGraph.DrawEllipse(pen, posX, posY, lengthX, lengthY);
                    bmpGraph.FillEllipse(brush, posX, posY, lengthX, lengthY);


                }
                else if (Square.Checked)
                {
                    //spcial case
                    int posX1 = posX;
                    int posY1 = posY;
                    if (lengthX < 0)
                    {
                        posX1 = e.X;
                        lengthX = Math.Abs(lengthX);
                    }

                    if (lengthY < 0)
                    {
                        posY1 = e.Y;
                        lengthY = Math.Abs(lengthY);
                    }
                    bmpGraph.DrawRectangle(pen, posX1, posY1, lengthX, lengthY);
                    bmpGraph.FillRectangle(brush, posX1, posY1, lengthX, lengthY);
                }
                else if (Line.Checked)
                {
                    bmpGraph.DrawLine(pen, posX, posY, e.X, e.Y);
                    
                }
                else if (Brush.Checked)
                {//gumbar garis baru setiap mouse di drag
                 //NOT PERFECT YET
                    bmpGraph.DrawEllipse(pen, e.X, e.Y, pen.Width / 2, pen.Width / 2);
                    bmpGraph.DrawLine(pen, posX, posY, e.X, e.Y);
                    posX = e.X;
                    posY = e.Y;

                    
                    tmpimg2 = (Bitmap)tmpimg1.Clone();
                    

                }
                else if (Eraser.Checked)
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
