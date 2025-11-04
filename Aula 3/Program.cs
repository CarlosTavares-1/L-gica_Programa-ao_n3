// See https://aka.ms/new-console-template for more information

//int x = 1;
//int y = 1;
//float z = 2;
//double resultado = (x + y + z);


//Console.WriteLine("Hello, World!");
//Console.WriteLine(resultado > 100);

//Console.WriteLine("\n-----\n");

//string nome = "Carlos";
//string sobrenome = "Vitor";
//Console.WriteLine(nome + sobrenome);

//Console.WriteLine("\n-----\n");

//Console.WriteLine("Escreva seu nome.");
//string nomeUsuario = Console.ReadLine();
//Console.WriteLine("O seu nome é: " + nomeUsuario);

//Console.WriteLine("Qual a sua idade?");
//string idadeUsuarioString = Console.ReadLine();
//Console.WriteLine("A sua idade é"-- );

//int idadeUsuario = int.Parse(idadeUsuarioString);





//int n1;
//int n2;

//Console.WriteLine("Informe um numero inteiro:");
//n1 = int.Parse(Console.ReadLine());

//Console.WriteLine("Informe outro numero inteiro:");
//n2 = int.Parse(Console.ReadLine());

//Console.WriteLine("Os numeros informados sao: " + n1 + " e " + n2 + ".");





string n1, n2;

Console.WriteLine("Informe um numero inteiro:");
n1 = Console.ReadLine();
Console.WriteLine("Informe outro numero:");
n2 = Console.ReadLine();

int n1int = int.Parse(n1);
int n2int = int.Parse(n2);
int soma = n1int + n2int;

Console.WriteLine("O resultado da soma é: " + soma);
