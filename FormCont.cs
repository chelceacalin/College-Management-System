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
    public partial class FormCont : Form
    {
        public FormCont()
        {
            InitializeComponent();
        }

        private void FormCont_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.LoginForm' table. You can move, or remove it, as needed.
            this.loginFormTableAdapter.Fill(this.masterDataSet.LoginForm);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
    }
}
