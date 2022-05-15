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
            var list = new List<Orar>();
            list.Add(new Orar("Paw", DateTime.Now, "Zmeureanu", "Ion"));
            list.Add(new Orar("Paw", DateTime.Now, "Barbulescu", "Alexandru"));
            list.Add(new Orar("SGBD", DateTime.Now, "Chelcea", "Calin"));
            list.Add(new Orar("SGBD", DateTime.Now, "Risky", "Riscutescu"));
            list.Add(new Orar("PEAG", DateTime.Now, "Dorian", "Popa"));
            return list;
        }
     
        public FormOrar()
        {
            lista = getLista();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContPrincipal cp = new ContPrincipal();
            cp.Show();
        }

        private void FormOrar_Load(object sender, EventArgs e)
        {
            var listOrar = lista;
            dataGridView1.DataSource = listOrar;

            //pt a roti
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
