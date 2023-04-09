using System;
using System.Numerics;

namespace ConceptsPrototype
{
    /// <summary>
    /// Prototype Pattern Demo
    /// </summary>

// O que é Padrão Protótipo?
// O padrão de design de protótipo é usado para criar um objeto duplicado ou clone do objeto atual para aprimorar o desempenho.
// Esse padrão é usado quando a criação de um objeto é cara ou complexa.



    class Program
    {
        static void Main(string[] args)
        {
            Developer dev = new Developer();
            dev.Name = "Rahul";
            dev.Role = "Team Leader";
            dev.PreferredLanguage = "C#";

            Developer devCopy = (Developer)dev.Clone();
            devCopy.Name = "Arif"; //Not mention Role and PreferredLanguage, it will copy above

            Console.WriteLine(dev.GetDetails());
            Console.WriteLine(devCopy.GetDetails());

            Typist typist = new Typist();
            typist.Name = "Monu";
            typist.Role = "Typist";
            typist.WordsPerMinute = 120;

            Typist typistCopy = (Typist)typist.Clone();
            typistCopy.Name = "Sahil";
            typistCopy.WordsPerMinute = 115;//Not mention Role, it will copy above

            Console.WriteLine(typist.GetDetails());
            Console.WriteLine(typistCopy.GetDetails());

            Console.ReadKey();

        }
    }
}
