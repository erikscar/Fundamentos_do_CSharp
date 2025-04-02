namespace ConversoesEOperadores
{
    class Program 
    {
        public static void Main(string[] args) 
        {
            //Conversão Implícita, feitas através da passagem de dados
            //Só Ocorre se o TIPO E TAMANHO do dado for compátivel
            float value = 25.8F;
            int other = 25;

            value = other; //Conversão Implícita, somente passando dados, porque o número real possui o número inteiro,
            //  ao contrário não funciona

            //Conversão Explícita 
            //Ocorre quando os tipos de dados não são compátiveis, devemos informar o tipo a ser convertido ENTRE PARESENTESES
            
            int value1 = 100;
            //uint value3 = value1; //Erro SÓ VAI APARECER EM TEMPO DE EXECUÇÃO, EVITAR!
            uint value2 = (uint)value1; 

            //Parses
            //Método presente em todos os tipos primitivos e sempre espera uma string como parâmetro
            //Se gerar imcompatibilidade irá gerar erros

            string numberString = "100";
            //int number = numberString;//Erro
            int number = int.Parse(numberString); 
            int number1 = int.Parse("100");

            //Convert
            //Similiar ao Parse porém aceita outros tipos de dados, não somente a string
            //Se não conseguir converter gera erros em tempo de EXECUÇÃO
            int number3 = Convert.ToInt32("100");
            int number31 = Convert.ToInt32(10.2f);
            bool number4 = Convert.ToBoolean("false");
            
            //Operadores Aritméticos (Aceita tipos númericos)
            //+, -, *, / , Multiplicação e Divisão feitas primeiro, utilizar parenteses para definir prioridade

            //Operadores de Atribuição 
            //+=, -=, *=, /=, =, ++ e --

            //Operadores de Comparação, sempre retorna true ou false
            // ==, !=, >, >=, <, <=

            //Operadores Lógicos,
            // || (OU, atender uma condição apenas), && (E, atender todas as condições) e ! (NÃO, o contrário de um determinado valor)

            int x = 2;
            x += 4; //x = 6;
            x++; //x = 7;
            
            //x == 25; false
            //x != 25; true
            //x > 25; false
            
            int y = 12;
            bool teste = (x > 25) && (x < 40); //false
            bool ou = (x > 25) || (x < 40); //true
            bool negacao = !(x < 25); //false

        }
    }
}