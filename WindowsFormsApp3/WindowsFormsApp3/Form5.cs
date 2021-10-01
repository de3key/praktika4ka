using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void рисунок1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 Рисунок1 = new Form6();
            Рисунок1.ShowDialog();
        }

        private void рисунок2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 Рисунок1 = new Form7();
            Рисунок1.ShowDialog();
        }

        private void рисунок3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 Рисунок1 = new Form8();
            Рисунок1.ShowDialog();
        }
    }
}
