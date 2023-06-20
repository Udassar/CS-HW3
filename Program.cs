// Console.Write("Vvedite koordinatu A1: ");
// int a1 = Convert.ToInt32(Console.ReadLine()!);
// Console.Write("Vvedite koordinatu A2: ");
// int a2 = Convert.ToInt32(Console.ReadLine()!);
// Console.Write("Vvedite koordinatu B1: ");
// int b1 = Convert.ToInt32(Console.ReadLine()!);
// Console.Write("Vvedite koordinatu B2: ");
// int b2 = Convert.ToInt32(Console.ReadLine()!);


// double ab = Math.Sqrt(Math.Pow((a1 - b1), 2) + Math.Pow((a2 - b2), 2));

// Console.WriteLine($"Rasstoyanie mezhdu tochkami = {ab:f2}");


Console.Write("Vvedite chislo: ");
int num = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= num; i++)
{
    int sqr = Convert.ToInt32(Math.Pow(i, 2));
    Console.WriteLine(sqr);
}