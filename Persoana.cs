using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    [Serializable]
  public class Persoana
    {
        string nume;
        string prenume;

        int varsta;
        
        public Persoana()
        {
            this.nume = "Anonim";
            this.prenume = "Anonim Prenume";
            this.varsta = 0;
        }
        public Persoana(string nume, string prenume,int varsta)
        {
            this.nume = nume;
            this.varsta = varsta;
            this.prenume = prenume;
        }
        
        public string Nume
        {
            get
            {
                return this.nume;
            }
            set
            {
                this.nume = value;
            }
        }
        public string Prenume
        {
            get
            {
                return this.prenume;
            }
            set
            {
                this.prenume = value;
            }
        }





        public int Varsta
        {
            get
            {
                return this.varsta;
            }
            set
            {
                this.varsta = value;
            }
        }


  }
}
