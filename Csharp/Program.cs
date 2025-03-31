//C# é um linguagem TIPADA, COMPILADA e GERENCIADA, criada em 2001, principal linguagem da Microsoft

//Gerenciado
//------Significa que sua execução depende de um gerenciador (C# = RUNTIME / CLR / CLR Runtime), gerencia memoria, alocamento de memória, segurança e recursos básicos.

//Compiladores
//----Compilação Inicial gera um código intermediário (INTERMEDIATE LANGUAGE (IL)) e depois compila, para que todas as linguagens possam ser compiladas em binário pelo mesmo compilador

//Intermediate Language (essa conversão é feita em JUST IN TIME)
//----Compilações diferentes, mas alocamento, gerenciamento e execução é a mesma, o CLR recebe um código do ambiente da microsoft e compila para o IL (onde o resultado é sempre o mesmo)

//CLI (Command Line Interface)
//Interface de Comandos via Ternminal
//-----dotnet run, dotnet new console, dotnet --version, dotnet --list-sdks, dotnet --list-runtimes

//Tipos de Projeto 
//----Class Library = Resultado final é uma DLL, sem interface
//----Console Application = Uma aplicação que roda no terminal
//----Web (ASP.NET, ASP.NET MVC, ASP.NET WEBAPI)
//----Testes (Microsoft Tests)

//dotnet new console -o "Nome da Pasta a ser Criada", ESPECIFICAR com o "-o"

//dotnet restore = Baixa os PACOTES necessários para executar
//dotnet build = Compila a aplicação
//dotnet clean = limpa os caches da aplicação
//dotnet run = Roda a aplicação

//Variáveis de Ambiente (Desenvolvimento, Homolocgação e Produção)
//----Cada ambiente possui suas config, chaves de acesso e conexões com banco de dados  
//dotnet run --environment=%SEU_AMBIENTE
//dotnet run --environment=development
//----O run não faz DEBUG

namespace Csharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
    }
}