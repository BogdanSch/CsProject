using Phisics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golf
{
    class GolfBall : Ball
    {
        PictureBox Pic { get; set; }

        public bool IsAlive { get; set; } = true;

        public Panel Parent { get; set; }

        

        public GolfBall(Image image, Panel Parent, Point location)
        {
            Radius = 25;
            R = new Vector(location.X + Radius,
            location.Y + Radius);
            M = 1;
            V = new Vector(0, 1);
            A = new Vector(1, 2);
            this.Parent = Parent;
            Pic = CreateBall(image, location);
        }

        PictureBox CreateBall(Image image, Point location)
        {
            PictureBox pb = new PictureBox();
            pb.Location = location;
            pb.Size = new Size((int)Radius * 2, (int)Radius * 2);
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
    }
}
