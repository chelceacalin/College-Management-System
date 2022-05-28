using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    public class Orar
    {
        DateTime data;
        string numeProfesor;
        string materie;
        string prenumeProfesor;


       
        public Orar(DateTime data, string numeProfesor, string prenume, string Materie)
        {
            this.data = data;
            this.numeProfesor = numeProfesor;
            this.prenumeProfesor = prenume;
            this.materie = Materie;
         
        }

        public string Materie
        {
            get
            {
                return this.materie;
            }
            set
            {
                this.materie = value;
            }
        }


        public DateTime Data
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }


        public string NumePROFESOR
        {
            get
            {
                return this.numeProfesor;
            }
            set
            {
                this.numeProfesor = value;
            }
        }

        public string PrenumePROFESOR
        {
            get
            {
                return this.numeProfesor;
            }
            set
            {
                this.numeProfesor = value;
            }
        }



    }
}
