using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class FormUserControl : Form
    {
        public FormUserControl()
        {
            InitializeComponent();
        }

        private void buttonGetStudenti_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Prenume = {0}, CNP = {1} ", userControl11.selectStudent.Prenume, userControl11.selectStudent.CNP),"Message",MessageBoxButtons.OK);
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
