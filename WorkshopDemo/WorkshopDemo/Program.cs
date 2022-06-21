using System;
namespace WorkshopDemo
{
    class Program
    {
        private const int V = 6;
        private static string b;

        public static void Main(string[] args)
        {
            bool c;
            int y0;
            int x;
            int m0;
            int d0;

            Console.WriteLine("Enter a Date");
            int d = Convert.ToInt32(Console.ReadLine);

            Console.WriteLine("Enter a Month");
            int m = Convert.ToInt32(Console.ReadLine);

            Console.WriteLine("Enter a Year");
            int y = Convert.ToInt32(Console.ReadLine);


            y0 = y - (14 - m) / 12;
            x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            m0 = m + 12 * ((14 - m) / 12) - 2;
            d0 = (d + x + 31 * m0 / 12) % 7;
            c = 0 <= d0 <= V;



            if (c)
            {
                String b = "Sunday";
            }
            else
            {
                if (c)
                {
                    String b = "Monday";
                }
                else
                {
                    if (c)
                    {
                        String b = "Tuesday";
                    }
                    else
                    {
                        if (c)
                        {
                            String b = "Wednesday";
                        }
                        else
                        {
                            if (c)
                            {
                                String b = "Thursday";
                            }
                            else
                            {
                                if (c)
                                {
                                    String b = "Friday";
                                }
                                else
                                {
                                    if (c)
                                    {
                                        String b = "Saturday";
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine("The day of the week is " + b);
        }

    }
}