using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Proiect_PAW
{


    public partial class ContPrincipal : Form
    {
        public ContPrincipal()
        {
            InitializeComponent();

            Student s1 = new Student("Hatz", "Calin", 20, 50108, 2,8.76f);
            Student s2 = new Student("Risky", "Risky", 4, 12345, 1,9.25f);
            Student s3 = new Student("Alex", "Dan",19,123, 1, 8f);
            Student s4 = new Student("Rox", "Matei", 25, 543, 1, 8.2f);
            ListViewItem lv = new ListViewItem(new string[] { s1.Nume, s1.Prenume, s1.Varsta.ToString(), s1.CNP.ToString(), s1.AnStudiu.ToString() ,s1.Medie.ToString()});
            lv.Tag = s1;
            listView1.Items.Add(lv);

            lv = new ListViewItem(new string[] { s2.Nume, s2.Prenume, s2.Varsta.ToString(), s2.CNP.ToString(), s2.AnStudiu.ToString(), s2.Medie.ToString() });
            lv.Tag = s2;
            listView1.Items.Add(lv);


            lv = new ListViewItem(new string[] { s3.Nume, s3.Prenume, s3.Varsta.ToString(), s3.CNP.ToString(), s3.AnStudiu.ToString(), s3.Medie.ToString() });
            lv.Tag = s3;
            listView1.Items.Add(lv);


            lv = new ListViewItem(new string[] { s4.Nume, s4.Prenume, s4.Varsta.ToString(), s4.CNP.ToString(), s4.AnStudiu.ToString(), s4.Medie.ToString() });
            lv.Tag = s4;
            listView1.Items.Add(lv);


            lv = new ListViewItem(new string[] { s1.Nume, s1.Prenume, s1.Varsta.ToString(), s1.CNP.ToString(), s1.AnStudiu.ToString(), s1.Medie.ToString() });
            lv.Tag = s1;
            listView3.Items.Add(lv);

            lv = new ListViewItem(new string[] { s2.Nume, s2.Prenume, s2.Varsta.ToString(), s2.CNP.ToString(), s2.AnStudiu.ToString(), s2.Medie.ToString() });
            lv.Tag = s2;
            listView3.Items.Add(lv);





            Profesor p1 = new Profesor("Iftimie", "Bogdan", 50, "Probabilitati", "Pro-Decan");
            Profesor p2 = new Profesor("Marinescu", "Daniela", 40, "Macroeconomie", "Conferentiar");
            Profesor p3 = new Profesor("Puican", "Florentina", 35, "Baze de Date", "Seminarist");
            Profesor p4 = new Profesor("Bara", "Adela", 45, "Baze de Date", "Conferentiar");
            Profesor p5 = new Profesor("Dedu", "Silvia", 50, "Probabilitati", "Profesor Universitar");


            lv = new ListViewItem(new string[] { p1.Nume, p1.Prenume, p1.Varsta.ToString(), p1.Disciplina, p1.Functie });
            lv.Tag = p1;
            listView2.Items.Add(lv);


            lv = new ListViewItem(new string[] { p2.Nume, p2.Prenume, p2.Varsta.ToString(), p2.Disciplina, p2.Functie });
            lv.Tag = p2;
            listView2.Items.Add(lv);

            lv = new ListViewItem(new string[] { p3.Nume, p3.Prenume, p3.Varsta.ToString(), p3.Disciplina, p3.Functie });
            lv.Tag = p3;
            listView2.Items.Add(lv);




            lv = new ListViewItem(new string[] { p1.Nume, p1.Prenume, p1.Varsta.ToString(), p1.Disciplina, p1.Functie });
            lv.Tag = p1;
            listView4.Items.Add(lv);


            lv = new ListViewItem(new string[] { p2.Nume, p2.Prenume, p2.Varsta.ToString(), p2.Disciplina, p2.Functie });
            lv.Tag = p2;
            listView4.Items.Add(lv);

            lv = new ListViewItem(new string[] { p3.Nume, p3.Prenume, p3.Varsta.ToString(), p3.Disciplina, p3.Functie });
            lv.Tag = p3;
            listView4.Items.Add(lv);


            listView1.Font = new Font(listView1.Font, FontStyle.Regular);



            //CREEZ NOD PRINCIPAL
            TreeNode t = new TreeNode("PL/SQL");
            treeView1.Nodes.Add(t);

            //CREEZ SUBNODURI
            t.Nodes.Add(p3.Nume + " " + p3.Prenume);
            t.Nodes[0].Tag = p3;
            t.Nodes.Add(p4.Nume + " " + p4.Prenume);
            t.Nodes[1].Tag = p4;


            //CREEZ NOD PRINCIPAL
            t = new TreeNode("Probabilitati");
            treeView1.Nodes.Add(t);


            //CREEZ SUBNODURI
            t = treeView1.Nodes[1];
            t.Nodes.Add(p1.Nume + " " + p1.Prenume);
            t.Nodes[0].Tag = p1;
            t.Nodes.Add(p5.Nume + " " + p5.Prenume);
            t.Nodes[1].Tag = p5;


            //CREEZ NOD PRINCIPAL
            t = treeView1.Nodes[1];
            t = new TreeNode("Programare Evolutiva si Algoritmi Genetici");
            treeView1.Nodes.Add(t);
            t.Nodes.Add(p5.Nume + " " + p5.Prenume);
            t.Nodes[0].Tag = p5;

            treeView1.Nodes.Add("Structuri de date");
            treeView1.Nodes[3].Nodes.Add(p5.Nume + " " + p5.Prenume);
            treeView1.Nodes[3].Tag = p5;

            treeView1.Nodes.Add("Java");
            treeView1.Nodes[4].Nodes.Add("Cristian Toma");

            treeView1.Nodes.Add("Programarea Aplicatiilor Windows");
            treeView1.Nodes[5].Nodes.Add("Barbulescu Alexandru");


            treeView1.Nodes.Add("Macroeconomie Cantitativa");
            treeView1.Nodes[6].Nodes.Add("Marinescu Daniela");

            /*   Profesor p1 = new Profesor("Iftimie", "Bogdan", 50, "Probabilitati", "Pro-Decan");
                        Profesor p2 = new Profesor("Marinescu", "Daniela", 40, "Macroeconomie", "Conferentiar");
                        Profesor p3 = new Profesor("Puican", "Florentina", 35, "Baze de Date", "Seminarist");
                        Profesor p4 = new Profesor("Bara", "Adela", 45, "Baze de Date", "Conferentiar");
                        Profesor p5 = new Profesor("Dedu", "Silvia", 50, "Probabilitati", "Profesor Universitar");
            */

            treeView2.Nodes.Add(p1.Prenume,p1.Nume + " " + p1.Disciplina);
            treeView2.Tag = p1;
            treeView2.Nodes.Add(p2.Prenume,p2.Nume + " " + p2.Disciplina);
            treeView2.Tag = p2;
            treeView2.Nodes.Add(p3.Prenume,p3.Nume + " " + p3.Disciplina);
            treeView2.Tag = p3;
            treeView2.Nodes.Add(p4.Prenume,p4.Nume + " " + p4.Disciplina);
            treeView2.Tag = p4;
            treeView2.Nodes.Add(p5.Prenume,p5.Nume + " " + p5.Disciplina);
            treeView2.Tag = p5;
         


        }

        private void listView1_MouseDoubleClick(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            
            listView2.Visible = true;
            buttonAdaugaStudent.Visible = false;
            button1.Visible = false;
            buttonStergeStudent.Visible = false;
            pictureBox3.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            listView1.Visible = false;
            listView3.Visible = false;
            treeView1.Visible = false;
            treeView2.Visible = false;
            listView4.Visible = false;

        }

        private void buttonAdaugaStudent_Click(object sender, EventArgs e)
        {
            Student student = null;
            FormADDStudent fm = new FormADDStudent(student);
            fm.ShowDialog();

            if (fm.DialogResult == DialogResult.OK)
            {
                student = fm.PrincipalStudent;

                ListViewItem lv = new ListViewItem(new string[] { student.Nume, student.Prenume, student.Varsta.ToString(), student.CNP.ToString(), student.AnStudiu.ToString() });
                lv.Tag = student;
                listView1.Items.Add(lv);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count>0)
            {

                Student student = (Student)listView1.SelectedItems[0].Tag;
                FormADDStudent fm = new FormADDStudent(student);
                fm.ShowDialog();


                ListViewItem lv = listView1.SelectedItems[0];
                lv.Text = student.Nume;
                lv.SubItems[1].Text = student.Prenume;
                lv.SubItems[2].Text = student.Varsta.ToString();
                lv.SubItems[3].Text = student.CNP.ToString();
                lv.SubItems[4].Text = student.AnStudiu.ToString();

            }
            else
            {
                MessageBox.Show("Trebuie sa selectati un elev!");
            }
        }

        private void buttonStergeStudent_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                listView1.SelectedItems[0].Remove();
            else
                MessageBox.Show("Trebuie sa selectati un elev de sters! ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fm=new Form1();
            fm.Show();
           this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            buttonAdaugaStudent_Click(sender, e);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            buttonStergeStudent_Click(sender, e);
        }

        private void toolStripVizualizeazaDateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            Student s = (Student)listView1.SelectedItems[0].Tag;
           VeziStudent form = new VeziStudent(s);
            form.ShowDialog();
            this.Hide();
          
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            buttonAdaugaStudent.Visible = true;
            button1.Visible = true;
            buttonStergeStudent.Visible = true;
            pictureBox3.Visible = false; 

            label4.Visible = false;
            listView2.Visible = false;
            treeView1.Visible = false;
            treeView2.Visible = false;
            label3.Visible = false;
            listView3.Visible = false;
            listView4.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            listView2.Visible = false;
            label3.Visible = false;

            buttonAdaugaStudent.Visible = false;
            button1.Visible = false;
            buttonStergeStudent.Visible = false;

            pictureBox3.Visible = true;
            listView3.Visible = false;
            label4.Visible = true;
            listView1.Visible = false;
            listView4.Visible = false;
        }

        private void studentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            buttonAdaugaStudent.Visible = true;
            button1.Visible = true;
            buttonStergeStudent.Visible = true;
            pictureBox3.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            listView2.Visible = false;
            listView3.Visible = false;
            listView4.Visible = false;
        }

        private void profesoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView2.Visible = true;

            listView3.Visible = false;
            buttonAdaugaStudent.Visible = false;
            button1.Visible = false;
            buttonStergeStudent.Visible = false;
            label3.Visible = false;
            pictureBox3.Visible = false;

            label4.Visible = false;
            listView1.Visible = false;
            listView4.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            listView2.Visible = false;
            listView3.Visible = true;
            listView4.Visible = true;   
            label3.Visible = true;
            buttonAdaugaStudent.Visible = false;
            button1.Visible = false;
            buttonStergeStudent.Visible = false;
            pictureBox3.Visible = false;
            label4.Visible = false;
            listView1.Visible = false;
            treeView1.Visible = true;
            label3.Visible = false;
            treeView2.Visible = true;
             
        }

        private void label7_Click(object sender, EventArgs e)
        {
            listView3.Visible = false;
            listView2.Visible = false;
            buttonAdaugaStudent.Visible = false;
            button1.Visible = false;
            buttonStergeStudent.Visible = false;
            pictureBox3.Visible = false;
            label4.Visible = false;
            listView1.Visible = false;
            treeView1.Visible = false;
            treeView2.Visible = false;
            listView4.Visible = false;
            FormOrar fm = new FormOrar();
            fm.Show();
            this.Hide();
        }
        private void FormOrar_Load(object sender, EventArgs e)
        {
            displayOrar();
        }

        private void displayOrar()
        {
            Orar orar = new Orar(DateTime.Now, "SDD","Crin","Antonescu");
        }

        private void orarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOrar fm = new FormOrar();
            fm.Show();
        }

        private void graficToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void graficToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Grafic gf = new Grafic();
            gf.Show();
        }

        private void vizualizeazaStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Student s = (Student)listView1.SelectedItems[0].Tag;
            VeziStudent form = new VeziStudent(s);
            form.ShowDialog();


          
        }

        private void binarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

       

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void profesoriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog OPEN = new SaveFileDialog();
            OPEN.Filter = " Fisiere XML ( *.XML )| *.XML";
            OPEN.CheckPathExists = true;

            if (OPEN.ShowDialog() == DialogResult.OK)
            {

                List<Profesor> lista = new List<Profesor>();

                foreach(ListViewItem lv in listView2.Items)
                {
                    lista.Add((Profesor)lv.Tag);
                }

                XmlSerializer xml = new XmlSerializer(typeof(List<Profesor>));
                TextWriter fisier = new StreamWriter(OPEN.FileName);
                xml.Serialize(fisier, lista);

            }
        }

        private void profesoriToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = " Facultate (*.fac)|*.fac";
            save.CheckPathExists = true;


            if (save.ShowDialog() == DialogResult.OK)
            {

                List<Profesor> lista = new List<Profesor>();


                foreach (ListViewItem lv in listView2.Items)
                {
                    lista.Add((Profesor)lv.Tag);

                }

                //avem toti studentii;

                Stream fisier = File.Create(save.FileName);
                BinaryFormatter serializeaza = new BinaryFormatter();
                serializeaza.Serialize(fisier, lista);

            }
        }


        private void studentiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = " Facultate (*.fac)|*.fac";
            save.CheckPathExists = true;


            if (save.ShowDialog() == DialogResult.OK)
            {

                List<Student> lista = new List<Student>();


                foreach (ListViewItem lv in listView1.Items)
                {
                    lista.Add((Student)lv.Tag);

                }

                //avem toti studentii;

                Stream fisier = File.Create(save.FileName);
                BinaryFormatter serializeaza = new BinaryFormatter();
                serializeaza.Serialize(fisier, lista);

            }
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog OPEN = new SaveFileDialog();
            OPEN.Filter = " Fisiere XML ( *.XML )| *.XML";
            OPEN.CheckPathExists = true;


            if (OPEN.ShowDialog() == DialogResult.OK)
            {

                List<Student> lista = new List<Student>();

                foreach (ListViewItem lv in listView1.Items)
                {
                    lista.Add((Student)lv.Tag);
                }

                XmlSerializer xml = new XmlSerializer(typeof(List<Student>));
                TextWriter fisier = new StreamWriter(OPEN.FileName);

                xml.Serialize(fisier, lista);

            }
        }

        private void studentiToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            buttonAdaugaStudent.Visible = true;
            button1.Visible = true;
            buttonStergeStudent.Visible = true;
            pictureBox3.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            listView2.Visible = false;
            treeView1.Visible = false;
            treeView2.Visible = false;
            listView4.Visible = false;
            listView3.Visible = false;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = " Facultate (*.fac)|*.fac";
            open.CheckFileExists = true;

            if (open.ShowDialog() == DialogResult.OK)
            {

                List<Student> lista = new List<Student>();

                Stream fisier = File.OpenRead(open.FileName);
                BinaryFormatter deserializator = new BinaryFormatter();

                lista.AddRange((List<Student>)deserializator.Deserialize(fisier));


                fisier.Close();

                foreach (Student p in lista)
                {

                    ListViewItem lv = new ListViewItem(new string[] { p.Nume, p.Prenume, p.Varsta.ToString(), p.CNP.ToString(), p.AnStudiu.ToString(), p.Medie.ToString() });
                    lv.Tag = p;

                    listView1.Items.Add(lv);
                }

            }
        }

        private void profesoriToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            listView1.Visible = false;
            buttonAdaugaStudent.Visible = false;
            button1.Visible = false;
            buttonStergeStudent.Visible = false;
            pictureBox3.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            listView3.Visible = false;
            listView4.Visible = false;
            listView2.Visible = true;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = " Facultate (*.fac)|*.fac";
            open.CheckFileExists = true;

            if (open.ShowDialog() == DialogResult.OK)
            {

                List<Profesor> lista = new List<Profesor>();

                Stream fisier = File.OpenRead(open.FileName);
                BinaryFormatter deserializator = new BinaryFormatter();

                lista.AddRange((List<Profesor>)deserializator.Deserialize(fisier));


                fisier.Close();

                foreach (Profesor p in lista)
                {

                    ListViewItem lv = new ListViewItem(new string[] {p.Nume,p.Prenume,p.Varsta.ToString(),p.Disciplina,p.Functie});
                    lv.Tag = p;

                    listView2.Items.Add(lv);
                }

            }
        }

        private void studentiToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            listView1.Visible = true;
            buttonAdaugaStudent.Visible = true;
            button1.Visible = true;
            buttonStergeStudent.Visible = true;
            pictureBox3.Visible = false;
            listView3.Visible = false;
            label4.Visible = false;
            listView2.Visible = false;
            listView4.Visible = false;
            treeView1.Visible = false;
            treeView2.Visible = false;
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = " Facultate (*.XML)|*.XML";
            fileDialog.CheckFileExists = true;


            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                List<Student> lista = new List<Student>();
                XmlSerializer deserializator = new XmlSerializer(typeof(List<Student>));

                Stream reader = new FileStream(fileDialog.FileName, FileMode.Open);

                lista.AddRange((List<Student>)deserializator.Deserialize(reader));

                reader.Close();
                foreach (Student p in lista)
                {
                    ListViewItem lv = new ListViewItem(new string[] { p.Nume, p.Prenume, p.Varsta.ToString(), p.CNP.ToString(), p.AnStudiu.ToString(), p.Medie.ToString() });
                    lv.Tag = p;

                    listView1.Items.Add(lv);
                }

            }
        }

        private void profesoriToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            listView1.Visible = false;
            buttonAdaugaStudent.Visible = false;
            button1.Visible = false;
            buttonStergeStudent.Visible = false;
            pictureBox3.Visible = false;
            label4.Visible = false;
            listView2.Visible = true;
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = " Facultate (*.XML)|*.XML";
            fileDialog.CheckFileExists = true;


            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                List<Profesor> lista = new List<Profesor>();
                XmlSerializer deserializator = new XmlSerializer(typeof(List<Profesor>));

                Stream reader = new FileStream(fileDialog.FileName, FileMode.Open);

                lista.AddRange((List<Profesor>)deserializator.Deserialize(reader));

                reader.Close();
                foreach (Profesor p in lista)
                {
                    ListViewItem lv = new ListViewItem(new string[] { p.Nume, p.Prenume, p.Varsta.ToString(), p.Disciplina, p.Functie });
                    lv.Tag = p;
                    listView2.Items.Add(lv);
                }

            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listView3_MouseDown(object sender, MouseEventArgs e)
        {
            if (listView3.SelectedItems.Count > 0)
            {
                listView3.DoDragDrop(listView3.SelectedItems[0].Tag, DragDropEffects.Link);
            } // Trb ca destinatia sa aiba ALLOW DROP pe true
        }
        private void listView4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(new Student().GetType().ToString()))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void listView4_DragDrop(object sender, DragEventArgs e)
        {
            Point pnt = listView4.PointToClient(new Point(e.X, e.Y));

            ListViewItem lv = listView4.GetItemAt(pnt.X, pnt.Y);

            
            if(!(lv is null))
            {

                Profesor p = (Profesor)lv.Tag;
                TreeNode t = treeView2.Nodes.Find(p.Prenume, true)[0];

                Student s = (Student)e.Data.GetData(new Student().GetType().ToString());


                t.Nodes.Add(s.Nume + " " + s.Prenume + " " + s.Medie.ToString());
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Lista Studenti ", new Font("Times New Roman", 30, FontStyle.Bold), Brushes.Black, new Point(230, 100));

            e.Graphics.DrawString("Nume", new Font("Times New Roman", 18, FontStyle.Regular), Brushes.Black, new Point(50, 200));
            e.Graphics.DrawString("Prenume", new Font("Times New Roman", 18, FontStyle.Regular), Brushes.Black, new Point(160, 200));
            e.Graphics.DrawString("Varsta", new Font("Times New Roman", 18, FontStyle.Regular), Brushes.Black, new Point(270, 200));

            List<Student> lista = new List<Student>();
            string myString = " ";
            foreach (ListViewItem lv in listView1.Items)
            {
                lista.Add((Student)lv.Tag);
            }
            int cnt = 1;
            foreach (Student i in lista)
            {
                e.Graphics.DrawString(i.ToStringCuSpatii(), new Font("Arial", 14, FontStyle.Italic), Brushes.Black, new Point(50, (2 * cnt) + 225));
                cnt += 10;

            }




        }

        private void pRINTSTUDENTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void accountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCont fm = new FormCont();

            fm.ShowDialog();
        }

        private void userControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUserControl fm = new FormUserControl();
            fm.ShowDialog();
        }

        private void ContPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control==true&&e.KeyCode==Keys.S)
            {
                
               buttonSave.PerformClick();

            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            studentiToolStripMenuItem1_Click(sender, e);
        }

        private void ContPrincipal_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
    }
}
