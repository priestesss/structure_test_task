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
                mas[i].is_predator = Convert.ToBoolean(ran.Next(0,1));
                mas[i].weight = ran.Next(38,114);
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (mas[i].is_predator[i] == true && mas[i].is_predator[j] == false)
                    {
                        help = mas[i];
                        mas[i] = mas[j];
                        mas[j] = help;
                    }
                }
            }
        }
        struct Spore
        {
            public bool is_predator;
            public int weight;

        }
    }
}
