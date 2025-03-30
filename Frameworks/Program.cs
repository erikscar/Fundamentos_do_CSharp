//Framework
//----É uma estrutura / UM CONJUNTO DE BIBLIOTECAS código já feito por outra pesso que pode ser reutilizado em vários casos, para não precisar fazer tudo do zero
//----Como o .NET, trazendo recursos comuns já prontos que já são validados e testados

//C# é a linguagem, .NET é o framework

//.NET Framework foi a primeira versão, podendo ter varias versões instaladas ao mesmo tempo(SIDE BY SIDE), compátivel só com windows e considerado legado

//.NET Core versão atual, veio para suportar Mac e Linux, Core = Núcleo, algo que é essencial, MUITO MAIS OTIMIZADO

//.NET Standard, vai garantir que rode em ambos, não é um framework é um contrato (SURFACE API), garante a compatibilidade
//.NET Framework e .NET Core coexistem e podem ser utilzados no mesmo projeto, como garantir que vai rodar?

//.NET 5+, não é mais CORE ou FRAMEWORK, é a unificação dos dois, ele nasceu com o CORE(núcleo apenas o essencial) e agora tem muita coisa então foi atualizado seu nome

//Lançamentos / Releases
//.NET Framework era atualizado sem data
//.Net Core Semestral
//.NET 5+ Anual
//LTS = LONG TERM SUPPORT, .NET Framework tinha em todos as versões, .NET Core apenas as com final 1, .NET 5+ versões maiores


//Versionamento
//Alpha > Beta > Release Candidate > Final
//3 Partes, Major (Primeiro Número, Breaking Changes) pode ter incompatibilidade, Minor(Segundo Número, Backward Compatibility) e Patch (Terceiro Número, Bugs Fix)

//Runtime
//Executa a aplicação, apenas executa
//3 Partes, ASP.NET, Desktop, .NET (sem interface), as versões de cada precisam ser compátiveis

//SDK - Software Development Kit
//Tudo que precisa para criar aplicações com o runtime integrado, não utilizar para produção, usar apenas o RUNTIME para executar

