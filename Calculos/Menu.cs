using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculos
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void fahrenheitYCelsiusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1  v2 =  new Form1();
            v2.ShowDialog();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void claculadoraDeCelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 v2 = new Form1();
            v2.ShowDialog();
        }
    }
}
