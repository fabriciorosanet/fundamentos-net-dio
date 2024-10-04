using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using ExemploFundamentos.Models;


// string opcao;
// bool exibirMenu = true;

// while(exibirMenu)
// {
//     Console.WriteLine("Digite a sua opção: ");
//     Console.WriteLine("1 - cadastrar cliente ");
//     Console.WriteLine("2 - buscar cliente ");
//     Console.WriteLine("3 - apagar cliente ");
//     Console.WriteLine("4 - Encerrar ");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("cadastro de cliente");
//             break;

//         case "2":
//             Console.WriteLine("busca de cliente");
//             break;

//         case "3":
//             Console.WriteLine("apagar cliente");
//             break;

//         case "4":
//             Console.WriteLine("Encerrar");
//             exibirMenu = false;
//             // Environment.Exit(0);
//             break;
//     }
// }



// Laço de repetição DO WHILE

// int soma = 0, numero = 0; 

// do
// {

//     Console.WriteLine("Digite um Número: ");
//     numero = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Digite 0 para parar o programa e realizar a soma dos valores digitados ");

//     soma += numero;

// }while(numero != 0);

// Console.WriteLine($"Total da soma dos número digitados é: {soma}");

// Laço repetição WHILE

// int numero = 5;
// int contador = 1;

// while (contador <= 10)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//     contador++;

//     if (contador == 9)
//     {
//         break;
//     }

// }

// Laço de repetição -> FOR

// int numero = 5;

// for (int contador = 0; contador <= 10; contador ++) //estrutura padrão do laço FOR -> 3 condições dentro do laço
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");

// }


// Calculadora calculadora =  new Calculadora();

// calculadora.Somar(5, 5);
// calculadora.Subtrair(50, 40);
// calculadora.Multiplicar(10, 5);
// calculadora.Dividir(5, 2);
// calculadora.Potencia(4, 4);
// calculadora.Seno(30);
// calculadora.Coseno(30);
// calculadora.Tangente(30);
// calculadora.RaizQuadrada(5);

// using operador NOT (!)
// Operador de negação NOT(!) faz a inversão de um valor bolleano

// bool choveu = false;
// bool estaTarde = false;

// if( !choveu && !estaTarde) // o sinal de negação, faz com que o bloco if seja executado, mesmo com o resultado False
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedalar um outro dia");
// }

// using operador AND/E
// No Operador AND só teremos uma saida positiva se todas as condições forem verdadeiras
// Operador mais restritivo

// bool possuiPresencaMinina = true;
// double media = 5.5; 

// if (possuiPresencaMinina && media >= 7) // esse if com o operador AND valida se as duas condições sao true 
// {
//     Console.WriteLine("Aprovado"); // se sim, impreme a resposta APROVADO
// }
// else
// {
//     Console.WriteLine("Reprovado");
// }

// // uso do operador OR
// bool ehMaiorDeIdade = false;
// bool possuiAutorizacaoDoResponsavel = true;


// // o if sempre valida se sua validação é true -> 
// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel) // o sinal || pipe indica que o operador logico é OU/OR
// {
//     Console.WriteLine("Entrada Liberada");
// }
// else // o false o else se encarrega de analisar
// {
//     Console.WriteLine("Entrada não Liberada");
// }

// // explicação sobre o Operador OR lógico Condicional || -> 
// // O resultado de x || y será true se x ou y for avaliado como true. 
// // Caso contrário, o resultado será false. Se x for avaliado como true, y não será avaliado.
// // Nesse caso, só poderá dar FALSE se as duas condições forem FALSE

// Console.WriteLine("Digite uma letra: ");

// string letra = Console.ReadLine();

// switch (letra) // ele olha para a variavel declarada
// {                                           
//     case "a":   // case é comos e fosse um IF
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal"); // printa na tela 
//         break; // pausa o programa
//     default: // como se fosse um else
//         Console.WriteLine("Não é uma vogal"); //printa na tela
//         break;    // pausa o programa
// }

// if  (letra == "a" || // sinal de OU
//      letra == "e" ||
//      letra == "i" ||
//      letra == "o" ||
//      letra == "u")
// {
//     Console.WriteLine("Vogal");
// }     
// else
// {
//     Console.WriteLine("Não é uma vogal!");
// }


// if (letra == "a")
// {
//     Console.WriteLine("Vogal");
// }

// else if (letra == "e")
// {
//     Console.WriteLine("Vogal");
// }

// else if (letra == "i")
// {
//     Console.WriteLine("Vogal");
// }

// else if (letra == "o")
// {
//     Console.WriteLine("Vogal");
// }

// else if (letra == "u")
// {
//     Console.WriteLine("Vogal");
// }

// else
// {
//     Console.WriteLine("Não é uma vogal!");
// }

// int quantidadeEmEstoque = 10;

// int quantidadeCompra = 9;

// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");


// if(quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda Invalida!");
// }

// else if (possivelVenda) // else if seguinifica continuação do IF inicial 
// {
//     Console.WriteLine("Venda Realizada.");
// }
// else // da a saida final para caso as condições acima não sejam atendidas
// {
//     Console.WriteLine("Desculpe não temos a quantidade deseja em estoque.");
// }

// instanciando a classe Pessoa do pacote de Models

// Pessoa p = new Pessoa();

// p.Nome = "Fabrício Rosa";
// p.Idade = 24;
// p.Apresentar();