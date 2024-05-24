Console.WriteLine("Enter a six - digit number:");
int number = Convert.ToInt32(Console.ReadLine());
int num1 = number / 100000;
int num2 = number % 100000 / 10000;
int num3 = number % 10000 / 1000;
int num4 = number % 1000 / 100;
int nym5 = number % 100 / 10;
int num6 = number % 10;
Console.WriteLine($"{num6}{nym5}{num4}{num3}{num2}{num1}");