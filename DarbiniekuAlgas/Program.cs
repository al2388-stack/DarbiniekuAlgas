using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var employees = new List<Employee>
        {
            new FullTimeEmployee("Anna", 1200m),
            new HourlyEmployee("Jānis", 8m, 100),
            new SalesEmployee("Marta", 500m, 4000m)
        };

        foreach (Employee e in employees)
        {
            Console.WriteLine($"{e.Name}: {e.CalculateSalary():F2}");
        }

        var payroll = new PayrollCalculator();
        Console.WriteLine($"Kopā: {payroll.TotalSalary(employees):F2}");
    }
}

// Paskaidrojums:
// 1. Polimorfisms redzams koda daļā, kur ciklā (foreach) vai PayrollCalculator metodē tiek izsaukts e.CalculateSalary(). 
//    Lai gan sarakstā ir dažāda tipa objekti (FullTimeEmployee, HourlyEmployee, SalesEmployee), katrs no tiem izpilda savu specifisko 
//    algas aprēķina metodi, pateicoties run-time polimorfismam (bez jebkādām "is", "as" vai "GetType()" pārbaudēm).
// 2. PayrollCalculator nebija jāmaina (kas atbilst SOLID - OCP / Open/Closed principam), jo tas ir atvērts paplašināšanai, 
//    bet slēgts modifikācijām. Jaunā tipa darbinieks (SalesEmployee) vienkārši manto no Employee un ievieš savu CalculateSalary() versiju, 
//    savukārt kalkulators strādā ar vispārīgo Employee sarakstu.