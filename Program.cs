using System;

namespace struct_test_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Spore[] mas = new Spore[10];
            Random ran = new Random();
            int help;
            for (int i = 0; i < 10; i++)
            {
                mas[i].is_predator = Convert.ToBoolean(ran.Next(-1,2));
                mas[i].weight = ran.Next(38,114);
            }
            Console.WriteLine("is predator:");
            for (int i = 0; i < 10; i++)
            {
               Console.Write(mas[i].is_predator ? " 1" : " 0");
            }
            Console.WriteLine(" ");
            for (int i = 0; i < 10-1; i++)
            {
                if (mas[i].is_eaten)
                {
                    continue;
                }
                if (mas[i].is_predator == true)
                {
                    if (mas[i + 1].is_predator == false)
                    {
                        mas[i + 1].is_eaten = true;
                        
                        
                    }
                    else if (mas[i].weight > mas[i + 1].weight)
                    {
                        mas[i + 1].is_eaten = true;
                    }
                    else 
                    {
                        mas[i].is_eaten = true;
                    }
                    
                }

            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write(mas[i].is_eaten ? " *" : " -");
            }
            
        }
        struct Spore
        {
            public bool is_predator;
            public int weight;
            public bool is_eaten;

        }
    }

    
}
