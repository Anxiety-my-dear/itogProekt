Console.Write("Введите число N:  ");
int n = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите число M:  ");
int m = Convert.ToInt16(Console.ReadLine());

Numbers (n, m);

void Numbers (int n, int m)
{
   if (m>n)
for (int i = n; i <= m; i++)
        {
            if (i % 2 == 0) 
            {
                Console.Write(i + " ");
            }
        }
}