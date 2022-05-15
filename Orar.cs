using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    public class Orar
    {
        string materie;
        DateTime data;
        string numeProfesor;
        string prenumeProfesor;


       
        public Orar(string Materie, DateTime data,string numeProfesor,string prenume)
        {
            this.materie = materie;
            this.data = data;
            this.numeProfesor = numeProfesor;
            this.prenumeProfesor = prenume;
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
