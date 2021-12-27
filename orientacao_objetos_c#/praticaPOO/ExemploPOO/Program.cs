using System;
using ExemploPOO.Models;
using ExemploPOO.Interfaces;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculadora calc = new Calculadora();
            System.Console.WriteLine(calc.dividir(8,2));

            // Computador c1 = new Computador("Ideapad");
            // System.Console.WriteLine(c1.ToString());
            
            // ContaCorrente c = new ContaCorrente();
            // c.creditar(1500);
            // c.getSaldo();
            
            // Aluno a1 = new Aluno();
            // a1.nome = "Gustavo";
            // a1.idade = 21;
            // a1.nota = 9;

            // a1.apresentar();

            // Professor p1 = new Professor();
            // p1.nome = "Rodrigo";
            // p1.idade = 42;
            // p1.salario = 19000;

            // p1.apresentar();

            // Retangulo r = new Retangulo();
            // r.definirMedidas(-15, 20);
            // Console.WriteLine("Um retângulo com tais meiddas possui área igual a " + r.getArea());
            // Pessoa p1 = new Pessoa("Gustavo Henrique", 21);
            // p1.apresentar();
        }
    }
}
