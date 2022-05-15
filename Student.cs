using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    [Serializable]
    public class Student:Persoana
    {
        int cnp;
        int anStudiu;
        float medie;
       // int[] note;

        public Student():base()
        {
            this.cnp = 0;
            this.anStudiu = 0;
            this.medie = 0;
        }

        public Student(string nume,string prenume,int varsta,int cnp, int anstudiu,float medie) : base(nume,prenume,varsta)
        {
            this.cnp = cnp;
            this.anStudiu = anstudiu;
            this.medie = medie;
        }

        public float Medie
        {
            get
            {
                return this.medie;
            }
            set
            {
                this.medie = value;
            }
        }

        public override string ToString()
        {
            return this.Nume + " " + this.Prenume + " " + this.Varsta + " " + this.anStudiu + " " + this.medie;
        }
        public  string ToStringCuSpatii()
        {
            return this.Nume + "    \t       " + this.Prenume + "  \t   " + this.Varsta + "      " ;
        }

        public int CNP
        {
            get
            {
                return this.cnp;
            }

            set
            {
                this.cnp = value; 
            }
        }
        public int AnStudiu
        {
            get
            {
                return this.anStudiu;
            }

            set
            {
                this.anStudiu = value;
            }
        }
    }
}
