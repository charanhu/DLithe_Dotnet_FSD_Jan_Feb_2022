using System;
public interface Drawable
{
    void draw();
}
public class Rectangle : Drawable
{
    public void draw()
    {
        Console.WriteLine("Hello!, Drawing Rectangle");
    }
}
public class Circle : Drawable
{
    public void draw()
    {
        Console.WriteLine("Hello!, Drawing Circle");
    }
}
public class TestInterface
{
    public static void Main()
    {
        Drawable d;
        Console.WriteLine("Interface");
        d = new Rectangle();
        d.draw();
        d = new Circle();
        d.draw();
    }
}