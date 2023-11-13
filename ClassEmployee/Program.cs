using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciation d'un employé à temps plein
            EmployeATempsPlein employeTempsPlein = new EmployeATempsPlein("John Doe", 1001, 5000);

            // Instanciation d'un consultant
            Consultant consultant = new Consultant("Jane Smith", 2001, 50, 40);

            // Affichage des détails de chaque employé
            AfficherDetailsEmploye(employeTempsPlein);
            AfficherDetailsEmploye(consultant);

            // Ajout d'une instruction de lecture pour empêcher la fermeture automatique de la console
            Console.ReadLine();
        }

       
        // Fonction pour afficher les détails d'un employé
        static void AfficherDetailsEmploye(Employe employe)
        {
            Console.WriteLine($"Nom: {employe.Nom}, Numéro d'employé: {employe.NumeroEmploye}");

            if (employe is EmployeATempsPlein)
            {
                EmployeATempsPlein employeTempsPlein = (EmployeATempsPlein)employe;
                Console.WriteLine($"Salaire Mensuel: {employeTempsPlein.SalaireMensuel:C}");
            }
            else if (employe is Consultant)
            {
                Consultant consultant = (Consultant)employe;
                Console.WriteLine($"Taux Horaire: {consultant.TauxHoraire:C}, Heures Travaillées: {consultant.HeuresTravaillees}");
            }

            Console.WriteLine();
        }
    }
}
