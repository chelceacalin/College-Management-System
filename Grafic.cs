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
    public partial class Grafic : Form
    {
        public Grafic()
        {
            InitializeComponent();

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ContPrincipal contPrincipal = new ContPrincipal();
            contPrincipal.Show();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Grafic_Load(object sender, EventArgs e)
        {
            fillchart();
        }

        private void fillchart()
        {
            Student s1 = new Student("Chelcea", "Calin", 20, 50108, 2,  8.7f);
            Student s2 = new Student("Risky", "Risky", 4, 12345, 1, 9.25f);
            Student s3 = new Student("Toma", "Cristian Valeriu", 4, 542356, 1, 5f);
            Student s4= new Student("Esca", "Andreea", 3, 32345, 1,7.5f);
            Student s5 = new Student("Popa", "Dorian", 5, 743245, 1, 3.25f);
            chart1.Series["Medii"].IsValueShownAsLabel = true;
            chart1.Series["Medii"].Points.AddXY(s1.Nume, s1.Medie);
            chart1.Series["Medii"].Points[0].Color = Color.DarkRed;
            chart1.Series["Medii"].Points.AddXY(s2.Nume, s2.Medie);
            chart1.Series["Medii"].Points[1].Color = Color.Goldenrod;
            chart1.Series["Medii"].Points.AddXY(s3.Nume, s3.Medie);
            chart1.Series["Medii"].Points[2].Color = Color.MediumPurple;
            chart1.Series["Medii"].Points.AddXY(s4.Nume, s4.Medie);
            chart1.Series["Medii"].Points[3].Color = Color.LightPink;
            chart1.Series["Medii"].Points.AddXY(s5.Nume, s5.Medie);
            chart1.Series["Medii"].Points[4].Color = Color.CadetBlue;

            chart1.Titles.Add("Grafic");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if(comboBox1.Text=="Point")
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            if (comboBox1.Text == "Column")
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            if (comboBox1.Text == "Bar")
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            if (comboBox1.Text == "Pie")
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }
    }
}
