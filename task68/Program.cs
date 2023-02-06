Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int nod = 0;

void NOD(int m, int n)
{
 while(m != n)
            {
                if(m > n)
                {
                    m = m - n;
                }
                else
                {
                    n = n - m;
                }
            }

            nod = n;
            Console.WriteLine("НОД: " + nod);
}
NOD (m,n);