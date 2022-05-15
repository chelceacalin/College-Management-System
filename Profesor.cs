using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    [Serializable]
    public class Profesor:Persoana
    {

        string disciplinaPredata;
        string functie;

        public Profesor():base()
        {
            this.disciplinaPredata = "Anonim";
            this.functie = "Anonim";
        }

        public Profesor(string nume, string prenume, int varsta, string DisciplinaPredata, string Functie) : base(nume, prenume, varsta)
        {
            this.disciplinaPredata = DisciplinaPredata;
            this.functie = Functie;

        }


        public string Disciplina
        {
            get
            {
                return this.disciplinaPredata;
            }
            set
            {
                this.disciplinaPredata = value;
            }
        }


        public string Functie
        {
            get { return this.functie; }
            set
            {
                this.functie = value;
            }
        }


    }
}
