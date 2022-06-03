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
        Color pointColor = Color.FromArgb(255, 255, 254);

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
                vectorList.Add(new Vector(new PointD(startPoint), new PointD(e.Location), DateTime.Now.Subtract(startDateTime).TotalMilliseconds, this.Width, this.Height));
            } 
        }


        private void DrawPoints() {
            g.Clear(Color.FromArgb(64, 64, 64));
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

            pointColor = updateColor(pointColor);

            for (int i = 0; i < vectorList.Count; i++) {
                for (int j = 0; j < vectorList[i].Points.Count; j++) {
                    g.DrawRectangle(new Pen(pointColor), new Rectangle((int)vectorList[i].Points[j].X, (int)vectorList[i].Points[j].Y, 1, 1));
                }
            }

            

            //g.DrawRectangle(new Pen(pointColor), new Rectangle((int)vectorList[0].Points[vectorList[0].Points.Count - 1].X, (int)vectorList[0].Points[vectorList[0].Points.Count - 1].Y, 1, 1));

        }

        private void VectorDrawer_SizeChanged(object sender, EventArgs e) {
            g = this.CreateGraphics();
        }

        private Color updateColor(Color c) {
            if (c.R == 255 && c.G == 255) {
                if (c.B == 254) {
                    return Color.FromArgb(0, 255, 255);
                } else {
                    return Color.FromArgb(255, 255, c.B + 1);
                }
            } else if (c.G == 255 && c.B == 255) {
                if (c.R == 254) {
                    return Color.FromArgb(255, 0, 255);
                } else {
                    return Color.FromArgb(c.R + 1, 255, 255);
                }
            } else if (c.R == 255 && c.B == 255) {
                if (c.G == 254) {
                    return Color.FromArgb(255, 255, 0);
                } else {
                    return Color.FromArgb(255, c.G + 1, 255);
                }
            } else {
                return c;
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {

            for (int i = 0; i < vectorList.Count; i++) {
                vectorList[i].calcNextPoint();
            }

            DrawPoints();

        }

        private void button1_Click(object sender, EventArgs e) {
            vectorList.Clear();

            //test A
            //vectorList.Add(new Vector(new Point(210, 250), new Point(10, 50), DateTime.Now.Subtract(startDateTime).TotalMilliseconds));

            //506, 265, 520, 226 nice patetn
            vectorList.Add(new Vector(new PointD(506, 265), new PointD(520, 226), 327, this.Width, this.Height));


            DrawPoints();
            timer1.Interval = 1;
            timer1.Enabled = true;
        }
    }


    class Vector {

        PointD startPoint, endPoint;
        PointD actualPoint, nextPointOffcet;
        List<PointD> points = new List<PointD>();
        public double width, height, timeMS, initialAngle, speed;

        const int MaxElemtns = 10;

        public Vector(PointD startPoint, PointD endPoint, double timeMS, double width, double height) {
            this.startPoint = startPoint;
            this.endPoint = endPoint;
            this.actualPoint = endPoint;

            this.timeMS = timeMS;
            this.width = width;
            this.height = height;

            initialAngle = (Math.Atan((((double)endPoint.Y - (double)startPoint.Y)) / ((double)endPoint.X - (double)startPoint.X)) / Math.PI) * (double)180;

            if (startPoint.X > endPoint.X) { initialAngle += 180; } else if (startPoint.Y > endPoint.Y && startPoint.X <= endPoint.X) { initialAngle += 360; }

            speed = Math.Sqrt(Math.Pow(Math.Abs(startPoint.X) - Math.Abs(endPoint.X), 2) + Math.Pow(Math.Abs(startPoint.Y) - Math.Abs(endPoint.Y), 2)) / timeMS;

            nextPointOffcet = new PointD(endPoint.X - startPoint.X, endPoint.Y - startPoint.Y);
            nextPointOffcet = new PointD(nextPointOffcet.X / speed, nextPointOffcet.Y / speed);

            points.Add(startPoint);
            points.Add(endPoint);
        }

        public PointD calcNextPoint() {
            if (points.Count == MaxElemtns)
                points.RemoveAt(0);

            if (points[points.Count - 1].X + nextPointOffcet.X <= width) {
                if (points[points.Count - 1].X + nextPointOffcet.X >= 0) {
                    if (points[points.Count - 1].Y + nextPointOffcet.Y <= height) {
                        if (points[points.Count - 1].Y + nextPointOffcet.Y >= 0) {
                            //Normal DONE
                            actualPoint = new PointD(points[points.Count - 1].X + nextPointOffcet.X, points[points.Count - 1].Y + nextPointOffcet.Y);
                            points.Add(actualPoint);
                            return actualPoint;
                        } else {
                            //Colition Top DONE
                            nextPointOffcet = new PointD(nextPointOffcet.X, nextPointOffcet.Y * -1);
                            actualPoint = new PointD(points[points.Count - 1].X + nextPointOffcet.X, (points[points.Count - 1].Y + (nextPointOffcet.Y * -1)) * -1); ;
                            points.Add(actualPoint);
                            return actualPoint;
                        }
                    } else {
                        //Colition Bottom DONE
                        nextPointOffcet = new PointD(nextPointOffcet.X, nextPointOffcet.Y * -1);
                        actualPoint = new PointD(points[points.Count - 1].X + nextPointOffcet.X, height - ((points[points.Count - 1].Y + (nextPointOffcet.Y * -1)) - height));
                        points.Add(actualPoint);
                        return actualPoint;
                    }
                } else {
                    if (points[points.Count - 1].Y + nextPointOffcet.Y <= height) {
                        if (points[points.Count - 1].Y + nextPointOffcet.Y >= 0) {
                            //Colition Left Done
                            nextPointOffcet = new PointD(nextPointOffcet.X * -1, nextPointOffcet.Y);
                            actualPoint = new PointD((points[points.Count - 1].X + (nextPointOffcet.X * -1)) * -1, points[points.Count - 1].Y + nextPointOffcet.Y);
                            return actualPoint;
                        } else {
                            //Colition Top Left DONE
                            Console.Write("A");
                            nextPointOffcet = new PointD(nextPointOffcet.X * -1, nextPointOffcet.Y * -1);
                            actualPoint = new PointD((points[points.Count - 1].X + (nextPointOffcet.X * -1)) * -1, (points[points.Count - 1].Y + (nextPointOffcet.Y * -1)) * -1);
                            points.Add(actualPoint);
                            return actualPoint;
                        }
                    } else {
                        //Colition Bottom Left DEBUG
                        Console.Write("B");
                        nextPointOffcet = new PointD(nextPointOffcet.X * -1, nextPointOffcet.Y * -1);
                        actualPoint = new PointD((points[points.Count - 1].X + (nextPointOffcet.X * -1)) * -1, height - ((points[points.Count - 1].Y + (nextPointOffcet.Y * -1)) - height));
                        points.Add(actualPoint);
                        return actualPoint;
                    }
                }
            } else {
                if (points[points.Count - 1].X + nextPointOffcet.X >= 0) {
                    if (points[points.Count - 1].Y + nextPointOffcet.Y <= height) {
                        if (points[points.Count - 1].Y + nextPointOffcet.Y >= 0) {
                            //Colition Right DONE
                            nextPointOffcet = new PointD(nextPointOffcet.X * -1, nextPointOffcet.Y);
                            actualPoint = new PointD(width - ((points[points.Count - 1].X + (nextPointOffcet.X * -1)) - width), points[points.Count - 1].Y + nextPointOffcet.Y);
                            points.Add(actualPoint);
                            return actualPoint;
                        } else {
                            //Colition Top Right DEBUG
                            Console.Write("C");
                            nextPointOffcet = new PointD(nextPointOffcet.X * -1, nextPointOffcet.Y * -1);
                            actualPoint = new PointD(width - ((points[points.Count - 1].X + (nextPointOffcet.X * -1)) - width), (points[points.Count - 1].Y + (nextPointOffcet.Y * -1)) * -1);
                            points.Add(actualPoint);
                            return actualPoint;
                        }
                    } else {
                        //Colition Bottom Right TODO
                        Console.Write("D");
                        nextPointOffcet = new PointD(nextPointOffcet.X * -1, nextPointOffcet.Y * -1);
                        actualPoint = new PointD(width - ((points[points.Count - 1].X + (nextPointOffcet.X * -1)) - width), height - ((points[points.Count - 1].Y + (nextPointOffcet.Y * -1)) - height));
                        points.Add(actualPoint);
                        return actualPoint;
                    }
                }
            }

            return new PointD(0, 0);
        }

        public string toString() {
            return 
                "{StartP=" + startPoint + ", EndP=" + endPoint + ", ActualP=" + actualPoint + 
                ", NextPO=" + nextPointOffcet + ", Width=" + width + ", Height=" + height + 
                ", TimeMS=" + timeMS + " InitialAngle=" + initialAngle + ", Speed=" + speed + "}";
        }

        public List<PointD> Points {
            get { return points; }
        }

        public PointD StartPoint {
            get { return startPoint; }
        }

        public PointD EndPoint {
            get { return endPoint; }
        }

        public PointD ActualPoint {
            get { return actualPoint; }
        }

        public PointD NextPointOffcet {
            get { return nextPointOffcet; }
        }

        public double InitialAngle { 
            get { return initialAngle; }
        }

        public double Speed { 
            get { return speed; }
        }

        public double TimeMs {
            get { return timeMS; }
        }

    }

    class PointD {

        double x, y;

        public PointD(double x, double y) {
            this.x = x;
            this.y = y;
        }

        public PointD(float x, float y) {
            this.x = x;
            this.y = y;
        }

        public PointD(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public PointD(PointF p) {
            x = p.X;
            y = p.Y;
        }

        public PointD(Point p) {
            x = p.X;
            y = p.Y;
        }

        public double X {
            get { return x; }
            set { x = value; }
        }

        public double Y {
            get { return y; }
            set { y = value; }
        }

        public PointF toPointF() {
            return new PointF((float)x, (float)(y));
        }

        public Point toPoint() {
            return new Point((int)x, (int)(y));
        }

        public string toString() {
            return "{X=" + x.ToString() + ", Y=" + y.ToString() + "}";
        }

        public bool equals(PointD other) { 
            return x == other.x && y == other.y;
        }

    }
}

