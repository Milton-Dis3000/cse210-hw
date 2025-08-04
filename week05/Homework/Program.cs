using System;

class Program
{
    static void Main(string[] args)
    {
        // Creamos una instancia de la clase base Assignment.
        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        // Creamos una instancia de la clase derivada MathAssignment.
        // Observa que podemos llamar a GetSummary() (heredado) y GetHomeworkList() (propio).
        MathAssignment a2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        // Creamos una instancia de la clase derivada WritingAssignment.
        // Observa que podemos llamar a GetSummary() (heredado) y GetWritingInformation() (propio).
        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}