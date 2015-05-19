using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_University
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you really sure to exit?", "Attention", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            AddNewClientWindow ancWin = new AddNewClientWindow();
            ancWin.Show();

        }

    }
}
