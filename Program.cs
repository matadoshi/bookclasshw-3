using System;

namespace Task3Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] str =new Book[10];
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine($"{i+1}.Kitabin adini daxil edin :");
                string temp_name = Console.ReadLine();
                Console.WriteLine($"{i+1} Kitabin sehfesinin sayini daxil edin");
                int.TryParse(Console.ReadLine(), out int a);
                Book test = new Book(temp_name, a);
                str[i] = test;
            }
            foreach (var item in str)
            {
                Console.WriteLine(item.Info());
            }
        }

    }
}
