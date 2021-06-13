using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlpMehmetOzturk_154410010_CokKatmanliAgModeli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string giris1S = "-";
        public string giris2S = "-";
        public string bS = "-";
        public string e1S = "-";
        public string e2S = "-";
        public string a1_1S = "a11";
        public string a1_2S = "a12";
        public string a2_2S = "a22";
        public string a2_1S = "a21";
        public string a4_1S = "a41";
        public string a5_1S = "a51";

        public string a3_1S = "a31";
        public string a6_1S = "a61";
        public string a3_2S = "a32";

        public double a11 = 0;
        public double giris1 = 0;
        public double a12 = 0;
        public double giris2 = 0;
        public double a22 = 0;
        public double e1 = 0;
        public double a21 = 0;
        public double e2 = 0;
        public double a32 = 0;
        public double a31 = 0;
        public double a51 = 0;
        public double a41 = 0;
        public double a61 = 0;
        public double b = 0;
        public double k = 0;
        public double mk = 0;
        double a41t = 0;
        double a51t = 0;
        double a61t = 0;
        

        private void button1_Click(object sender, EventArgs e)
        {

        
            
            //yazı
            Graphics yazimA = pictureBox1.CreateGraphics();
            Brush firca = new SolidBrush(Color.Black);
            Font yazi = new Font("Georgia", 9, FontStyle.Bold);
 

            yazimA.DrawString("Net1", yazi, firca, 245, 30);
            yazimA.DrawString("Net2", yazi, firca, 245, 200);
            yazimA.DrawString("Net3", yazi, firca, 460, 110);
            yazimA.DrawString("Ç1", yazi, firca,85, 20);
            yazimA.DrawString("Ç2", yazi, firca,85, 190);
            yazimA.DrawString("Ç4", yazi, firca, 300, 20);
            yazimA.DrawString("Ç5", yazi, firca, 300, 190);
            yazimA.DrawString("Ç3", yazi, firca, 205, 265);

            yazimA.DrawString(giris1S.ToString(), yazi, firca, 3, 30);
            yazimA.DrawString(giris2S.ToString(), yazi, firca, 3, 200);

            yazimA.DrawString(e1S.ToString(), yazi, firca, 130, 305);
            yazimA.DrawString(e2S.ToString(), yazi, firca, 380, 305);

            yazimA.DrawString(bS.ToString(), yazi, firca, 520, 112);
            yazimA.DrawString(a1_1S, yazi, firca, 150, 20);
            yazimA.DrawString(a2_2S, yazi, firca, 130, 210);
            yazimA.DrawString(a4_1S, yazi, firca, 350, 40);
            yazimA.DrawString(a1_2S, yazi, firca, 135, 55);
            yazimA.DrawString(a3_1S, yazi, firca, 255, 75);
            yazimA.DrawString(a3_2S, yazi, firca, 245, 225);
            yazimA.DrawString(a2_1S, yazi, firca, 115, 160);
            yazimA.DrawString(a5_1S, yazi, firca, 350, 190);
            yazimA.DrawString(a6_1S, yazi, firca, 470, 170);



            //ok
            Graphics grafik = pictureBox1.CreateGraphics();
            Pen cizgi = new Pen(System.Drawing.Color.Black,3);
            Pen cizgigiris1 = new Pen(System.Drawing.Color.Blue, 3);
            Pen cizgigiris2 = new Pen(System.Drawing.Color.Red, 3);
            Pen cizgie1 = new Pen(System.Drawing.Color.Green, 3);

            Point nokta1_1 = new Point(15, 38);
            Point nokta1_2 = new Point(45, 38);
            grafik.DrawLine(cizgi, nokta1_1, nokta1_2);
            Point nokta2_1 = new Point(70, 38);
            Point nokta2_2 = new Point(110, 38);
            grafik.DrawLine(cizgigiris1, nokta2_1, nokta2_2);

            //a11
            Point nokta5_1 = new Point(113, 38);
            Point nokta5_2 = new Point(240, 38);
            grafik.DrawLine(cizgigiris1, nokta5_1, nokta5_2);

            //a12
            Point nokta5_1_1 = new Point(113, 38);
            Point nokta5_1_2 = new Point(245, 205);
            grafik.DrawLine(cizgigiris1, nokta5_1_1, nokta5_1_2);

            Point nokta3_1 = new Point(15, 208);
            Point nokta3_2 = new Point(45, 208);
            grafik.DrawLine(cizgi, nokta3_1, nokta3_2);

            Point nokta4_1 = new Point(70, 208);
            Point nokta4_2 = new Point(110, 208);
            grafik.DrawLine(cizgigiris2, nokta4_1, nokta4_2);

            Point nokta12_1 = new Point(195, 300);
            Point nokta12_2 = new Point(207, 255);
            grafik.DrawLine(cizgie1, nokta12_1, nokta12_2);

            Point nokta18_1 = new Point(435, 300);
            Point nokta18_2 = new Point(447, 255);
            grafik.DrawLine(cizgie1, nokta18_1, nokta18_2);

            //a31
            Point nokta13_1 = new Point(208, 250);
            Point nokta13_2 = new Point(260, 45);
            grafik.DrawLine(cizgie1, nokta13_1, nokta13_2);


            //a61
            Point nokta19_1 = new Point(450, 250);
            Point nokta19_2 = new Point(480, 130);
            grafik.DrawLine(cizgie1, nokta19_1, nokta19_2);

            //a32
            Point nokta14_1 = new Point(212, 250);
            Point nokta14_2 = new Point(265, 215);
            grafik.DrawLine(cizgie1, nokta14_1, nokta14_2);

            //a22
            Point nokta6_1 = new Point(113, 208);
            Point nokta6_2 = new Point(240, 208);
            grafik.DrawLine(cizgigiris2, nokta6_1, nokta6_2);

            //a21
            Point nokta6_1_1 = new Point(113, 208);
            Point nokta6_2_2 = new Point(245, 45);
            grafik.DrawLine(cizgigiris2, nokta6_1_1, nokta6_2_2);

            Point nokta7_1 = new Point(285, 38);
            Point nokta7_2 = new Point(320, 38);
            grafik.DrawLine(cizgigiris1, nokta7_1, nokta7_2);

            Point nokta10_1 = new Point(285, 208);
            Point nokta10_2 = new Point(320, 208);
            grafik.DrawLine(cizgigiris2, nokta10_1, nokta10_2);

            //a41
            Point nokta8_1 = new Point(323, 38);
            Point nokta8_2 = new Point(450, 115);
            grafik.DrawLine(cizgigiris1, nokta8_1, nokta8_2);

            //a51
            Point nokta9_1 = new Point(323, 208);
            Point nokta9_2 = new Point(450, 125);
            grafik.DrawLine(cizgigiris2, nokta9_1, nokta9_2);

            
            Point nokta11_1 = new Point(495, 120);
            Point nokta11_2 = new Point(520, 120);
            grafik.DrawLine(cizgi, nokta11_1, nokta11_2);

            Point nokta15_1 = new Point(150, 315);
            Point nokta15_2 = new Point(170, 315);
            grafik.DrawLine(cizgi, nokta15_1, nokta15_2);

            Point nokta16_1 = new Point(400, 315);
            Point nokta16_2 = new Point(420, 315);
            grafik.DrawLine(cizgi, nokta16_1, nokta16_2);

              //daire
            Graphics daire = pictureBox1.CreateGraphics(); 
            Pen kalh1 = new Pen(Color.Black);
            daire.DrawEllipse(kalh1, new Rectangle(new Point(45, 25), new Size(25, 25)));
            daire.DrawEllipse(kalh1, new Rectangle(new Point(240, 25), new Size(45, 25)));
            daire.DrawEllipse(kalh1, new Rectangle(new Point(45, 195), new Size(25, 25)));
            daire.DrawEllipse(kalh1, new Rectangle(new Point(240, 195), new Size(45, 25)));
            daire.DrawEllipse(kalh1, new Rectangle(new Point(450, 107), new Size(45, 25)));


            //dikdörtgen            
            Graphics g = pictureBox1.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 30);
            g.DrawRectangle(Pens.Black, 170, 300, 50, 30);
            g.DrawRectangle(Pens.Black, 420, 300, 50, 30);
          
    
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label83_Click(object sender, EventArgs e)
        {

        }

        private void tbMK_TextChanged(object sender, EventArgs e)
        {

        }

        private void buSec110_Click(object sender, EventArgs e)
        {
           giris2 = giris1 = 1 ;
           b = 0;
           btSec000.Visible = false;
           btSec011.Visible = false;
           btSec101.Visible = false;
           buSec110.Visible = false;
           btTSH.Visible = true;
           giris1S = "1";
           giris2S = "1";
           bS = "0";
        }

        private void btSec101_Click(object sender, EventArgs e)
        {
            giris1 = b = 1;
            giris2 = 0;
            btSec000.Visible = false;
            btSec011.Visible = false;
            btSec101.Visible = false;
            buSec110.Visible = false;
            btTSH.Visible = true;
            giris1S = "1";
            giris2S = "0";
            bS = "1";
        }

        private void btSec011_Click(object sender, EventArgs e)
        {
            b = giris2 = 1;
            giris1 = 0;
            btSec000.Visible = false;
            btSec011.Visible = false;
            btSec101.Visible = false;
            buSec110.Visible = false;
            btTSH.Visible = true;
            giris1S = "0";
            giris2S = "1";
            bS = "1";

        }

        private void btSec000_Click(object sender, EventArgs e)
        {
            giris1 = b = giris2 = 0;
            btSec000.Visible = false;
            btSec011.Visible = false;
            btSec101.Visible = false;
            buSec110.Visible = false;
            btTSH.Visible = true;
            giris1S = "0";
         giris2S = "0";
        bS = "0";

        }



        private void btTSH_Click(object sender, EventArgs e)

         {
             pictureBox1.Refresh();
             a11 = float.Parse(tba11.Text);
             a12 = float.Parse(tba12.Text);
             a22 = float.Parse(tba22.Text);
             e1 = float.Parse(tbE1.Text);
             a21 = float.Parse(tba21.Text);
             e2 = float.Parse(tbE2.Text);
             a32 = float.Parse(tb32.Text);
             a31 = float.Parse(tb31.Text);
             a51 = float.Parse(tb51.Text);
             a41 = float.Parse(tb41.Text);
             a61 = float.Parse(tba61.Text);
             k = float.Parse(tbK.Text);
             mk = float.Parse(tbM.Text);
     
             double net1 = (giris1 * a11) + (giris2 * a21) + (e1 * a31);
             double net2 = (giris1 * a12) + (giris2 * a22) + (e1 * a32);
             double fNet1 = 1/(1+Math.Exp(-net1));
             double fNet2 = 1 / (1 + Math.Exp(-net2));
             double net3 = fNet1 * a41 + fNet2 * a51 + e1 * a61;
             double fNet3 = 1 / (1 + Math.Exp(-net3));


             if (Math.Abs(b - fNet3) > 0.09)
             {
                 listBox1.Items.Add("beklenen çıkış değeri=" + b.ToString() + " Çıkış değeri=" + fNet3.ToString());
                 double h = b - fNet3;
                 double sigmoid = fNet3 * (1 - fNet3) * h;
                 double deltaA41 = k * sigmoid * fNet1 + mk * giris1;
                 double deltaA51 = k * sigmoid * fNet2 + mk * giris1;
                 double deltaA61 = k * sigmoid * e1 + mk * giris1;
                  a41t = a41 + deltaA41;
                  a51t = a51 + deltaA51;
                  a61t = a61 + deltaA61;
                 double agirlik4 = fNet1 * (1 - fNet1) * sigmoid * a41;
                 double agirlik5 = fNet2 * (1 - fNet2) * sigmoid * a51;

                 double delta11 = k * agirlik4 * giris1 + mk * b;
                 double delta12 = k * agirlik4 * giris1 + mk * b;
                 double delta21 = k * agirlik5 * giris2 + mk * b;
                 double delta22 = k * agirlik5 * giris2 + mk * b;
                 double delta31 = k * agirlik4 * e1 + mk * b;
                 double delta32 = k * agirlik5 * e1 + mk * b;

                 a11= a11 + delta11;
                 a12= a12 + delta12;
                 a21= a21 + delta21;
                 a22= a22 + delta22;
                 a31= a31 + delta31;
                 a32= a32 + delta32;

                 a1_1S = tba11.Text = (a11).ToString();
                 a1_2S = tba12.Text = (a12).ToString();
                 a2_1S = tba22.Text = (a21).ToString();
                 a2_2S = tba21.Text = (a22).ToString();
                 a3_1S = tb32.Text = (a31).ToString();
                 a3_2S = tb31.Text = (a32).ToString();

                 a4_1S = tb41.Text = (a41t).ToString();
                 a5_1S = tb51.Text = (a51t).ToString();
                 a6_1S = tba61.Text = (a61t).ToString();

                

                 listBox1.Items.Add("A11=" + a11.ToString() + " A12=" + a12.ToString()+"A21=" + a21.ToString()) ;
                 listBox1.Items.Add("A22=" + a22.ToString()+"A31=" + a31.ToString() + " A32=" + a32.ToString());
                 listBox1.Items.Add("----------------------------------------------------------------------------");
                
             }
             else if (Math.Abs(b - fNet3) < 0.09)
             {
                 tba11.Text = (a11).ToString();
                 tba12.Text = (a12).ToString();
                 tba22.Text = (a21).ToString();
                 tba21.Text = (a22).ToString();
                 tb32.Text = (a31).ToString();
                 tb31.Text = (a32).ToString();

                 tb41.Text = (a41t).ToString();
                 tb51.Text = (a51t).ToString();
                 tba61.Text = (a61t).ToString();

                 a1_1S = tba11.Text = (a11).ToString();
                 a1_2S = tba12.Text = (a12).ToString();
                 a2_1S = tba22.Text = (a21).ToString();
                 a2_2S = tba21.Text = (a22).ToString();
                 a3_1S = tb32.Text = (a31).ToString();
                 a3_2S = tb31.Text = (a32).ToString();

                 a4_1S = tb41.Text = (a41t).ToString();
                 a5_1S = tb51.Text = (a51t).ToString();
                 a6_1S = tba61.Text = (a61t).ToString();

                 listBox1.Items.Add("beklenen çıkış değeri ile sonuç eşit çıkmıştır.");

     
             }
             e1S = tbE1.Text;
             e2S = tbE2.Text;
             button1_Click(new object(), new EventArgs());
            }
            
        }
    }


