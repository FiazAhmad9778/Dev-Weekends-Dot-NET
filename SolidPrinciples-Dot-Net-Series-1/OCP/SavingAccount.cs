namespace SolidPrinciples_Dot_Net_Series_1.OCP
{
    public class SavingAccount
    {
        public void CalculateInterest(string accountType)
        {
            if (accountType == "Regular")
            {
                //Calculate interest for regular saving account based on rules and   
                // regulation of bank  
            }
            else if (accountType == "Salary")
            {

            }
        }
    }

    public interface IAccount
    {
        public void CalculateInterest(string accountType);
    }

    public class RegularAccount : IAccount
    {
        public void CalculateInterest(string accountType)
        {

        }
    }

    public class SalaryAccount : IAccount
    {
        public void CalculateInterest(string accountType)
        {

        }
    }

    public class FreelancerAccount : IAccount
    {
        public void CalculateInterest(string accountType)
        {

        }
    }


    public class Parent
    {

        public void parentMethod()
        {

        }

    }


    public class Child : Parent
    {
        public void childMethod()
        {

        }
    }

}
