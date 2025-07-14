    using System;
    // No necesitamos System.Collections.Generic aquí si solo usamos Job y Resume

    class Program
    {
        static void Main(string[] args)
        {
            // Crear instancias de Job
            Job job1 = new Job();
            job1._jobTitle = "Software Engineer";
            job1._company = "Microsoft";
            job1._startYear = 2019;
            job1._endYear = 2022;

            Job job2 = new Job();
            job2._jobTitle = "Manager";
            job2._company = "Apple";
            job2._startYear = 2022;
            job2._endYear = 2023;

            // Crear una instancia de Resume
            Resume myResume = new Resume();
            myResume._name = "Allison Rose"; // Establecer el nombre del currículum

            // Añadir los trabajos a la lista de trabajos del currículum
            myResume._jobs.Add(job1);
            myResume._jobs.Add(job2);

            // Mostrar el currículum completo llamando al método Display() de Resume
            myResume.Display();
        }
    }
    