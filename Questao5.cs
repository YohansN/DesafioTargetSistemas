using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Target
{
    internal class Questao5
    {
        public static void QuintaQuestao()
        {
            Console.WriteLine("Digite uma frase para ser invertida: ");
            string frase = Console.ReadLine();
            char[] caracteres = new char[frase.Length];
            caracteres = frase.ToCharArray();

            int j = 0;
            char[] fraseInvertida = new char[frase.Length];
            for(int i = caracteres.Length-1; i >= 0; i--)
            {
                fraseInvertida[j] = caracteres[i];
                j++;
            }

            string novaFrase = new string(fraseInvertida);
            Console.WriteLine($"Antes: {frase} | Depois: {novaFrase}");

        }
    }
}
