using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIUGlab2_4
{
    [Serializable]
    public class Notare
    {
        int nota;
        String data;

        public Notare(int nota, String data)
        {
            this.nota = nota;
            this.data = data;
        }

        public int Nota { get { return nota; } }
        public String Data { get { return data; } }
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

        public void adaugareNota(int nota, String data)
        {

            foreach (var i in note)
            {
                if (i.Data == data)
                {
                    MessageBox.Show("O notă există deja pentru data selectată.", "Eroare");
                    return;
                }
            }

            note.Add(new Notare(nota, data));
            // Compara folosind expresie lambda
            note.Sort((a, b) => DateTime.Compare(DateTime.Parse(a.Data), DateTime.Parse(b.Data)));
        }

        public void stergereNota(String data)
        {
            foreach (var n in note)
            {
                if (n.Data == data)
                {
                    using (var f = new ConfirmareStergere(n.Data + "; " + n.Nota.ToString(), "notă"))
                    {
                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            note.Remove(n);
                            break;
                        }
                    }
                }
            }
        }

        public int calculMedie()
        {
            int count = 0, suma = 0;

            foreach (var i in note)
            {
                suma += i.Nota;
                count++;
            }

            if (count == 0)
            {
                return -1;
            }
            else
            {
                return suma / count;
            }
        }

        public String Nume { get { return nume; } }
        public List<Notare> Note { get { return note; } }
    }
}
