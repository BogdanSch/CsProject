using Phisics;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Golf
{
    class Enemy : Ball
    {
        public PictureBox Pic { get; private set; }
        public Panel Parent { get; set; }

        private Random rnd = new Random();



        public Enemy(Image image, Panel Parent, Point location)
        {
            this.Parent = Parent;
            Pic = CreateBall(image, location);
            Pic.Location = location;
            R = new Vector(location);
            V = new Vector(9, 9);
            Radius = 20;
            A = new Vector(9, 9);
            M = 1;
        }

        PictureBox CreateBall(Image image, Point location)
        {
            PictureBox pb = new PictureBox();
            pb.Location = location;
            pb.Size = new Size(rnd.Next(70, 100), rnd.Next(70, 100));
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Image = image;
            Parent.Controls.Add(pb);
            return pb;
        }

        public override void Move(double dt, Vector F)
        {
            base.Move(dt, F);
            Pic.Location = new Point((int)(R.GetPoint().X - Radius), (int)(R.GetPoint().Y - Radius));
        }

        public void Clear()
        {
            Parent.Controls.Remove(Pic);
        }
    }
}
