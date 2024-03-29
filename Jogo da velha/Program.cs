using System.Runtime.InteropServices;

class Program
{
    class Resultado
    {
        public Resultado()
        {
            resultado = "-";
            disponivel = true;
            velha = false;
        }
        public string resultado { get; set; }
        public bool disponivel { get; set; }
        public bool velha { get; set; }

    }
    
       static void Main(string[] args)
    {
        Resultado velha = new Resultado();
        int opcao;
        int x = 99;
        string jogador = "X";
        Resultado a1 = new Resultado();
        Resultado a2 = new Resultado();
        Resultado a3 = new Resultado();
        Resultado b1 = new Resultado();
        Resultado b2 = new Resultado();
        Resultado b3 = new Resultado();
        Resultado c1 = new Resultado();
        Resultado c2 = new Resultado();
        Resultado c3 = new Resultado();

        for (int i = 0; i != 99; i++)
        {

           if (i%2 == 0)
            {
                jogador = "X";  
            }
           else
            {
                jogador = "O";
            }


            Console.Write(a1.resultado);
            Console.Write(b1.resultado);
            Console.WriteLine(c1.resultado);
            Console.Write(a2.resultado);
            Console.Write(b2.resultado);
            Console.WriteLine(c2.resultado);
            Console.Write(a3.resultado);
            Console.Write(b3.resultado);
            Console.WriteLine(c3.resultado);
            Console.WriteLine("--------------------");

            do
            {
                Console.WriteLine("Vez do jogador {0}", jogador);
                Console.Write("Selecione um número de 1 a 9 para jogar: ");
                opcao = int.Parse(Console.ReadLine());
                if (opcao < 1 || opcao > 9) 
                { 
                    Console.WriteLine("DIGITE UMA OPÇÃO VÁLIDA");
                    Console.ReadKey();
                }
            } while (opcao < 1 || opcao > 9);
            Console.Clear();

            if (jogador == "X") {
                switch (opcao)
                {
                    case 1:
                        if (a1.disponivel == true)
                        {
                            a1.resultado = "X";
                            a1.disponivel = false;
                        }
                        else
                        {
                            Console.WriteLine("Digite uma casa disponível!!");
                            i--;
                        }
                        break;

                    case 2:
                        if (b1.disponivel == true)
                        {
                            b1.resultado = "X";
                            b1.disponivel = false;
                        }
                        else
                        {
                            Console.WriteLine("Digite uma casa disponível!!");
                            i--;
                        }
                        break;

                    case 3:
                        if (c1.disponivel == true)
                        {
                            c1.resultado = "X";
                            c1.disponivel = false;
                        }
                        else
                        {
                            Console.WriteLine("Digite uma casa disponível!!");
                            i--;
                        }
                        break;

                    case 4:
                        if (a2.disponivel == true)
                        {
                            a2.resultado = "X";
                            a2.disponivel = false;
                        }
                        else
                        {
                            Console.WriteLine("Digite uma casa disponível!!");
                            i--;
                        }
                        break;

                    case 5:
                        if (b2.disponivel == true)
                        {
                            b2.resultado = "X";
                            b2.disponivel = false;
                        }
                        else
                        {
                            Console.WriteLine("Digite uma casa disponível!!");
                            i--;
                        }
                        break;

                    case 6:
                        if (c2.disponivel == true)
                        {
                            c2.resultado = "X";
                            c2.disponivel = false;
                        }
                        else
                        {
                            Console.WriteLine("Digite uma casa disponível!!");
                            i--;
                        }
                        break;

                    case 7:
                        if (a3.disponivel == true)
                        {
                            a3.resultado = "X";
                            a3.disponivel = false;
                        }
                        else
                        {
                            Console.WriteLine("Digite uma casa disponível!!");
                            i--;
                        }
                        break;

                    case 8:
                        if (b3.disponivel == true)
                        {
                            b3.resultado = "X";
                            b3.disponivel = false;
                        }
                        else
                        {
                            Console.WriteLine("Digite uma casa disponível!!");
                            i--;
                        }
                        break;

                    case 9:
                        if (c3.disponivel == true)
                        {
                            c3.resultado = "X";
                            c3.disponivel = false;
                        }
                        else
                        {
                            Console.WriteLine("Digite uma casa disponível!!");
                            i--;
                        }
                        break;
                }
                if (a1.resultado == "X" && b1.resultado == "X" && c1.resultado == "X") { i = 98; }
                else if (a2.resultado == "X" && b2.resultado == "X" && c2.resultado == "X") { i = 98; }
                else if (a3.resultado == "X" && b3.resultado == "X" && c3.resultado == "X") { i = 98; }
                else if (a1.resultado == "X" && a2.resultado == "X" && a3.resultado == "X") { i = 98; }
                else if (b1.resultado == "X" && b2.resultado == "X" && b3.resultado == "X") { i = 98; }
                else if (c1.resultado == "X" && c2.resultado == "X" && c3.resultado == "X") { i = 98; }
                else if (a1.resultado == "X" && b2.resultado == "X" && c3.resultado == "X") { i = 98; }
                else if (a3.resultado == "X" && b2.resultado == "X" && c1.resultado == "X") { i = 98; }
            }
            else { 
                    switch (opcao)
                    {
                    case 1:
                        if (a1.disponivel == true)
                        {
                            a1.resultado = "O";
                            a1.disponivel = false;
                        }
                        else
                        {
                            Console.WriteLine("Digite uma casa disponível!!");
                            i--;
                        }
                        break;

                    case 2:
                        if (b1.disponivel == true)
                        {
                            b1.resultado = "O";
                            b1.disponivel = false;
                        }
                        else
                        {
                            Console.WriteLine("Digite uma casa disponível!!");
                            i--;
                        }
                        break;

                    case 3:
                        if (c1.disponivel == true)
                        {
                            c1.resultado = "O";
                            c1.disponivel = false;
                        }
                        else
                        {
                            Console.WriteLine("Digite uma casa disponível!!");
                            i--;
                        }
                        break;

                    case 4:
                        if (a2.disponivel == true)
                        {
                            a2.resultado = "O";
                            a2.disponivel = false;
                        }
                        else
                        {
                            Console.WriteLine("Digite uma casa disponível!!");
                            i--;
                        }
                        break;

                    case 5:
                        if (b2.disponivel == true)
                        {
                            b2.resultado = "O";
                            b2.disponivel = false;
                        }
                        else
                        {
                            Console.WriteLine("Digite uma casa disponível!!");
                            i--;
                        }
                        break;

                    case 6:
                        if (c2.disponivel == true)
                        {
                            c2.resultado = "O";
                            c2.disponivel = false;
                        }
                        else
                        {
                            Console.WriteLine("Digite uma casa disponível!!");
                            i--;
                        }
                        break;

                    case 7:
                        if (a3.disponivel == true)
                        {
                            a3.resultado = "O";
                            a3.disponivel = false;
                        }
                        else
                        {
                            Console.WriteLine("Digite uma casa disponível!!");
                            i--;
                        }
                        break;

                    case 8:
                        if (b3.disponivel == true)
                        {
                            b3.resultado = "O";
                            b3.disponivel = false;
                        }
                        else
                        {
                            Console.WriteLine("Digite uma casa disponível!!");
                            i--;
                        }
                        break;

                    case 9:
                        if (c3.disponivel == true)
                        {
                            c3.resultado = "O";
                            c3.disponivel = false;
                        }
                        else
                        {
                            Console.WriteLine("Digite uma casa disponível!!");
                            i--;
                        }
                        break;
                }
                if (a1.resultado == "O" && b1.resultado == "O" && c1.resultado == "O") { i = 98; }
                else if (a2.resultado == "O" && b2.resultado == "O" && c2.resultado == "O") { i = 98; }
                else if (a3.resultado == "O" && b3.resultado == "O" && c3.resultado == "O") { i = 98; }
                else if (a1.resultado == "O" && a2.resultado == "O" && a3.resultado == "O") { i = 98; }
                else if (b1.resultado == "O" && b2.resultado == "O" && b3.resultado == "O") { i = 98; }
                else if (c1.resultado == "O" && c2.resultado == "O" && c3.resultado == "O") { i = 98; }
                else if (a1.resultado == "O" && b2.resultado == "O" && c3.resultado == "O") { i = 98; }
                else if (a3.resultado == "O" && b2.resultado == "O" && c1.resultado == "O") { i = 98; }
            }
            if (a1.disponivel == false && b1.disponivel == false && c1.disponivel == false && a2.disponivel == false && b2.disponivel == false && c2.disponivel == false && a3.disponivel == false && b3.disponivel == false && c3.disponivel == false && i != 98)
            {
                velha.velha = true;
                i = 98;
            }
        }
        Console.WriteLine("-------------------------------------");
        if (velha.velha == true)
        {
            Console.WriteLine("VISH, DEU VELHA!!");
        }
        else
        {
            Console.WriteLine("PARABÉNS, O JOGADOR '{0}' GANHOU A PARTIDA!!!", jogador);
        }
    }
}