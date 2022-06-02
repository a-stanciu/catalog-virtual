using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void stergereStudent(String nume)
        {
            foreach (var i in StudentiInscrisi)
            {
                if (i.Nume == nume)
                {
                    using (var f = new ConfirmareStergere(i.Nume, "student"))
                    {
                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            studentiInscrisi.Remove(i);
                            nrInscrisi--;
                            break;
                        }
                    }
                }
            }
        }

        public void adaugareNota(String nume, int nota, String data)
        {
            foreach (var i in studentiInscrisi)
            {
                if (i.Nume == nume)
                {
                    i.adaugareNota(nota, data);
                    break;
                }
            }
        }

        public void stergereNota(String nume, String data)
        {
            foreach (var i in studentiInscrisi)
            {
                if (i.Nume == nume)
                {
                    i.stergereNota(data);
                    break;
                }
            }
        }

        public int calculMedie(String nume)
        {
            int medie = -1;

            foreach (var i in StudentiInscrisi)
            {
                if (i.Nume == nume)
                {
                    medie = i.calculMedie();
                }
            }

            return medie;
        }

        public String Nume { get { return nume; } set { nume = value; } }
        public List<Student> StudentiInscrisi { get { return studentiInscrisi; } }
        public int NrInscrisi { get { return nrInscrisi; } }
    }
}
