using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO_TP_EMPLOIE
{
    internal class Employe
    {
        private int Matricule;
        private string LastName;
        private string FirstName;
        private DateTime BirthDate;
        private DateTime HireDate;
        private float Salary;
        private DateTime DateOfDay = DateTime.Today;

        public Employe(int matricule, string lastName, string firstName, DateTime birthDate, DateTime hireDate, int salary)
        {
            Matricule = matricule;
            LastName = lastName;
            FirstName = firstName;
            BirthDate = birthDate;
            HireDate = hireDate;
            Salary = salary;
        }

        public void EmployeDisplayed()
        {
            string display = "";

            display += $"Matricule {Matricule}";
            display += $"\nNom complet : {char.ToUpper(LastName[0]) + LastName.Substring(1)} {LastName.ToUpper()}";
            display += $"\nAge : {GetAge()}";
            display += $"\n1nciennté : {GetSeniority()}";
            display += $"\nSalaire : {Salary}";

            Console.WriteLine(display + "\n");
        }

        public int GetAge()
        {
            //Calculer l'age avec la date du jour
            return DateOfDay.Year - BirthDate.Year;
        }

        public int GetSeniority()
        {
            return DateOfDay.Year - HireDate.Year;
        }

        public int PayRise()
        {
            switch (GetSeniority())
            {
                case < 5:
                    // 2% d'augmentation
                    Salary = Salary * 1.02f;
                    break;
                case < 10:
                    // 5% d'augmentation
                    Salary = Salary * 1.05f;
                    break;
                case >= 10:
                    // 10% d'augmentation
                    Salary = Salary * 1.10f;
                    break;
            }

            return 1;
        }
    }
}
