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
    public partial class FormADDStudent : Form
    {
        public Student PrincipalStudent;
        public FormADDStudent(Student s)
        {
            InitializeComponent();

            PrincipalStudent = s;

            button1.Text = "Adauga Student";
            if (s != null)
            {
                button1.Text = "Editeaza Student";
                textBoxNume.Text = s.Nume;
                textBoxPrenume.Text = s.Prenume;
                textBoxVarsta.Text = s.Varsta.ToString();
                textBoxCNP.Text = s.CNP.ToString();
                comboBoxAnStudiu.Text = s.AnStudiu.ToString();
                textBox1.Text = s.Medie.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (PrincipalStudent is null)
                PrincipalStudent = new Student();

            if (textBoxNume.Text.Length > 0 && textBoxPrenume.Text.Length > 0 && textBoxVarsta.Text.Length > 0 && textBoxCNP.Text.Length > 0)
            {
                PrincipalStudent.Nume = textBoxNume.Text;
                PrincipalStudent.Prenume = textBoxPrenume.Text;
                PrincipalStudent.Varsta = Convert.ToInt32(textBoxVarsta.Text);
                PrincipalStudent.CNP = Convert.ToInt32(textBoxCNP.Text);
                PrincipalStudent.AnStudiu = Convert.ToInt32(comboBoxAnStudiu.Text);
                PrincipalStudent.Medie = Convert.ToInt32(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Campuri necompletate! ");
            }
          
        }
    }
}
