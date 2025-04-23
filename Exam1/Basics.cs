


namespace Exam1;

public class Q1_Add
{
    public static int Add(int a,int b)
    {
        return a+b;
    }
}

public class Basics
{
    public static void Q2MultiplyAndReset(ref int v, ref int f)
    {
        v=v*f;
        f=1;
    }

    public static void Q5TryCatchFinally(bool v, List<string> log, bool A)
    {
        if(v)
        {
            foreach(var a in log)
            {
                if(string.IsNullOrWhiteSpace(a))
                throw new InvalidDataException();
            }
            
        }

        
    }

    public static void Q5TryCatchFinally(bool v, List<string> log)
    {

    }
}

public class Type2
{
    public int Count { get; set; }
}

public class Type1
{
    private int count;
    private int copy;
    public int Count
    {
        get { return copy; }
        set { 
            copy=count;
            count = value; 
            }
    }
    
}

public class Q4Person
{
    
    public string Name { get; set; }
    public int Age { get; set; }

    public Q4Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Introduce()
    {
        return $"Hello, my name is {Name} and I am {Age} years old.";
    }
}

public class temp
{
    private static double celsius;
    public static double Celsius
    {
        get {return celsius;
           }
        set { celsius = value;
            fahrenheit=32+(celsius*(9.0/5)); }
    }

    private static double fahrenheit;
    public static double Fahrenheit
    {
        get { return fahrenheit;
         }
        set { fahrenheit = value;
            celsius=5.0/9*(fahrenheit-32);; }
    }
    
    
}
public class ShapeUtils
{
    public static double Q7TotalArea(IShape[] shapes)
    {
        double sum=0;
        foreach(var n in shapes)
        {
            sum+= n.GetArea();
        }
        sum=sum-Math.PI;

        return sum;
    }
}
 
public interface IShape
{
    public double GetArea();
    public double GetPerimeter();
}

public class Q7Circle:IShape
{
    public double radius;

    public Q7Circle(double radius)
    {
        this.radius = radius;
    }

    public double GetArea()
    {
        return 2*Math.PI*radius;
    }

    public double GetPerimeter()
    {
        return radius* Math.PI * 2.0;
    }
}

public class Q7Rectangle:IShape
{
    public double width;
    public double height;

    public Q7Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public double GetArea()
    {
        return width*height;
    }

    public double GetPerimeter()
    {
        return 2*(width+height);
    }
}

