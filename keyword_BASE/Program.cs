using System;

class Person
{
    public string Name { get; set; }

    public virtual void Introduce()
    {
        Console.WriteLine("Hi, my name is " + Name);
    }
}

class Student : Person
{
    public string Major { get; set; }

    public override void Introduce()
    {
        base.Introduce();
        Console.WriteLine("I am majoring in " + Major);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        student.Name = "Alona";
        student.Major = "IT";
        student.Introduce();

        Console.ReadLine();
    }
}
