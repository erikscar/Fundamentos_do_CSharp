namespace Parte2 {
    class Program {
        public static void Main(string[] args)
        {
            //TIPOS = Siple Types, Enums, Structs e Nullable Types
            //Tipos otimizam a memória, cada um tem sua memória e um limite
            //Tipos Primitivos ou buil-in types ou Tipos de Valor
            //Temos os tipos complexos que são u conjunto de tipos primitivos


            //Tipo byte e sbyte(Números Negativos) (Representar um Byte de alguma informação) s = signed ou seja com sinal // u = unsigned ou seja se sinal
            byte myByte = 127;
            sbyte mySByte = -127;

            //Número Inteiros = short, ushort, int, uint, long, ulong (u = unsigned ou seja se sinal, por padrão eles já aceitam sinal)
            short idadeJoao = 10;
            int idade = 25;    //Var por padrão utiliza ele
            long idadeMaria = 321321;

            //Números Reais (Números com ponto flutuante) = float (Notação F), double e decimal (Notação M), não precisa de signed ou unsigned
            float salario = 4.300f;
            double salarioAlternativo = 4.700; //Var por padrão utiliza ele
            decimal salaioAnual = 31.323m;

            //Tipo Booleano = bool, recebe true ou false
            bool isRegister = false;
            bool isValid = true;
            var expired = false;

            //Tipo Char = char, armazenar UM caractere em formato Unicode(Univeseral), sempre com aspas simples
            char firstLetter = 'a';
            var secondLetter = 'B';

            //Tipo String = string, armazenar uma cadeia de chars, sempre com aspas duplas
            string thirdLetter = "c"; //Não tem problema armazenar apenas um caractere nela
            string nameAndAge = "Erik Scarcela 21 Anos"; 
            var numberInString = "41241";

            //Tipo Var = var, ele INFERE um tipo padrão do primeiro valor atribuído (Não pode Mudar)
            var age = 2; //Essa variável será sempre um inteiro
            //age = "2 anos"; //Erro

            //Tipo Object = object, tipo objeto também pode receber qualquer valor ALGO DESCONHCIDO, não possui Intelissense (Sem ajuda da IDE)
            object quantidade; //Não sabemos o tipo, porém é valido, ao contrário de "var" que gera erro
            quantidade = 1;
            quantidade = 2.5;
            quantidade = "40kg";


            //VOID = Espaço Vazio, NULL = Significa nada, é diferente de 0, todo tipo pode receber null desde que seja marcado como Nullable Type (?)
            //int anotherAge = null; //Erro deve ser marcado com ?
            int? myAge;
            myAge = 10;
            myAge = null;

            //ALIAS, como se fosse um apelido
            //Int32 = int
            int idade3 = 25; //Alias, escrevemos mais rápido
            Int32 idade4 = 25; //Tipo

            //System.String = string
            System.String texto = "Batata";
            string texto1 = "Batata";
        }
    }
}