using System;
using ExemploPOO.Models;
using projeto_Pratica.Models;

namespace projeto_Pratica
{
    class Program
    {

        public delegate void operacao(int x, int y);
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            operacao op = new operacao(calc.somar); //ou
            // operacao op = calc.somar;
            op.Invoke(10, 19); // ou
            //op(10, 19);
            
            // const double pi = 3.14;
            // System.Console.WriteLine(pi);

            // Data data = new Data();
            // data.setMes(50);
            // data.ApresentarMes();
            
            //Aluno a1 = new Aluno("gusta", "ugagua", "Só nos compiuters");
            
            // Log _log = Log.getInstance();
            // _log.propriedadeLog = "teste 01";

            // Log _logII = Log.getInstance();
            // System.Console.WriteLine(_logII.propriedadeLog);
        }
    }
}
