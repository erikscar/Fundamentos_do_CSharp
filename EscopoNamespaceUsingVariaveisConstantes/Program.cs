using System; 
//Importações de Bibliotecas
//System é um tipo base, não precisa ser importado
//Sempre deixar tudo organizado

namespace EscopoNamespaceUsingVariaveisConstantes {
    //Divisão física = Pastas
     //Divisão lógica de um programa = namespace, não podemos ter 2 classes com o mesmo namespace
     //IDEAL = 1 namespace e uma classe por arquivo
     //Normalmente acompanham o nome da classe
     //Na compilação os arquivos serão unificados e restará apenas a divisão lógica
    class Program { //C# sempre busca essa clase para iniciar o aplicativo

        public static void Main(string[] args) //Método que sempre será executado
        {
            //Varíavel = armazenar inormações que podem mudar, podemos usar "var" ou um TIPO para ela, UTILIZAR NOMES AUTO EXPLICATIVOS
            int teste; //Iniciando com 0
            int idade = 0;
            var idade2 = 1; //VAR Precisa ser inicializado

            //Constantes = Armazenam mas não podem ser alteradas, feitas com letras maísculas geralmente

            const int IDADE_MINIMA = 0; //Precisam ser inicializadas, var não funciona

            //Comentários de uma linha, NÃO SÃO EXECUTADOS
            /* Mais de uma Linha */
            /// <properties> propNotação XML (Meta Dados)
        }
    }
}