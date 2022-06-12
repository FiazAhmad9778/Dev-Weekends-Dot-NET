namespace Constructor;

//static
//Embeded
//Parent
//Child


//Inner
//Parent
//Child


public class Parent
{
    public Parent()
    {
        Console.WriteLine("Parent");
    }
    static Parent()
    {
        Console.WriteLine("static");
    }
}
public class Child : Parent
{
    public Child()
    {
        Console.WriteLine("Child");
    }
    static Child()
    {
        Console.WriteLine("child");
    }
}


public class Memory
{
    public int a { get; set; }
    public string s { get; set; }
    public static int staticvalue = 1;
}

Memory m = new Memory();



public class Inner
{
    public Inner()
    {
        Console.WriteLine("Inner");
    }
}
