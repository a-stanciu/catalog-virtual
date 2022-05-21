using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIUGlab2_4
{
    [Serializable]
    public struct Notare
    {
        int nota;
        DateTime data;

        public Notare(int nota, DateTime data) : this()
        {
            this.nota = nota;
            this.data = data;
        }

        public int Nota { get; }
        public DateTime Data { get; }
    }

    [Serializable]
    public class Student
    {
        private String nume;
        private List<Notare> note = new List<Notare>();

        public Student(string nume)
        {
            this.nume = nume;
        }

        public int adaugareNota(int nota, DateTime data)
        {
            if (nota < 1)
            {
                return -1;
            }
            else if (nota > 100)
            {
                return 1;
            }
            else
            {
                note.Add(new Notare(nota, data));
                return 0;
            }      
        }

        public void stergereNota(DateTime data)
        {
            foreach (var n in note)
            {
                if (n.Data == data)
                {
                    note.Remove(n);
                }
            }
        }

        public String Nume { get { return nume; } }
        public List<Notare> Note { get { return note; } }
    }
}
