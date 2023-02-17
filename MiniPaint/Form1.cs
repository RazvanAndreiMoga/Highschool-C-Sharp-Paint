using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Collections.Generic;
using System.IO;
using System.Windows.Markup;
using System.Windows.Input;

namespace MiniPaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = pnl_Draw.CreateGraphics();
        }
        Point start;
        Point end;
        int k=0;
        bool startPaint = false;
        Graphics g;
        //nullable int for storing Null value
        int? initX = null;
        int? initY = null;
        bool drawPie = false;
        bool drawRectangle = false;
        bool drawCircle = false;
        bool drawArc = false;
        bool drawBezier = false;
        bool drawPolygon = false;
        bool fillSquare = false;
        bool fillRect = false;
        bool fillCircle = false;
        bool fillPie = false;
        bool fillPoly = false;
        
        private List<Point> polygonPoints = new List<Point>();
        //Event fired when the mouse pointer is moved over the Panel(pnl_Draw).
        /* private void pnl_Draw_MouseMove(object sender, MouseEventArgs e)
         {
             if (e.LeftButton == MouseButtonState.Pressed)
             {
                 end = e.Location(this);
             }
         }*/

        //Event Fired when the mouse pointer is over Panel and a mouse button is pressed
        private void pnl_Draw_MouseMove(object sender, MouseEventArgs e)
        {
            if (startPaint)
            {
                //Setting the Pen BackColor and line Width
                Pen p = new Pen(btn_PenColor.BackColor, float.Parse(cmb_PenSize.Text));
                //Drawing the line.
                g.DrawLine(p, new Point(initX ?? e.X, initY ?? e.Y), new Point(e.X, e.Y));
                initX = e.X;
                initY = e.Y;
            }
        }
        private void pnl_Draw_MouseDown(object sender, MouseEventArgs e)
        {

                startPaint = true;
                k++;
            if (k % 2 != 0)
                start = e.Location;
            else
            {

                end = e.Location;
                if (drawRectangle)
                {
                    startPaint = false;
                    Pen pen = new Pen(btn_PenColor.BackColor);
                    g.DrawRectangle(pen, DrawRectangle());

                }
                if (drawCircle)
                {
                    startPaint = false;
                    Pen pen = new Pen(btn_PenColor.BackColor);
                    g.DrawEllipse(pen, DrawRectangle());


                }
                if (drawPie)
                {
                    startPaint = false;
                    Pen pen = new Pen(btn_PenColor.BackColor);
                    g.DrawPie(pen, DrawRectangle(), float.Parse(textBox_Start.Text), float.Parse(textBox_sweep.Text));
                }

                if (drawPolygon)
                {
                    startPaint = false;
                    Pen pen = new Pen(btn_PenColor.BackColor);
                    // See if we are already drawing a polygon.
                    switch (e.Button)
                    {
                        case MouseButtons.Left:
                            //draw line
                            polygonPoints.Add(new Point(e.X, e.Y));
                            if (polygonPoints.Count > 1)
                            {
                                //draw line
                                g.DrawLine(pen, polygonPoints[polygonPoints.Count - 2], polygonPoints[polygonPoints.Count - 1]);
                            }
                            break;

                        case MouseButtons.Right:
                            //finish polygon
                            if (polygonPoints.Count > 2)
                            {
                                //draw last line
                                g.DrawLine(pen, polygonPoints[polygonPoints.Count - 1], polygonPoints[0]);
                                polygonPoints.Clear();
                            }
                            break;
                    }
                   

                }
                if (drawArc)
                {
                    startPaint = false;
                    Pen pen = new Pen(btn_PenColor.BackColor);
                    g.DrawArc(pen, DrawRectangle(), float.Parse(textBox_Start.Text), float.Parse(textBox_sweep.Text));
                }
                if (fillCircle)
                {
                    startPaint = false;
                    SolidBrush sb = new SolidBrush(btn_PenColor.BackColor);
                    g.FillEllipse(sb, e.X, e.Y, int.Parse(txt_ShapeSize.Text), int.Parse(txt_ShapeSize.Text));
                    fillCircle = false;
                }
                if (fillPie)
                {
                    startPaint = false;
                    SolidBrush sb = new SolidBrush(btn_PenColor.BackColor);
                    g.FillPie(sb, DrawRectangle(), float.Parse(textBox_Start.Text), float.Parse(textBox_sweep.Text));
                    fillPie = false;
                }
                if (fillSquare)
                {
                    startPaint = false;
                    SolidBrush sb = new SolidBrush(btn_PenColor.BackColor);
                    g.FillRectangle(sb, e.X, e.Y, int.Parse(txt_ShapeSize.Text), int.Parse(txt_ShapeSize.Text));
                    fillSquare = false;
                }
                if (fillRect)
                {
                    startPaint = false;
                    SolidBrush sb = new SolidBrush(btn_PenColor.BackColor);
                    g.FillRectangle(sb, e.X, e.Y, 2 * int.Parse(txt_ShapeSize.Text), int.Parse(txt_ShapeSize.Text));
                    fillRect = false;
                }
                if(fillCircle)
                {
                    startPaint = false;
                    SolidBrush sb = new SolidBrush(btn_PenColor.BackColor);
                    g.FillEllipse(sb, e.X, e.Y, int.Parse(txt_ShapeSize.Text), int.Parse(txt_ShapeSize.Text));
                    fillCircle = false;
                }
            }

            

            /* if (drawPolygon)
             {
                 startPaint = false;
                 Pen pen = new Pen(btn_PenColor.BackColor);
                 Point point1 = new Point(e.X, e.Y);
                 Point point2 = new Point(e.X, e.Y);
                 Point point3 = new Point(e.X, e.Y);
                 Point point4 = new Point(e.X, e.Y);
                 Point point5 = new Point(e.X, e.Y);
                 Point point6 = new Point(e.X, e.Y);
                 Point point7 = new Point(e.X, e.Y);
                 Point[] curvePoints =
                          {
                          point1,
                          point2,
                          point3,
                          point4,
                          point5,
                          point6,
                          point7
                          };
                 g.DrawPolygon(pen, curvePoints);
             }  */
        }
        
        //Fired when the mouse pointer is over the pnl_Draw and a mouse button is released.
        private void pnl_Draw_MouseUp(object sender, MouseEventArgs e)
        {
            startPaint = false;
            initX = null;
            initY = null;
        }
        //Button for Setting pen Color
        private void button1_Click(object sender, EventArgs e)
        {
            //Open Color Dialog and Set BackColor of btn_PenColor if user click on OK
            ColorDialog c = new ColorDialog();
            if(c.ShowDialog()==DialogResult.OK)
            {
                btn_PenColor.BackColor = c.Color;
            }
        }
        //New 
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clearing the graphics from the Panel(pnl_Draw)
            g.Clear(pnl_Draw.BackColor);
            //Setting the BackColor of pnl_draw and btn_CanvasColor to White on Clicking New under File Menu
            pnl_Draw.BackColor = Color.White;
            btn_CanvasColor.BackColor = Color.White;
        }
       //Setting the Canvas Color
        private void btn_CanvasColor_Click_1(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if(c.ShowDialog()==DialogResult.OK)
            {
                pnl_Draw.BackColor = c.Color;
                btn_CanvasColor.BackColor = c.Color;
            }
        }

    

        private void btn_Rectangle_Click(object sender, EventArgs e)
        {
            drawPie = false;
            drawRectangle = true;
            drawCircle = false;
            drawBezier = false;
            drawArc = false;
            drawPolygon = false;
            fillSquare = false;
            fillPoly = false;
            fillCircle = false;
            fillPie = false;
            fillRect = false;
        }

        private void btn_Circle_Click(object sender, EventArgs e)
        {
            drawPie = false;
            drawRectangle = false;
            drawCircle = true;
            drawBezier = false;
            drawArc = false;
            drawPolygon = false;
            fillSquare = false;
            fillPoly = false;
            fillCircle = false;
            fillPie = false;
            fillRect = false;
        }
        //Exit under File Menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to Exit?","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //About under Help Menu
        private void aboutMiniPaintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.ShowDialog();
        }

        private void pnl_Draw_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmb_PenSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_ShapeSize_TextChanged(object sender, EventArgs e)
        {

        }
    /*    private void DrawEllipse()
        {
            Cir newEllipse = new Ellipse()
            {
                Stroke = Brushes.Green,
                Fill = Brushes.Red,
                StrokeThickness = 4,
                Height = 10,
                Width = 10
            };

            // If the user the user tries to draw from
            // any direction then down and to the right
            // you'll get an error unless you use if
            // to change Left & TopProperty and Height
            // and Width accordingly

            if (end.X >= start.X)
            {
                // Defines the left part of the ellipse
                newEllipse.SetValue(Canvas.LeftProperty, start.X);
                newEllipse.Width = end.X - start.X;
            }
            else
            {
                newEllipse.SetValue(Canvas.LeftProperty, end.X);
                newEllipse.Width = start.X - end.X;
            }

            if (end.Y >= start.Y)
            {
                // Defines the top part of the ellipse
                newEllipse.SetValue(Canvas.TopProperty, start.Y - 50);
                newEllipse.Height = end.Y - start.Y;
            }
            else
            {
                newEllipse.SetValue(Canvas.TopProperty, end.Y - 50);
                newEllipse.Height = start.Y - end.Y;
            }

         //   MyCanvas.Children.Add(newEllipse);
        }*/
        private Rectangle DrawRectangle()
        {
            Rectangle newRectangle = new Rectangle()
            {
                //Stroke = Brushes.Orange,
               // Fill = Brushes.Blue,
                //StrokeThickness = 4
            };

            if (end.X >= start.X)
            {
                // Defines the left part of the rectangle
                newRectangle.X = start.X;
                newRectangle.Width = end.X - start.X;
            }
            else
            {
                newRectangle.X= end.X;
                newRectangle.Width = start.X - end.X;
            }

            if (end.Y >= start.Y)
            {
                // Defines the top part of the rectangle
                newRectangle.Y= start.Y;
                newRectangle.Height = end.Y - start.Y;
            }
            else
            {
                newRectangle.Y= end.Y;
                newRectangle.Height = start.Y - end.Y;
            }

            return newRectangle;

         //   pnl_Draw. .Add(newRectangle);
        }

       private void btn_Line_Click(object sender, EventArgs e)
        {
           /* if (!startPaint)
                startPaint = true;
            else
                startPaint = false;*/
        }

        private void btn_Pie_Click(object sender, EventArgs e)
        {
            drawPie = true;
            drawRectangle = false;
            drawCircle = false;
            drawBezier = false;
            drawArc = false;
            drawPolygon = false;
            fillSquare = false;
            fillPoly = false;
            fillCircle = false;
            fillPie = false;
            fillRect = false;
        }
        private void textBox_Start_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_Polygon_Click(object sender, EventArgs e)
        {
            drawPie = false;
            drawRectangle = false;
            drawCircle = false;
            drawBezier = false;
            drawArc = false;
            drawPolygon = true;
            fillSquare = false;
            fillPoly = false;
            fillCircle = false;
            fillPie = false;
            fillRect = false;
        }

   

        private void btn_Arc_Click(object sender, EventArgs e)
        {
            drawPie = false;
            drawRectangle = false;
            drawCircle = false;
            drawBezier = false;
            drawArc = true;
            drawPolygon = false;       
            fillSquare = false;
            fillPoly = false;
            fillCircle = false;
            fillPie = false;
            fillRect = false;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            g.Clear(pnl_Draw.BackColor);
            drawPie = false;
            drawRectangle = false;
            drawCircle = false;
            drawBezier = false;
            drawArc = false;
            drawPolygon = false;
            fillSquare = false;
            fillPoly = false;
            fillCircle = false;
            fillPie = false;
            fillRect = false;

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_fillSquare_Click(object sender, EventArgs e)
        {
            drawPie = false;
            drawRectangle = false;
            drawCircle = false;
            drawBezier = false;
            drawArc = false;
            drawPolygon = false;
            fillSquare = true;
            fillPoly = false;
            fillCircle = false;
            fillPie = false;
            fillRect = false;
        }

        private void btn_fillPoly_Click(object sender, EventArgs e)
        {
            drawPie = false;
            drawRectangle = false;
            drawCircle = false;
            drawBezier = false;
            drawArc = false;
            drawPolygon = false;
            fillSquare = false;
            fillPoly = true;
            fillCircle = false;
            fillPie = false;
            fillRect = false;
        }

        private void btn_fillRect_Click(object sender, EventArgs e)
        {
            drawPie = false;
            drawRectangle = false;
            drawCircle = false;
            drawBezier = false;
            drawArc = false;
            drawPolygon = false;
            fillSquare = false;
            fillPoly = false;
            fillCircle = false;
            fillPie = false;
            fillRect = true;
        }

        private void btn_fillCircle_Click(object sender, EventArgs e)
        {
            drawPie = false;
            drawRectangle = false;
            drawCircle = false;
            drawBezier = false;
            drawArc = false;
            drawPolygon = false;
            fillSquare = false;
            fillPoly = false;
            fillCircle = true;
            fillPie = false;
            fillRect = false;
        }

        private void btn_fillPie_Click(object sender, EventArgs e)
        {
            drawPie = false;
            drawRectangle = false;
            drawCircle = false;
            drawBezier = false;
            drawArc = false;
            drawPolygon = false;
            fillSquare = false;
            fillPoly = false;
            fillCircle = false;
            fillPie = true;
            fillRect = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

