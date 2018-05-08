using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern_Firma
{
    class Program
    {
        static void Main(string[] args)
        {
            DepartmentManager Geschäftsführer = new DepartmentManager();
            Geschäftsführer.Name = "Geschäftsführer";

            DepartmentManager Produktmanager = new DepartmentManager();
            Produktmanager.Name = "Produktmanager";

            DepartmentManager AssistentEinsProduktmanager = new DepartmentManager();
            AssistentEinsProduktmanager.Name = "Assistent Produktmanager 1";

            DepartmentManager AssistentZweiProduktmanager = new DepartmentManager();
            AssistentZweiProduktmanager.Name = "Assistent Produktmanager 2";

            DepartmentManager ProjektKoordinierer = new DepartmentManager();
            ProjektKoordinierer.Name = "Projektkoordinierer";

            DepartmentManager Projektleiter1 = new DepartmentManager();
            Projektleiter1.Name = "Projektleiter 1";

            DepartmentManager Projektleiter2 = new DepartmentManager();
            Projektleiter2.Name = "Projektleiter 2";

            DepartmentManager Projektleiter3 = new DepartmentManager();
            Projektleiter3.Name = "Projektleiter 3";

            DepartmentManager DokumentManager = new DepartmentManager();
            DokumentManager.Name = "Dokumentenmanager";

            Geschäftsführer.AddEmployeeList(new List<AEmployee>() {Produktmanager,ProjektKoordinierer,DokumentManager});

            Produktmanager.AddEmployeeList(new List<AEmployee>() { AssistentEinsProduktmanager, AssistentZweiProduktmanager });

            ProjektKoordinierer.AddEmployeeList(new List<AEmployee>(){Projektleiter1,Projektleiter2,Projektleiter3});

            ConcreteEmployee Employee0 = new ConcreteEmployee("Huber Franz");
            ConcreteEmployee Employee1 = new ConcreteEmployee("Mayer Peter");
            ConcreteEmployee Employee2 = new ConcreteEmployee("Richter Florian");
            ConcreteEmployee Employee3 = new ConcreteEmployee("Schwaner Karl");
            ConcreteEmployee Employee4 = new ConcreteEmployee("Sanchez James");
            ConcreteEmployee Employee5 = new ConcreteEmployee("Granser Peter");
            ConcreteEmployee Employee6 = new ConcreteEmployee("Steindl Thomas");
            ConcreteEmployee Employee7 = new ConcreteEmployee("Dybala Paolo");
            ConcreteEmployee Employee8 = new ConcreteEmployee("Beckenbauer Franz");
            ConcreteEmployee Employee9 = new ConcreteEmployee("Herzog Andreas");
            ConcreteEmployee Employee10 = new ConcreteEmployee("Polster Anton");
            ConcreteEmployee Employee11 = new ConcreteEmployee("Müller Matthias");
            ConcreteEmployee Employee12 = new ConcreteEmployee("Mörtl Thomas");
            ConcreteEmployee Employee13 = new ConcreteEmployee("Fritz Xaver");
            ConcreteEmployee Employee14 = new ConcreteEmployee("Steiner Bernd");
            ConcreteEmployee Employee15 = new ConcreteEmployee("Schlager Hermann");
            ConcreteEmployee Employee16 = new ConcreteEmployee("Maier Horst");
            ConcreteEmployee Employee17 = new ConcreteEmployee("Günther Karl");
            ConcreteEmployee Employee18 = new ConcreteEmployee("Bauer Florian");
            ConcreteEmployee Employee19 = new ConcreteEmployee("Seidl Peter");

            Geschäftsführer.AddEmployeeList(new List<AEmployee>() { Employee0, Employee1, Employee2, Employee3, Employee4 });
            Produktmanager.AddEmployeeList(new List<AEmployee>() { Employee5, Employee6 });
            AssistentEinsProduktmanager.AddEmployeeList(new List<AEmployee>() {Employee7,Employee8,Employee9 });
            AssistentZweiProduktmanager.AddEmployee(Employee10);
            Projektleiter1.AddEmployeeList(new List<AEmployee>() {Employee11,Employee12,Employee13,Employee14,Employee15 });
            Projektleiter2.AddEmployeeList(new List<AEmployee>() {Employee16,Employee17});
            DokumentManager.AddEmployeeList(new List<AEmployee>() { Employee18, Employee19 });

            foreach (string s in ProjektKoordinierer.GetEmployeeDiagram())
            {
                Console.WriteLine(s);
            }
            Console.Write("Mitarbeiteranzahl: ");
            Console.Write(Geschäftsführer.GetEmployeeCount().ToString()+"\n");
        }
    }
}
