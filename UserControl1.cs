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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }


        public Student selectStudent
        {
            get
            {
                return (Student)cboStudenti.SelectedItem;
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

            List<Student> list = new List<Student>();
            list.Add(new Student(nume:"Calin", prenume:"Chelcea",20,cnp:01231, 2, 10));
            list.Add(new Student("Risky", "Patronescu", 15, cnp: 32131, 2, 10));
            list.Add(new Student("Alex", "Calin", 20, cnp: 654654, 2, 10));
            cboStudenti.DataSource = list;
            cboStudenti.ValueMember = "cnp";
            cboStudenti.DisplayMember = "nume";
        }

       

        private void buttonHome_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
