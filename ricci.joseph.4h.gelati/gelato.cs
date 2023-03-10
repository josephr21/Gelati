using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Media.Animation;

namespace ricci.joseph._4h.gelati
{
    internal class gelato
    {
        public string Tipo { get; set; }
        public string Size { get; set; }
        public string Gusto { get; set; }

        public gelato(string riga) 
        {
            string[] colonne = riga.Split(";");
            Tipo = colonne[0];
            Size = colonne[1];      
            Gusto = colonne[2];
        }




    }

    public class gelati:List<gelato>

    {
        public gelati(string nomefile) 
        {
            
          
                StreamReader fin = new StreamReader(nomefile);
                fin.Readline();
                while(!fin.EndOfStream)
                {
                    string riga = fin.ReadLine();
                    gelato g = new gelato(riga);
                    Add(g);

                }

                fin.Close();

            
            
        }
    }
}
