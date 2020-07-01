using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cauculadoraFuncoesTeste
{
    class Program
    {
        static bool Main(string[] args)
        {
            //URNA ELETRONICA.
            //criar as variaveis, criar um laço de repetição para que outros eleitores possam votar
            //criar condições para que os votos vao para os candidatos
            //perguntar se vai querer encerar votação e mostrar os votos.

            bool continuar = true;
            int cand1 = 0;
            int cand2 = 0;
            int cand3 = 0;

            while (continuar)
            {
                Console.WriteLine("ESCOLHA SEU CANDIDATO");
                Console.WriteLine("JOÃO");
                Console.WriteLine("CALY");
                Console.WriteLine("FERNANDA");
                string voto = Console.ReadLine();

                if (voto == "JOÃO")
                    cand1++;
                else if (voto == "CARLY")
                    cand2++;
                else if (voto == "FERNANDA")
                    cand3++;
                else
                    Console.WriteLine("VOTO INVALIDO");

                Console.WriteLine("ERNCERRAR VOTAÇÃO");
                string encerrar = Console.ReadLine();

                if (encerrar == "S")
                    continuar = false;

            }
            Console.WriteLine("RESULTADO DA VOTAÇÃO");
            Console.WriteLine("JOÃO " +cand1);
            Console.WriteLine("CARLY " +cand2);
            Console.WriteLine("FERNANDA " +cand3);


    }   }
}
