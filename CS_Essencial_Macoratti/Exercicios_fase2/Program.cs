using Microsoft.VisualBasic;

//1 - Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato :  
//Aluno<nome> tem<idade> anos e nota<nota> usando a concatenação e a interpolação de strings.
string nome = "Paulo";
int idade = 17;
float nota = 7.5f;

Console.WriteLine($"Aluno " + nome + " tem " + idade + " anos e nota " + nota);
Console.WriteLine($"Aluno {nome} tem {idade} anos e nota {nota}");

//2 - Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de escapes.
Console.WriteLine($"Aluno {nome}\ntem {idade} anos\ne nota {nota}");

//3 - Para qual tipo de dados você pode converter um float implicitamente ?
//( ) int  
//(X) double
//(X) long
//(X) decimal

//4 - Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ? 
//( ) int para long
//( ) double para long
//(X) double para float
//(X) decimal para float
//(X) long para int
//( ) double para decimal

//5 - Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa
//usando a concatenação e também a interpolação de strings
Console.WriteLine("Entre com a primeira letra: ");
char letra1 = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Entre com a segunda letra: ");
char letra2 = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Entre com a terceira letra: ");
char letra3 = Convert.ToChar(Console.ReadLine());

Console.WriteLine($"As letras em ordem reversa são: " + letra3 + ", " + letra2 + ", " + letra1);
Console.WriteLine($"As letras em ordem reversa são: {letra3}, {letra2}, {letra1}");

//6 - Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
//(F) long resultado = 1.32;
//(V) var nome = “Maria”;
//(V) string resultado = 100.ToString();
//(V) A sequência de escape \n inclui uma nova linha
//(F) float f  = 5.45;  
//(V) decimal valor = (decimal)10.99f;
//(F) var status = null;
//(V) object o = 12.45m;
//(V) string titulo = true.ToString(); 
//(F) A sequencia \t inclui uma tabulação vertical

//7 - Escreva um programa para receber dois valores via teclado do tipo double e a seguir 
//realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo 
//exibindo o resultado:
Console.Write("Entre com o primeiro número do tipo double: ");
double numero1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Entre com o segundo número do tipo double: ");
double numero2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"{numero1} + {numero2} = {numero1 + numero2}");
Console.WriteLine($"{numero1} - {numero2} = {numero1 - numero2}");
Console.WriteLine($"{numero1} * {numero2} = {numero1 * numero2}");
Console.WriteLine($"{numero1} ^ {numero2} = {Math.Pow(numero1, numero2)}");
Console.WriteLine($"{numero1} / {numero2} = {numero1 / numero2}");
Console.WriteLine($"{numero1} % {numero2} = {numero1 % numero2}");

//8 - Faça um programa para calcular o resultado da fórmula de baskara dados os valores de 
//a b e c . Valores :  a = 1, b = 12 e c = -13
double a = 1.0;
double b = 12.0;
double c = -13.0;

double delta = (Math.Pow(b,2)) - (4 * a * c);
double x1 = ((-b) + Math.Sqrt(delta)) / 2 * a;
double x2 = ((-b) - Math.Sqrt(delta)) / 2 * a;

Console.WriteLine($"Para a = {a}, b = {b} e c = {c}, tem-se x1 = {x1} e x2 = {x2}");


//10 - Indique verdadeiro(V) ou falso(F) para as seguintes declarações de variáveis considerando 
//a nomenclatura usada:
//(V) string? nome; é um exemplo de nullable reference type;
//(F) para x igual a 0 , Console.WriteLine(x++); imprime o valor 1
//(F) A ordem de precedência dos operadores lógicos é :  ! , || e && (NOT, OR e AND)
//(V) para y igual a 0 , Console.WriteLine(++y); imprime o valor 1
//(F) (10 % 2 == 0) ? “Par” : “Impar”; Vai retornar “Impar”
//(F) Para x=25 e y=5 , a expressão ( y >= x ) && ( y <= x ); retorna true;
//(V) Os nullable reference types emitem um alerta em tempo de compilação para uso do null
//(F) Para x = 10 , o código Console.WriteLine(x+=x); imprime o valor 10;
//(F) Para x = 5, a expressão !(9 >= x) && x <= 7 || x == 5); retorna false;
//(V) O operador ?. permite verificar se um objeto é null e evitar o NullReferenceException
//(V) Qualquer tipo de dado pode ser declarado como anulável com a ajuda do operador "?"


