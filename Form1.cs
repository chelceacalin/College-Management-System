using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.AntiqueWhite;
            this.Size = new Size(560, 350);

           
            
        }
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=BazaLogin;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            label1.Visible = false;
            label5.Visible = true;
            label5.BackColor = Color.Transparent;
            this.Size = new Size(600, 700);
            this.BackColor = Color.AliceBlue;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

       public String username, parola;

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            username = textBoxNumePrincipal.Text;
            parola = textBoxParolaPrincipal.Text;

            try
            {
                string querry = "select * from LoginForm where Name= '" + textBoxNumePrincipal.Text + "' and Pass= '" + textBoxParolaPrincipal.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(querry,con);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    username = textBoxNumePrincipal.Text;
                    parola = textBoxParolaPrincipal.Text;
                   
                    //pagina ce va aparea
                    ContPrincipal cont = new ContPrincipal();
                    cont.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nume sau parola gresite");
                    textBoxNumePrincipal.Clear();
                    textBoxParolaPrincipal.Clear();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Eroare baza de date");
            }
            finally
            {
                con.Close();
            }



    /*    if (textBoxNumePrincipal.Text== "elev" && textBoxParolaPrincipal.Text == "stud")
            {
                ContPrincipal cont = new ContPrincipal();
                cont.ShowDialog();

            }
            
            else
            {
                MessageBox.Show("Nume sau parola gresite");
                textBoxNumePrincipal.Clear();
                textBoxParolaPrincipal.Clear();
            }*/
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string querry = "select * from LoginForm where Name= '" + textBoxNumePrincipal.Text + "' and Pass= '" + textBoxParolaPrincipal.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, con);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    username = textBoxNumePrincipal.Text;
                    parola = textBoxParolaPrincipal.Text;

                    //pagina ce va aparea
                    ContPrincipal cont = new ContPrincipal();
                    cont.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nume sau parola gresite");
                    textBoxNumePrincipal.Clear();
                    textBoxParolaPrincipal.Clear();
                }
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            textBoxNumePrincipal.Clear();
            textBoxParolaPrincipal.Clear();
        }

        private void textBoxParolaPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String username, parola;

                username = textBoxNumePrincipal.Text;
                parola = textBoxParolaPrincipal.Text;

                try
                {
                    string querry = "select * from LoginForm where Name= '" + textBoxNumePrincipal.Text + "' and Pass= '" + textBoxParolaPrincipal.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, con);

                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        username = textBoxNumePrincipal.Text;
                        parola = textBoxParolaPrincipal.Text;
                        //pagina ce va aparea
                        ContPrincipal cont = new ContPrincipal();
                        cont.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Nume sau parola gresite");
                        textBoxNumePrincipal.Clear();
                        textBoxParolaPrincipal.Clear();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Eroare baza de date");
                }
                finally
                {
                    con.Close();
                }


            }

        }

        private void buttonShowPassword_Click(object sender, EventArgs e)
        {
          
        }

        public SqlConnection getConn()
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=BazaLogin;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            return con1;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            label1.Visible = false;
            label5.Visible = true;
            label5.BackColor = Color.Transparent;
            this.Size = new Size(600, 700);
            this.BackColor = Color.AliceBlue;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
           
            label1.Visible = false;
            label5.Visible = true;
            label5.BackColor = Color.Transparent;
            this.Size = new Size(600, 700);
            this.BackColor = Color.White;
            this.BackColor = Color.AliceBlue;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBoxParolaPrincipal.UseSystemPasswordChar == true)
            {
                textBoxParolaPrincipal.UseSystemPasswordChar = false;

            }
            else
            {
                textBoxParolaPrincipal.UseSystemPasswordChar = true;
            }
        }

        private void textBoxNumePrincipal_Validating(object sender, CancelEventArgs e)
        {

            if (textBoxNumePrincipal.Text.Length < 3)
            {
                errorProvider1.SetError(textBoxNumePrincipal    ,"Nume prea scurt");
            }
            else
            {
                errorProvider1.SetError(textBoxNumePrincipal, "");
            }
        }

        private void textBoxParolaPrincipal_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxParolaPrincipal.Text.Length < 3)
            {
                errorProvider2.SetError(textBoxParolaPrincipal, "Parola prea scurta");
            }
            else
            {
                errorProvider2.SetError(textBoxParolaPrincipal, "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection conexiune = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=BazaLogin;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            try
            {
                conexiune.Open();
                SqlCommand cmd = new SqlCommand("insert into LoginForm values('" + textBoxNumePrincipal.Text + "','" + textBoxParolaPrincipal.Text + "'); ", conexiune);
                cmd.ExecuteNonQuery();
                 
                MessageBox.Show("Cont creat");
                conexiune.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Eroare baza de date");
            }
           

        }
    }
}
