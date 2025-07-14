    using System;
    using System.Collections.Generic; // Necesario para List<T>

    public class Resume
    {
        public string _name = "";
        public List<Job> _jobs = new List<Job>(); // Inicializar la lista aquí

        public void Display()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Jobs:");

            foreach (Job job in _jobs)
            {
                // Esto llama al método Display() de la clase Job
                job.Display();
            }
        }
    }
    