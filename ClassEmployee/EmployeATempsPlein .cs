using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEmployee
{
    internal class EmployeATempsPlein:Employe
    {
        public decimal SalaireMensuel { get; set; }

        // Constructeur d'initialisation
        public EmployeATempsPlein(string nom, int numeroEmploye, decimal salaireMensuel)
            : base(nom, numeroEmploye)
        {
            SalaireMensuel = salaireMensuel;
        }
    }
}
