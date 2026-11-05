public class SalesEmployee : Employee
{
    private decimal _baseSalary;
    private decimal _salesVolume;

    public SalesEmployee(string name, decimal baseSalary, decimal salesVolume) : base(name)
    {
        _baseSalary = baseSalary;
        _salesVolume = salesVolume;
    }

    public override decimal CalculateSalary()
    {
        // Alga = bāzes alga + 5% no pārdošanas apjoma
        return _baseSalary + (_salesVolume * 0.05m);
    }
}