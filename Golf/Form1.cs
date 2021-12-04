using Phisics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Golf
{
    public partial class Golf : Form
    {
        private bool inGame = false;
        private double max = 400;
        private GolfBall ball, target;
        private Vector startPosition;
        private Random rnd = new Random();
        private List<Enemy> enemys = new List<Enemy>();
        private int count = 0;

        public Golf()
        {
            InitializeComponent();
            startPosition = new Vector(pField.Width / 8, pField.Height / 2);
        }

        void CreateEnemys()
        {
            int numofEnemys = rnd.Next(0, 10);
            enemys = new List<Enemy>();
            for (int i = 0; i < numofEnemys; i++)
            {
                enemys.Add(
                    new Enemy(
                        pSampleEnemy.Image,
                        pField,
                        new Point(rnd.Next(pField.Width / 2, pField.Width - 150),
                        rnd.Next(pField.Height / 2, pField.Height - 100)))
                );
            }
        }

        async void bStart_Click(object sender, EventArgs e)
        {
            if (inGame) return;
            lStartCount.Visible = true;
            lCount.Visible = true;
            for (int i = 3; i >= 1; i--)
            {
                lStartCount.Text = i.ToString();
                await Task.Delay(1000);
            }

            lStartCount.Visible = false;
            inGame = true;
            lStats.Visible = false;


            ball = new GolfBall(pSample.Image, pField, startPosition.GetPoint());
            target = new GolfBall(pTarget.Image, pField, pTarget.Location);

            CreateEnemys();

            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            ball.Move(timer.Interval / 1000.0);

            foreach (Enemy enemy in enemys)
            {
                enemy.Move(timer.Interval / 1000.0);

                if (ball.IsColliding(enemy) && ball.IsAlive != false)
                {
                    timer.Stop();
                    for (int i = enemys.Count - 1; i >= 0; i--)
                    {
                        enemys[i].Clear();
                        enemys.Remove(enemys[i]);
                    }

                    ball.IsAlive = false;
                    inGame = false;
                    lStats.Visible = true;
                    lStats.Text = "You lose try again";
                }
            }

            if (ball.IsColliding(target))
            {
                lStats.Visible = true;
                ball.IsAlive = false;
                lStats.Text = "You did it!";
                count++;

                lCount.Text = $"Score: {count}";
                inGame = false;
                timer.Stop();
            }

            Update();
        }


        void pField_MouseMove(object sender, MouseEventArgs e)
        {
            if (!inGame) return;

            Vector dir = ball.R - new Vector(e.Location);

            if (dir.SqAbs > max * max) return;
            Vector maxdir = dir.E * max;
            ball.V = maxdir - dir;
        }
    }
}
