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
    public partial class FormOrar : Form
    {
        public List<Orar> lista;
        public List<Orar> Lista
        {
            get
            {
                return this.lista;
            }
            set
            {
                this.lista = value;
            }
        }

        public List<Orar> getLista()
        {
            BindingList<Orar> bl = new BindingList<Orar>();
            List<Orar> list = new List<Orar>();
            list.Add(new Orar(DateTime.Now, "Zmeureanu", "Ion", "Paw"));
            list.Add(new Orar(DateTime.Now, "Barbulescu", "Alexandru", "Paw"));
            list.Add(new Orar(DateTime.Now, "Chelcea", "Calin", "SGBD"));
            list.Add(new Orar(DateTime.Now, "Risky", "Riscutescu", "SGBD"));
            list.Add(new Orar(DateTime.Now, "Dorian", "Popa", "PEAG"));
            return list;
        }
        public FormOrar()
        {
            lista = getLista();
            InitializeComponent();


           foreach(Orar item in lista)
            {
                string[] rand = new string[] { item.Data.ToString(),item.NumePROFESOR,item.PrenumePROFESOR,item.Materie };
                dataGridView1.Rows.Add(rand);
            }

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContPrincipal cp = new ContPrincipal();
            cp.Show();
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
        }
    }
}
