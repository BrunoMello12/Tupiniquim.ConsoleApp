internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe a posição x do robô: ");
        int posicaoX = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe a posição y do robô: ");
        int posicaoY = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe a direção do robô: ");
        char direcao = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Informe o comando para mover o robô: ");
        string comando = Console.ReadLine();

        char[] comandoQuebrado = comando.ToUpper().ToCharArray();
        

        for(int i = 0; i < comandoQuebrado.Length; i++)
        {
            if (comandoQuebrado[i] != null)
            {
                switch (comandoQuebrado[i])
                {
                    case 'M':
                        if(direcao == 'N')
                        {
                            if (posicaoY < 5) posicaoY++;
                        }
                        else if (direcao == 'S')
                        {
                            if (posicaoY > 0) posicaoY--;
                        }
                        else if (direcao == 'O')
                        {
                            if (posicaoY > 0) posicaoX--;
                        }
                        else if (direcao == 'L')
                        {
                            if (posicaoY < 5) posicaoX++;
                        }
                        break;
                    case 'E':
                        if(direcao == 'N')
                        {
                            direcao = 'O';
                        }
                        else if (direcao == 'S')
                        {
                            direcao = 'L';
                        }
                        else if (direcao == 'L')
                        {
                            direcao = 'N';
                        }
                        else if (direcao == 'O')
                        {
                            direcao = 'S';
                        }
                        break;
                    case 'D':
                        if (direcao == 'N')
                        {
                            direcao = 'L';
                        }
                        else if (direcao == 'S')
                        {
                            direcao = 'O';
                        }
                        else if (direcao == 'L')
                        {
                            direcao = 'S';
                        }
                        else if (direcao == 'O')
                        {
                            direcao = 'N';
                        }
                        break;
                }
            }
        }
        Console.WriteLine("Informe a posição x do segundo robô: ");
        int posicaoX2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe a posição y do segundo robô: ");
        int posicaoY2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe a direção do segundo robô: ");
        char direcao2 = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Informe o comando para mover o segundo robô: ");
        string comando2 = Console.ReadLine();

        char[] comandoQuebrado2 = comando2.ToUpper().ToCharArray();
        

        for (int i = 0; i < comandoQuebrado2.Length; i++)
        {
            if (comandoQuebrado2[i] != null)
            {
                switch (comandoQuebrado2[i])
                {
                    case 'M':
                        if (direcao2 == 'N')
                        {
                            if (posicaoY2 < 5) posicaoY2++;
                        }
                        else if (direcao2 == 'S')
                        {
                            if (posicaoY2 > 0) posicaoY2--;
                        }
                        else if (direcao2 == 'O')
                        {
                            if (posicaoY2 > 0) posicaoX2--;
                        }
                        else if (direcao2 == 'L')
                        {
                            if (posicaoY2 < 5) posicaoX2++;
                        }
                        break;
                    case 'E':
                        if (direcao2 == 'N')
                        {
                            direcao2 = 'O';
                        }
                        else if (direcao2 == 'S')
                        {
                            direcao2 = 'L';
                        }
                        else if (direcao2 == 'L')
                        {
                            direcao2 = 'N';
                        }
                        else if (direcao2 == 'O')
                        {
                            direcao2 = 'S';
                        }
                        break;
                    case 'D':
                        if (direcao2 == 'N')
                        {
                            direcao2 = 'L';
                        }
                        else if (direcao2== 'S')
                        {
                            direcao2 = 'O';
                        }
                        else if (direcao2 == 'L')
                        {
                            direcao2 = 'S';
                        }
                        else if (direcao2 == 'O')
                        {
                            direcao2 = 'N';
                        }
                        break;
                }
            }
        }

        Console.WriteLine($"{posicaoX} {posicaoY} {direcao}");
        Console.WriteLine($"{posicaoX2} {posicaoY2} {direcao2}");


    }
}