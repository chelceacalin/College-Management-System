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
    public partial class VeziStudent : Form
    {
        public Student mainStud;
        public VeziStudent(Student s)
        {
            InitializeComponent();
            mainStud = s;
            if (s != null)
            {
                textBoxNume.Text = s.Nume;
                textBoxPrenume.Text = s.Prenume;
                textBoxCNP.Text = s.CNP.ToString();
                textBoxVarsta.Text = s.Varsta.ToString();
                comboBoxAnStudiu.Text = s.AnStudiu.ToString();

            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            ContPrincipal cp = new ContPrincipal();
            cp.Show();



        }

        private void comboBoxAnStudiu_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
