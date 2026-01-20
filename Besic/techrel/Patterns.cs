using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Besic
{
    internal class Patterns
    {
        public void NumberPattern1()
        {
            int n = 1;
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    Console.Write(n);
                }
                n = (n == 0) ? 1 : 0;
                Console.WriteLine();
            }
        }


        public void NumberPattern2()
        {
            for(int i=1;i<=5;i++)
            {
                int n = 0;
                for(int j=1;j<=5;j++)
                {
                    Console.Write(n);
                    n = (n == 0) ? 1 : 0;
                }
                Console.WriteLine();
            }
        }

        public void NumberPattern3()
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    int res = (i == 1 || i == 5 || j == 1 || j == 5) ? 1 : 0;
                    Console.Write(res);
                }
                Console.WriteLine();
            }
        }

        public void NumberPattern4()
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    int res = (i == j && i == 3) ? 0 : 1;
                    Console.Write(res);
                }
                Console.WriteLine();
            }
        }


        public void NumberPattern5()
        {
            int n = 1;
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    Console.Write(n);
                    n = (n == 0) ? 1 : 0;
                }
                Console.WriteLine();
            }
        }


        public void NumberPattern6()
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    int res = (i == 3 || j == 3) ? 0 : 1;
                    Console.Write(res);
                }
                Console.WriteLine();
            }
        }


        public void NumberPattern7()
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    int res = (i == j || i + j == 6) ? 1 : 0;
                    Console.Write(res);
                }
                Console.WriteLine();
            }
        }

        public void NumberPattern8()
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    int res = ((i == 1 || i == 5 || j == 1 || j == 5) && i != j&&i+j!=6) ? 1 : 0;
                    Console.Write(res);
                }
                Console.WriteLine();
            }
        }


        public void NumberPattern9()
        {
            int n = 1;
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    Console.Write(n);
                }
                Console.WriteLine();
                n++;
            }
        }

        public void NumberPattern10()
        {
            for(int i=1;i<=5;i++)
            {
                int n = 1;
                for(int j=1;j<=5;j++)
                {
                    Console.Write(n);
                    n++;
                }
                Console.WriteLine();
            }
        }

        public void NumberPattern11()
        {
            for(int i=1;i<=5;i++)
            {
                int n = i;
                for(int j=1;j<=5;j++)
                {
                    Console.Write(n);
                    n++;
                }
                Console.WriteLine();
            }
        }

        public void NumberPattern12()
        {
            int n = 1;
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    Console.Write(n);
                    n++;
                }
                Console.WriteLine();
            }
        }


        public void NumberPattern13()
        {
            for(int i=5;i>=1;i--)
            {
                int n = 5;
                for(int j=5;j>=i;j--)
                {
                    Console.Write(n);
                    n--;
                }
                for(int k=1;k<i;k++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }


        public void NumberPattern14()
        {
            for(int i=1;i<=5;i++)
            {
                int n = i;
                for(int j=5;j>=i;j--)
                {
                    Console.Write(n);
                    n++;
                }
                for(int k=1;k<i;k++)
                {
                    Console.Write(5);
                }
                Console.WriteLine();
            }
        }


        public void NumberPattern15()
        {
            for(int i=1;i<=5;i++)
            {
                int n = i;
                for(int j=5;j>=i;j--)
                {
                    Console.Write(n);
                    n++;
                }
                int m = i - 1;
                for(int k=1;k<i;k++)
                {
                    Console.Write(m);
                    m--;
                }
                Console.WriteLine();
            }
        }


        public void NumberPattern16()
        {
            for(int i=1;i<=5;i++)
            {
                int n = i;
                for(int j=1;j<=i;j++)
                {
                    Console.Write(n);
                    n--;
                }

                int m = 2;
                for(int k=5;k>i;k--)
                {
                    Console.Write(m);
                    m++;
                }
                Console.WriteLine();
            }
        }


        public void NumberPattern19()
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        public void NumberPattern20()
        {
            for(int i=5;i>=1;i--)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        public void NumberPattern21()
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=5;j>=i;j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        public void NumberPattern22()
        {
            for(int i=5;i>=1;i--)
            {
                for(int j=5;j>=i;j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        public void NumberPattern23()
        {
            for(int i=1;i<=5;i++)
            {
                int n = 1;
                for(int j=1;j<=i;j++)
                {
                    Console.Write(n);
                    n++;
                }
                Console.WriteLine();
            }
        }

        public void NumberPattern24()
        {
            for(int i=1;i<=5;i++)
            {
                int n = 1;
                for(int j=5;j>=i;j--)
                {
                    Console.Write(n);
                    n++;
                }
                Console.WriteLine();
            }
        }

        public void NumberPattern25()
        {
            for(int i=1;i<=5;i++)
            {
                int n = i;
                for(int j=1;j<=i;j++)
                {
                    Console.Write(n);
                    n--;
                }
                Console.WriteLine();
            }
        }

        public void NumberPattern26()
        {
            for(int i=5;i>=1;i--)
            {
                int n = i;
                for(int j=1;j<=i;j++)
                {
                    Console.Write(n);
                    n--;
                }
                Console.WriteLine();
            }
        }

        public void NumberPattern27()
        {
            for(int i=5;i>=1;i--)
            {
                for(int j=5;j>=i;j--)
                {
                    Console.Write(j);

                }
                Console.WriteLine();
            }
        }

        public void NumberPattern28()
        {
            for(int i=1;i<=5;i++)
            {
                int n = 5;
                for(int j=5;j>=i;j--)
                {
                    Console.Write(n);
                    n--;
                }
                Console.WriteLine();
            }
        }

        public void NumberPattern29()
        {
            for(int i=5;i>=1;i--)
            {
                int n = i;
                for(int j=5;j>=i;j--)
                {
                    Console.Write(n);
                    n++;
                }
                Console.WriteLine();
            }
        }

        public void NumberPattern30()
        {
            for(int i=1;i<=5;i++)
            {
                int n = i;
                for(int j=5;j>=i;j--)
                {
                    Console.Write(n);
                    n++;
                }
                Console.WriteLine();
            }
        }

        public void NumberPattern31()
        {
            
            for(int i=1;i<=5;i++)
            { 
                int n = i;
            for (int j=1;j<=i;j++)
                {
                    Console.Write(n);
                    n++;
                }
                Console.WriteLine();
            }
        }

        public void NumberPattern32()
        {
            for(int i=5;i>=1;i--)
            {
                int n = i;
                for(int j=1;j<=i;j++)
                {
                    Console.Write(n);
                    n++;
                }
                Console.WriteLine();
            }
        }

        public void NumberPattern33()
        {
            for(int i=1;i<=10;i+=2)
            {
                int n = i;
                for(int j=10;j>=i;j-=2)
                {
                    Console.Write(n);
                    n += 2;
                }
                Console.WriteLine();
            }
        }

        public void NumberPattern34()
        {
            for(int i=1;i<=5;i++)
            {
                int n = 1;
                for(int j=1;j<=i;j++)
                {
                    Console.Write(n);
                    n = (n == 0) ? 1 : 0;
                }
                Console.WriteLine();
            }
        }

        public void NumberPattern35()
        {
            int n = 1;
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(n);
                }
                n = (n == 0) ? 1 : 0;
                Console.WriteLine();
            }
        }

        public void NumberPattern36()
        {
            int n = 1;
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(n);
                    n = (n == 0) ? 1 : 0;
                }
                Console.WriteLine();
            }
        }

        public void NumberPattern37()
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    int res = (j == 1 || i == 5 || j == i) ? 1 : 0;
                    Console.Write(res);
                }
                Console.WriteLine();
            }
        }

        public void NumberPattern38()
        {
            int n = 1;
            for(int i=1;i<=4;i++)
            {
                for(int j=1;j<=3;j++)
                {
                    Console.Write(n);
                    if(i%2==0)
                    {
                        n--;
                    }
                    else
                    {
                        n++;
                    }
                }
                n = (i % 2 == 0) ? n += 4 : n += 2;
                Console.WriteLine();
            }
        }

        public void StarPattern1()
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void StarPattern2()
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    if(i==1||i==5||j==1||j==5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        public  void StarPattern3()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 5; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }


        public void StarPattern4()
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=5;j>i;j--)
                {
                    Console.Write(" ");
                }

                for(int k=1;k<=5;k++)
                {
                    string res = (i == 1 || i == 5 || k == 1 || k == 5) ? "*" : " ";
                    Console.Write(res);
                }
                Console.WriteLine();
            }
        }

        public void StarPattern5()
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<i;j++)
                {
                    Console.Write(" ");
                }

                for(int k=1;k<=5;k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
        }

        public void StarPattern6()
        {
            for(int i=1;i<=5;i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 5; k++)
                {
                    string res = (i == 1 || i == 5 || k == 1 || k == 5) ? "*" : " ";
                    Console.Write(res);
                }
                Console.WriteLine();
            }
        }

        public void StarPattern7()
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }

        public void StarPattern8()
        {
            for(int i=1;i<=5;i++)
            {
                 for(int j=1;j<=i;j++)
                 {
                    string res = (i == 5 || j == 1 || j == i) ? "*" : " ";
                    Console.Write(res);
                 }
                Console.WriteLine();
            }
        }

        public void StarPattern9()
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=5;j>i;j--)
                {
                    Console.Write(" ");
                }
                for(int k=1;k<=i;k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public void StarPattern10()
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=5;j>i;j--)
                {
                    Console.Write(" ");
                }
                for(int k=1;k<=i;k++)
                {
                    string res=(k==1||i==5||i==k)?"* ":"  ";
                    Console.Write(res);
                }
                Console.WriteLine();
            }
        }

        public void StarPattern11()
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=5;j>=i;j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void StarPattern12()
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=5;j>=i;j--)
                {
                    string res = (j == 5 || i == 1 || i == j) ? "*" : " ";
                    Console.Write(res);
                }
                Console.WriteLine();
            }
        }

        public void StarPattern13()
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<i;j++)
                {
                    Console.Write(" ");
                }
                for(int k=5;k>=i;k--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

    }
}
