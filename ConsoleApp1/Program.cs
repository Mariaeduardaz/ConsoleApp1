using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string comando = "EMEMEMEMM";
           char sentido = 'N';
           int localizacaoY = 1;
           int localizacaoX = 2;

            char[] instrucoes = comando.ToCharArray();
            for (int posicao = 0; posicao < instrucoes.Length; posicao++)
            {
                if (instrucoes[posicao] == 'M')
                {
                    if (sentido == 'N')
                        localizacaoY = localizacaoY + 1;

                    else if (sentido == 'S')
                        localizacaoX = localizacaoX - 1;

                    else if (sentido == 'L')
                        localizacaoY = localizacaoY + 1;

                    else if (sentido == 'O')
                         localizacaoX = localizacaoX - 1;

                }

                if (instrucoes[posicao] == 'E')
                {
                    if (sentido == 'N') sentido = 'O';
                    else if (sentido == 'O') sentido = 'S';

                    else if (sentido == 'S') sentido = 'L';

                    else if (sentido == 'L') sentido = 'N';
                }

                if (instrucoes[posicao] == 'D')
                {
                    if (sentido == 'N') sentido = 'L';
                    else if (sentido == 'O') sentido = 'N';

                    else if (sentido == 'S') sentido = 'O';

                    else if (sentido == 'L') sentido = 'S';


                }
                   
                







            }
            Console.WriteLine("Localizacao x " + localizacaoX);
            Console.WriteLine("Localizacao y " + localizacaoY);
            Console.WriteLine("sentido " + sentido);
            Console.ReadLine();
              
            
            




        }
    }
}
