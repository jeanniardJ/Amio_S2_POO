namespace S2_POO_TP_EMPLOIE
{
    internal class Program
    {


        static void Main(string[] args)
        {
            List<Employe> Employes = new List<Employe>
            {
                new Employe(1001, "dupont", "jean", new DateTime(1985, 3, 15), new DateTime(2010, 6, 1), 3500),
                new Employe(1002, "martin", "marie", new DateTime(1990, 7, 22), new DateTime(2015, 2, 15), 2800),
                new Employe(1003, "bernard", "pierre", new DateTime(1978, 11, 5), new DateTime(2005, 9, 1), 4200),
                new Employe(1004, "petit", "sophie", new DateTime(1995, 1, 18), new DateTime(2018, 4, 10), 2500),
                new Employe(1005, "durand", "luc", new DateTime(1982, 9, 30), new DateTime(2012, 11, 20), 3800),
                new Employe(1006, "leroy", "claire", new DateTime(1988, 5, 12), new DateTime(2014, 3, 5), 3200),
                new Employe(1007, "moreau", "thomas", new DateTime(1992, 12, 8), new DateTime(2019, 7, 1), 2600),
                new Employe(1008, "laurent", "nathalie", new DateTime(1975, 4, 25), new DateTime(2003, 1, 15), 5100),
                new Employe(1009, "garcia", "karim", new DateTime(1987, 8, 14), new DateTime(2013, 10, 3), 3400),
                new Employe(1010, "roux", "amelie", new DateTime(1998, 2, 28), new DateTime(2021, 9, 1), 2300),
            };

            foreach (Employe item in Employes)
            {
                item.EmployeDisplayed();
                item.PayRise();
                item.EmployeDisplayed();
            }
        }
}
}
