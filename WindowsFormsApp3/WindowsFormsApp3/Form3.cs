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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser3.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser3.Navigate("https://vk.com/serejkakotel");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser3.GoForward();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser3.Refresh();
        }

        private void webBrowser3_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }
    }
}
