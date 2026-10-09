using System;

class Program
{
    static void Main(string[] args)
    {
        // Instancia de Persona
        PersonaEjercicio persona = new PersonaEjercicio("Carlos", "Gómez", 12345678);
        Console.WriteLine(persona.Presentarse());

        // Instancia de Aprendiz (puedes usar tus datos de ADSO y ficha 3314619)
        Aprendiz aprendiz = new Aprendiz("María José", "Medina", 98765432, 3314619, "Análisis y Desarrollo de Software (ADSO)");
        Console.WriteLine(aprendiz.Presentarse());

        Console.ReadKey();
    }
}