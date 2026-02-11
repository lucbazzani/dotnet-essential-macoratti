//1 - Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor.
using System.Runtime.Intrinsics.X86;

byte idade = 35;
Console.WriteLine($"idade: {idade}");

//2- Crie uma variável chamada nome e  atribua o valor "Maria" e exiba o seu valor.
string nome = "Maria";
Console.WriteLine($"nome: {nome}");

//3- Crie uma variável chamada altura e atribua a ela o valor 3.45.
float altura = 3.45f;
Console.WriteLine($"altura: {altura}");

//4- Crie uma variável chamada data e atribua a ela a data 04/09/1999 e exiba o seu valor.
DateTime data = new DateTime(1999, 09, 04);
Console.WriteLine($"data: {data}");

//5 - Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor;
const byte ANO = 12;
Console.WriteLine($"ANO: {ANO}");


//6 - Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o valor 7.80 e exiba o seu valor.
double? nota = 7.8;
Console.WriteLine($"nota: {nota}");

//7- Quais as diferenças entre os tipos por valor e os tipos por referência?
/*
 * Resposta: Tipos de valor armazenam o dado em si e são alocados na memória Stack. 
 *           Tipos por referência não armazenam o dado em si, mas a referência (pointer) de onde aquele dado está alocado na memória Heap.
 */


//8- Inclua o tipo de dados correto entre os parênteses nas seguintes declarações de variáveis:
//(byte ou int)  x = 10;               
//(float)  numero = 7.99;              
//(char)  letra = 'C';              
//(float)  temperatura = 27.4f;              
//(bool)  ativo  = false;             
//(string)  nome = "Manoel";             
//(decimal)  salario = 950.99m;             
//(DateTime)  hoje =  DateTime.Now;

//9 - Dada as variáveis declaradas a seguir classifique-as em tipos por valor(V) e tipos por 
//referência (R) :
//(V) int n = 1;
//(R) string titulo = "A vida";
//(V) float f = 12.45f;
//(V) double d = 5.45;
//(V) decimal valor = 10.99m;
//(V) char sexo = ‘M’;
//(R) object o = null;

//10 - O que é um nullable type e qual a sua utilidade ?
/*
 * Resposta: um tipo de valor que permite receber valor null.
 *           Útil quando trabalha-se com banco de dados e o valor de alguma coluna de uma tabela pode ser nulo ou vazio.
 *           
 */

//11- O que é Camel Case ? Dê um exemplo de sua aplicação.
/*
 * Resposta: convenção de escrita para nomear variáveis, parâmetros e campos internos privados no C#. Exemplos: dataNascimento, valorTotal, nomeCompleto
 *           
 */


//12- O que é Pascal Case ? Dê um exemplo de sua aplicação.
/*
 * Resposta: convenção de escrita para nomear classes, métodos, interfaces e propriedades no C#. Exemplos: Pessoa, CalculaValor, WriteLine
 *           
 */

//13 - Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a 
//seguir imprima o valor da soma de x com y. (Use o operador aritmético + para realizar a 
//operação de soma)
int x = 77;
int y = 66;
int soma = x + y;
Console.WriteLine($"x + y = {soma}");

//14- Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e string.
/*
 * Resposta: bool - false
 *           char - '\0'
 *           int - 0
 *           double - 0.0
 *           float - 0.0f
 *           decimal - 0.0m
 *           string - null           
 */

//15 - Indique verdadeiro(V) ou falso(F) para as seguintes declarações de variáveis 
//considerando a nomenclatura usada:
//(F) double 1valor = 12.45;
//(F) string #nome = "Pedro";    
//(V) float _temperatura = 12.45f;
//(F) double int = 5;
//(F) decimal renda extra = 91.45m;
//(F) bool status$conta = false;
//(V) string titulo3 = “Tópico 1”;
//(V) float salario_mensal = 1999.55f;
//(V) int percentualValorDesconto = 5;
//(V) const bool MENSALIDADE_EM_DIA = true;

Console.ReadKey();