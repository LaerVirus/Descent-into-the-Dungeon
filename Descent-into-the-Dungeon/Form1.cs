using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Descent_into_the_Dungeon
{
    public partial class Form1 : Form
    {
        Point leftBorder;
        Point rightBorder;

        public Form1()
        {
            InitializeComponent();
            leftBorder = mainHero.Location;
            rightBorder = enemy3.Location;
            mapPanel.MouseWheel += new MouseEventHandler(Map_MouseWheel);
        }

        private void Map_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && mainHero.Location != leftBorder)
            {
                MoveMap(10);
            }
            if (e.Delta < 0 && enemy7.Location != rightBorder)
            {
                MoveMap(-10);
            }
        }

        private void Map_MouseEnter(object sender, EventArgs e)
        {
            mainHero.MouseWheel += Map_MouseWheel;
        }

        private void Map_MouseLeave(object sender, EventArgs e)
        {
            map.MouseWheel -= Map_MouseWheel;
        }

        private void MoveMap(object distance)
        {
            int run = Convert.ToInt32(distance);
            mainHero.Location = new Point(mainHero.Location.X + run, mainHero.Location.Y);
            enemy1.Location = new Point(enemy1.Location.X + run, enemy1.Location.Y);
            enemy2.Location = new Point(enemy2.Location.X + run, enemy2.Location.Y);
            enemy3.Location = new Point(enemy3.Location.X + run, enemy3.Location.Y);
            enemy4.Location = new Point(enemy4.Location.X + run, enemy4.Location.Y);
            enemy5.Location = new Point(enemy5.Location.X + run, enemy5.Location.Y);
            enemy6.Location = new Point(enemy6.Location.X + run, enemy6.Location.Y);
            enemy7.Location = new Point(enemy7.Location.X + run, enemy7.Location.Y);
            int scrollRun;
            if (run < 0)
            {
                scrollRun = run + 1;
            }
            else
            {
                scrollRun = run - 1;
            }
            scroll.Location = new Point(scroll.Location.X - scrollRun, scroll.Location.Y);
        }

        static public void SetMapImage(ref PictureBox mapPictureBox, string imageLocation)
        {
            mapPictureBox.Image = Image.FromFile(imageLocation);
        }
    }
}
