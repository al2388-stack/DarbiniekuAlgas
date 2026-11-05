using System.Collections.Generic;

public class PayrollCalculator
{
    public decimal TotalSalary(List<Employee> employees)
    {
        decimal total = 0;
        foreach (var employee in employees)
        {
            total += employee.CalculateSalary();
        }
        return total;
    }
}