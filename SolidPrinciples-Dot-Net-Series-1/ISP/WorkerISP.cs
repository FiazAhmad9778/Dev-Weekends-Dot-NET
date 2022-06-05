namespace SolidPrinciples_Dot_Net_Series_1.ISP
{
    public interface IWorker
    {
        string Id { get; set; }
        string Name { get; set; }
        string Email { get; set; }
        float MonthlySalary { get; set; }
        float OtherBenefits { get; set; }
        float HourlyRate { get; set; }
        float HoursInMonth { get; set; }
        float CalculateNetSalary();
        float CalaculateWorkedSalary();
    }

    public class FullTimeEmployee : IWorker
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public float MonthlySalary { get; set; }
        public float OtherBenefits { get; set; }
        public float HourlyRate { get; set; }
        public float HoursInMonth { get; set; }
        public float CalculateNetSalary() => MonthlySalary + OtherBenefits;
        public float CalaculateWorkedSalary() => throw new NotImplementedException();
    }

    public class ContractEmployee : IWorker
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public float MonthlySalary { get; set; }
        public float OtherBenefits { get; set; }
        public float HourlyRate { get; set; }
        public float HoursInMonth { get; set; }
        public float CalculateNetSalary() => throw new NotImplementedException();
        public float CalaculateWorkedSalary() => HourlyRate * HoursInMonth;
    }
}
