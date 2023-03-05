using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target
{
    internal class Questao2
    {
        public static void SegundaQuestao()
        {
            int primeiroNumero = 0, segundoNumero = 1, proximoNumero;
            bool existe = false;

            Console.Write("Qual numero você deseja verificar se existe na sequencia de fibonacci? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i < 100; i++)
            {
                proximoNumero = primeiroNumero + segundoNumero;
                
                primeiroNumero = segundoNumero;
                segundoNumero = proximoNumero;

                if(n == proximoNumero)
                {
                    Console.WriteLine($"O número {n} existe na sequência fibonacci, na posicão {i}.");
                    existe = true;
                }
            }
            if(!existe)
                Console.WriteLine($"O número {n} não existe na sequência fibonacci.");
           
        }
    }
}
