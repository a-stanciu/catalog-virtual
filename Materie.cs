using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIUGlab2_4
{
    [Serializable]
    public class Materie
    {
        private String nume;
        private List<Student> studentiInscrisi = new List<Student>();
        private int nrInscrisi = 0;

        public Materie(String nume)
        {
            this.nume = nume;
        }

        public void adaugareStudent(String nume)
        {
            studentiInscrisi.Add(new Student(nume));
            nrInscrisi++;
        }

        public void stergereStudent(Student s)
        {
            studentiInscrisi.Remove(s);
            nrInscrisi--;
        }

        public void adaugareNota(String nume, int nota, DateTime data)
        {
            foreach (var i in studentiInscrisi)
            {
                if (i.Nume == nume)
                {
                    i.adaugareNota(nota, data);
                }
            }
        }

        public void stergereNota(String nume, DateTime data)
        {
            foreach (var i in studentiInscrisi)
            {
                if (i.Nume == nume)
                {
                    i.stergereNota(data);
                }
            }
        }

        public String Nume { get { return nume; } set { nume = value; } }
        public List<Student> StudentiInscrisi { get { return studentiInscrisi; } }
        public int NrInscrisi { get { return nrInscrisi; } }
    }
}
