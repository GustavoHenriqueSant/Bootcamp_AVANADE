using System;
using System.Collections.Generic;
using System.Linq;
using Pratica_Design.Classes_Design;

namespace Pratica_Design
{
    class Program
    {
        static void Main(string[] args)
        {
            // //==================TESTANDO O DESIGN SINGLETTON====================================//
            // Singletton example = Singletton.instanciacao(25);                                   //
            //                                                                                     //
            // System.Console.WriteLine($"Um nova instancia foi criado, seu id é {example.id}");   //
            //                                                                                     //
            // example = Singletton.instanciacao(300);                                             //
            // System.Console.WriteLine($"Um nova instancia foi criado, seu id é {example.id}");   //
            // //==================================================================================//

            int N = Convert.ToInt32(Console.ReadLine()), N_esferas = 0, sum = 1;
            List<int> lista_aux = new List<int>();

            for(int i = 2; i <= N; i++){
                lista_aux = fatoracao(i);
                for(int j = 2; j <= lista_aux[lista_aux.Count-1]; j++){
                    int expoente = lista_aux.Where(x => x == j).ToList().Count + 1;
                    sum *= expoente;
                }

                if(sum % 2 == 0)
                    N_esferas++;
                
                sum = 1;
            }

            System.Console.WriteLine($"O mínimo de esferaças que GOCÚ vai ter que achar é {N_esferas}");
        }

        static List<int> fatoracao(int n){
            List<int> lista_aux = new List<int>();
            
            for(int i = 2; i <= n; i++){
                while(n%i == 0){
                    lista_aux.Add(i);
                    n = n/i;
                }
            }

            return lista_aux;
        }

        static bool is_primo(int n){
            bool result = true;
            for(int i = 2; i < n/2; i++)
                if(n%i == 0)
                    result = false;

            return result;
        }
    }
}
