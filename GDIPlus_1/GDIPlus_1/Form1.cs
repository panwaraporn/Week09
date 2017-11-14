using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GDIPlus_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            GraphicsPath gp = new GraphicsPath();

            //Pen pen = new Pen(Color.Green, 2);
            //  Point[] pt = { new Point(20,200),new Point(50,20),
            gp.AddCurve(new Point[] {
                new Point(100, 50),
                new Point(105, 40),
                new Point(120,40),
                new Point(130,65),
                new Point(100,100)
            }, 0.5f);
            gp.AddCurve(new Point[] {
                new Point(100, 100),
                new Point(70, 65),
                new Point(80,40),
                new Point(95,40),
                new Point(100,50)
            }, 0.5f);
            // new Point(100,100),new Point(150,230),
            // new Point(200,200)};
            // g.DrawCurve(pen, pt);
            g.DrawPath(new Pen(Color.Red, 3), gp);
            g.Dispose();
        }

           // for (int i = 0; i < 11; i++)
        //    {
         //       objPen[i] = new Pen(Color.Blue, 9);
         //   }

         //   objPen[0].EndCap = LineCap.AnchorMask;
        //    objPen[1].EndCap = LineCap.ArrowAnchor;
          //  objPen[2].EndCap = LineCap.Custom;
          //  objPen[3].EndCap = LineCap.DiamondAnchor;
         //   objPen[4].EndCap = LineCap.Flat;
         //   objPen[5].EndCap = LineCap.NoAnchor;
          //  objPen[6].EndCap = LineCap.Round;
         //   objPen[7].EndCap = LineCap.RoundAnchor;
          //  objPen[8].EndCap = LineCap.Square;
         //   objPen[9].EndCap = LineCap.SquareAnchor;
         //   objPen[10].EndCap = LineCap.Triangle;

         //   for (int i = 0; i < 11; i++)
         //   {
         //       g.DrawLine(objPen[i], 10, 10 + 20 * i, 200, 10 + 20 * i);
         //       objPen[i].Dispose();
         //   }
         //   g.Dispose();
   //     }



           // Pen pen = new Pen(Color.Green, 2);
           //  pen.DashStyle = DashStyle.DashDot;
           //  Point point1 = new Point(100, 100);
           //   Point point2 = new Point(200, 200);
           //   e.Graphics.DrawLine(pen, 10,80,220,80);
           //   pen.Dispose();
           //  pen = new Pen(Brushes.DeepSkyBlue, 4);
           //  e.Graphics.DrawLine(pen, 10, 120, 220, 120);
           //   pen.Dispose();

            //   HatchBrush mybrush = new HatchBrush(HatchStyle.DarkVertical, Color.White, Color.Violet);
            //  Pen mypen = new Pen(mybrush,5);
            //   g.DrawRectangle(mypen, 10, 10, 200, 200);
            // mypen.Width = 4;
            // mypen.Color = Color.Pink;
            // g.DrawEllipse(mypen, 10, 10, 200, 200);
            //  mypen.Dispose();
            //  mybrush.Dispose();

            //       Pen somepen = new Pen(Color.FromArgb(255, 120, 200));
            //     g.DrawEllipse(somepen, 20, 20, 200, 200);
            //     somepen.Dispose();

            //     Color col = Color.FromName("LightGreen");
            //     this.BackColor = col;

        }
    }

