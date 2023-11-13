using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEmployee
{
    internal class Consultant:Employe
    {
        public decimal TauxHoraire { get; set; }
        public int HeuresTravaillees { get; set; }

        // Constructeur d'initialisation
        public Consultant(string nom, int numeroEmploye, decimal tauxHoraire, int heuresTravaillees)
            : base(nom, numeroEmploye)
        {
            TauxHoraire = tauxHoraire;
            HeuresTravaillees = heuresTravaillees;
        }
    }
}
