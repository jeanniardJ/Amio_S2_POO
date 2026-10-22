namespace S2_POO_TP_EMPLOIE;

internal class Employe
{
    public int Matricule { get; private init; }
    public string LastName { get; private init; }
    public string FirstName { get; private init; }
    public DateTime BirthDate { get; private init; }
    public DateTime HireDate { get; private init; }
    public decimal Salary { get; private set;}
  

    public Employe(int matricule, string lastName, string firstName, DateTime birthDate, DateTime hireDate, decimal salary)
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
        string display = $"""
         - Matricule : {Matricule}
         - Nom complet : {LastName.ToUpper()} {FirstName}
         - Age : {GetAge()}
         - Ancienneté : {GetSeniority()}
         - Salaire : {Salary}
        """;

        Console.WriteLine(display);
    }

    public int GetAge()
    {
        int age = DateTime.Today.Year - BirthDate.Year;

        if (DateTime.Today < BirthDate.AddYears(age))
        {
            age--;
        }

        return age;
    }

    public int GetSeniority()
    {
        int seniority = DateTime.Today.Year - HireDate.Year;

        if (DateTime.Today < HireDate.AddYears(seniority))
        {
            seniority--;
        }

        return seniority;
    }

    public void PayRise()
    {
        switch (GetSeniority())
        {
            case < 5:
                // 2% d'augmentation
                Salary = Salary * 1.02M;
                break;
            case < 10:
                // 5% d'augmentation
                Salary = Salary * 1.05M;
                break;
            case >= 10:
                // 10% d'augmentation
                Salary = Salary * 1.10M;
                break;
        }
    }
}
