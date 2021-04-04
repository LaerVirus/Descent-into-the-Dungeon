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
        int level = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Mapgen.generator(level);
            level++;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Mapgen.generator(level);
            level++;
        }
    }
}
