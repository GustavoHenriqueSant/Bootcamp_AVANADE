using System;
using ExemploPOO.Models;
using ExemploPOO.Interfaces;
using ExemploPOO.Helper;
using System.IO;
using System.Collections.Generic;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentPath = "C:\\Users\\Gustavo\\workSpace\\Bootcamp_AVANADE\\orientacao_objetos_c#\\praticaPOO\\trabalhandoComArquivos";
            var listaString = new List<string>{"linha 1", "Linha 2", "Linha 3"};
            var incrementoList = new List<string>{"linha diacionada 1", "linha diacionada 2", "linha diacionada 3"};
            
            FileHelper helperF = new FileHelper();
            //helperF.listDrectory(currentPath);
            //helperF.listFiles(currentPath);
            //helperF.criarDerectory(Path.Combine(currentPath, "PasteTeste3", "SubPastaTeste3"));
            //helperF.apagarDirectory(Path.Combine(currentPath, "teste1"),  true);
            //helperF.criarArquivoTxt(Path.Combine(currentPath, "ArquivoTeste.txt"), "Meu nome é Gustavo Henrique, olá!");
            //helperF.criandoTextoStream(Path.Combine(currentPath, "arquivoTextStream.txt"), listaString);
            //helperF.incrementarTextoStream(Path.Combine(currentPath, "arquivoTextStream.txt"), incrementoList);
            //helperF.lerArquivo(Path.Combine(currentPath, "ArquivoTeste.txt"));
            //helperF.lerArquivoStream(Path.Combine(currentPath, "arquivoTextStream.txt"));
            // helperF.moverArquivo(Path.Combine(currentPath, "arquivoTextStream.txt"), Path.Combine(currentPath, "PasteTeste3", "SubPastaTeste3", "arquivoTextStream.txt"));
            //helperF.copiarArquivo(Path.Combine(currentPath, "ArquivoTeste.txt"), Path.Combine(currentPath, "PasteTeste3", "SubPastaTeste3", "TroqueioNome.txt"), false);
            helperF.deletarFile(Path.Combine(currentPath, "PasteTeste3", "SubPastaTeste3", "TroqueioNome.txt"));


            // ICalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.dividir(8,2));

            // Computador c1 = new Computador("Ideapad");
            // System.Console.WriteLine(c1.ToString());
            
            // ContaCorrente c = new ContaCorrente();
            // c.creditar(1500);
            // c.getSaldo();
            
            //Aluno a1 = new Aluno();
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
