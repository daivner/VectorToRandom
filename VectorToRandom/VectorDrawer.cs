using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorToRandom {
    public partial class VectorDrawer : UserControl {

        Point startPoint;
        DateTime startDateTime;

        List<Vector> vectorList;
        Graphics g;

        public VectorDrawer() {
            InitializeComponent();
            vectorList = new List<Vector>();
            g = this.CreateGraphics();
        }

        private void VectorDrawer_MouseDown(object sender, MouseEventArgs e) {
            startPoint = e.Location;
            startDateTime = DateTime.Now;
        }

        private void VectorDrawer_MouseClick(object sender, MouseEventArgs e) {
            if (startPoint.X != e.X || startPoint.Y != e.Y) {
                vectorList.Clear();
                vectorList.Add(new Vector(startPoint, e.Location, DateTime.Now.Subtract(startDateTime).TotalMilliseconds));
                DrawPoints();
                timer1.Interval = 1;
                timer1.Enabled = true;
            }

        }


        private void DrawPoints() {
            //g.Clear(Color.FromArgb(64, 64, 64));
            //g.DrawLine(new Pen(Brushes.Red), vectorList[0].StartPoint, vectorList[0].EndPoint);
            //g.DrawRectangle(new Pen(Brushes.Blue), new Rectangle(vectorList[0].StartPoint, new Size(5, 5)));

            //g.DrawString(vectorList[0].angle.ToString(), new Font("Arial", 10), Brushes.White, 30, 30);
            //g.DrawString(vectorList[0].StartPoint.ToString(), new Font("Arial", 10), Brushes.White, 30, 45);
            //g.DrawString(vectorList[0].EndPoint.ToString(), new Font("Arial", 10), Brushes.White, 30, 60);
            //g.DrawString(vectorList[0].timeMS.ToString(), new Font("Arial", 10), Brushes.White, 30, 75);
            //g.DrawString(vectorList[0].speed.ToString(), new Font("Arial", 10), Brushes.White, 30, 90);
            //g.DrawString(vectorList[0].Points[vectorList[0].Points.Count - 1].ToString(), new Font("Arial", 10), Brushes.White, 30, 105);


            //g.DrawRectangle(new Pen(Brushes.Blue), new Rectangle(Width - 60, Height - 60, 5, 5));
            //g.DrawLine(new Pen(Brushes.Red), Width - 60, Height - 60, (float)(Width - 60) + (float)(15 * Math.Cos(vectorList[0].angle / (double)180 * Math.PI)), (float)(Height - 60) + (float)(15 * Math.Sin(vectorList[0].angle / (double)180 * Math.PI)));

            //for (int i = 0; i < vectorList[0].Points.Count; i++) {
            //    g.DrawRectangle(new Pen(Brushes.Yellow), new Rectangle((int)vectorList[0].Points[i].X, (int)vectorList[0].Points[i].Y, 3, 3));
            //}

            g.DrawRectangle(new Pen(Brushes.Yellow), new Rectangle((int)vectorList[0].Points[vectorList[0].Points.Count - 1].X, (int)vectorList[0].Points[vectorList[0].Points.Count - 1].Y, 1, 1));

        }

        private void VectorDrawer_SizeChanged(object sender, EventArgs e) {
            g = this.CreateGraphics();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (vectorList[0].Points.Count == 1000)
                vectorList[0].Points.RemoveAt(0);
            vectorList[0].Points.Add(vectorList[0].calcNextPoint(this.Height, this.Width));
            Console.WriteLine(vectorList[0].Points[vectorList[0].Points.Count - 1].ToString());
            DrawPoints();
        }

        private void button1_Click(object sender, EventArgs e) {
            vectorList.Clear();
            vectorList.Add(new Vector(new Point(210, 250), new Point(10, 50), DateTime.Now.Subtract(startDateTime).TotalMilliseconds));
            DrawPoints();
            timer1.Interval = 1;
            timer1.Enabled = true;
        }
    }


    class Vector {

        Point startPoint, endPoint;
        PointF actualPoint, nextPointOffcet;
        List<PointF> points = new List<PointF>();
        public double timeMS, angle, speed;

        public Vector(Point startPoint, Point endPoint, double timeMS) {
            this.timeMS = timeMS;
            this.startPoint = startPoint;
            this.endPoint = endPoint;
            this.actualPoint = endPoint;

            angle = (Math.Atan((((double)endPoint.Y - (double)startPoint.Y)) / ((double)endPoint.X - (double)startPoint.X)) / Math.PI) * (double)180;

            if (startPoint.X > endPoint.X) { angle += 180; } else if (startPoint.Y > endPoint.Y && startPoint.X <= endPoint.X) { angle += 360; }

            speed = Math.Sqrt(Math.Pow(Math.Abs(startPoint.X) - Math.Abs(endPoint.X), 2) + Math.Pow(Math.Abs(startPoint.Y) - Math.Abs(endPoint.Y), 2)) / timeMS;

            nextPointOffcet = new PointF(endPoint.X - startPoint.X, endPoint.Y - startPoint.Y);

            points.Add(startPoint);
            points.Add(endPoint);
        }

        public PointF calcNextPoint(int height, int width) {
            if (points[points.Count - 1].X + nextPointOffcet.X <= width) {
                if (points[points.Count - 1].X + nextPointOffcet.X >= 0) {
                    if (points[points.Count - 1].Y + nextPointOffcet.Y <= height) {
                        if (points[points.Count - 1].Y + nextPointOffcet.Y >= 0) {
                            return new PointF(points[points.Count - 1].X + nextPointOffcet.X, points[points.Count - 1].Y + nextPointOffcet.Y); //base DONE
                        } else {
                            nextPointOffcet = new PointF(nextPointOffcet.X, nextPointOffcet.Y * -1);
                            return new PointF(points[points.Count - 1].X + nextPointOffcet.X, (points[points.Count - 1].Y + (nextPointOffcet.Y * -1)) * -1); //colition on top Done
                        }
                    } else {
                        nextPointOffcet = new PointF(nextPointOffcet.X, nextPointOffcet.Y * -1);
                        return new PointF(points[points.Count - 1].X + nextPointOffcet.X, height - ((points[points.Count - 1].Y + (nextPointOffcet.Y * -1)) - height)); //colition on bottom DONE
                    }
                } else {
                    if (points[points.Count - 1].Y + nextPointOffcet.Y <= height) {
                        if (points[points.Count - 1].Y + nextPointOffcet.Y >= 0) {
                            nextPointOffcet = new PointF(nextPointOffcet.X * -1, nextPointOffcet.Y);
                            return new PointF((points[points.Count - 1].X + (nextPointOffcet.X * -1)) * -1, points[points.Count - 1].Y + nextPointOffcet.Y); //colition on left Done
                        } else {
                            nextPointOffcet = new PointF(nextPointOffcet.X * -1, nextPointOffcet.Y * -1);
                            Console.Write("A");
                            return new PointF((points[points.Count - 1].X + (nextPointOffcet.X * -1)) * -1, (points[points.Count - 1].Y + (nextPointOffcet.Y * -1)) * -1); //colition on top and left DONE
                        }
                    } else {
                        Console.Write("B");
                        return new PointF((points[points.Count - 1].X + (nextPointOffcet.X * -1)) * -1, height - ((points[points.Count - 1].Y + (nextPointOffcet.Y * -1)) - height)); //colition on bottom and left TODO
                    }
                }
            } else {
                if (points[points.Count - 1].X + nextPointOffcet.X >= 0) {
                    if (points[points.Count - 1].Y + nextPointOffcet.Y <= height) {
                        if (points[points.Count - 1].Y + nextPointOffcet.Y >= 0) {
                            nextPointOffcet = new PointF(nextPointOffcet.X * -1, nextPointOffcet.Y);
                            return new PointF(width - ((points[points.Count - 1].X + (nextPointOffcet.X * -1)) - width), points[points.Count - 1].Y + nextPointOffcet.Y); //colition on right DONE
                        } else {
                            nextPointOffcet = new PointF(nextPointOffcet.X, nextPointOffcet.Y * -1);
                            Console.Write("C");
                            return new PointF(width - ((points[points.Count - 1].X + (nextPointOffcet.X * -1)) - width), (points[points.Count - 1].Y + (nextPointOffcet.Y * -1)) * -1); //colition on top right TODO
                        }
                    } else {
                        nextPointOffcet = new PointF(nextPointOffcet.X, nextPointOffcet.Y * -1);
                        Console.Write("D");
                        return new PointF(width - ((points[points.Count - 1].X + (nextPointOffcet.X * -1)) - width), height - ((points[points.Count - 1].Y + (nextPointOffcet.Y * -1)) - height)); //colition on bottom RIGHT TODO
                    }
                }
            }

            return new PointF(0, 0);
        }

        public List<PointF> Points {
            get { return points; }
        }

        public Point StartPoint {
            get { return startPoint; }
        }

        public Point EndPoint {
            get { return endPoint; }
        }
    }
}

