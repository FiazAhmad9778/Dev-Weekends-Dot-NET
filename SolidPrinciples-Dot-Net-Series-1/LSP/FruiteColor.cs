namespace SolidPrinciples_Dot_Net_Series_1.LSP
{
    public class Apple
    {
        public virtual string GetColor()
        {
            return "Red";
        }
    }
    public class Orange : Apple
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
}


public class Parent
{
    public string Name { get; set; }
    public string Description { get; set; }
}

public class Child : Parent
{

}


