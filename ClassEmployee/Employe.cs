using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEmployee
{
    internal class Employe
    {
        public string Nom { get; set; }
        public int NumeroEmploye { get; set; }

        // Constructeur d'initialisation
        public Employe(string nom, int numeroEmploye)
        {
            Nom = nom;
            NumeroEmploye = numeroEmploye;
        }
    }
}
