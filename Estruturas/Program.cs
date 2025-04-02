namespace Estruturas
{
    class Program 
    {
        static void Main(string[] args)
        {

            //Se o código tiver uma linha não precisa de chaves
            if(25 != 32) //Se for verdadeiro rodar esse código
            {
                Console.WriteLine("É Diferente");
            }
            else if(25 != 1242) //Se a primeira for false e essa true rodar esse código
            {
                Console.WriteLine("É Diferente");

            }
            else //Se todar as anteriores ser false, rodar o else
            {
                Console.WriteLine("É igual");

            }

            int teste = 10;
            switch(teste) { //Testa várias condições
                case 1: Console.WriteLine(1); break;
                case 2: Console.WriteLine(2); break;
                case 3: Console.WriteLine(3); break;
                default: Console.WriteLine("Nada"); break; //Se nenhuma condição for atendida roda o default
            }

            //Laços de Repetição
            string superString = ")#()!#(@)!#!";
            //Declarar uma variável o contador, uma condição se for verdade, incrementar
            //Continua rodando ate a condicao ser false

            for(int i = 0; i < superString.Length; i++)
            {
                Console.WriteLine(superString[i]);
            }

            //Executar um código até a condiçao se tornar falsa

            int i = 10;
            while(i > 0)
            {
                Console.WriteLine("É Maior");
                i--; //Quando decrementar várias vezes e atingir 0, ele irá parar de excutar
            }

            //Executar um código independente se for verdadeiro ou falso UMA VEZ e depois testar o while
            //Se a condição for verdadeira entrar no while até se tornar falsa

            do {
                Console.WriteLine("Wiup");
            }
            while(i > 0);
        }
    }
}