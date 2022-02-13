using System;
using System.Collections.Generic;
using System.Text;

namespace Task3Book
{
//Task - 3
//Asagidaki memberlerden ibaret Book class-i yaradirsiniz: 
//Name
//PageCount
//ps: name ve count deyerleri teyin olunmammis Book obyekti yaranmamalidir
//PageCount deyeri 10-dan kicik ola bilmez ve Name deyerinin uzunlugu 3-den qisa ola bilmez
//Main hissesinde 10 kitabliq Book arrayi olsun.
//Kitab deyerleri console-dan daxil edilsin ve yaradilsin, array-e elave edilsin.Sonda arraydeki kitablarin
//Name ve PageCount deyerleri console penceresinde gosterilsin

    class Book
    {
        public string Name;
        public int PageCount;

        public Book(string name,int pagecount)
        {
            
            while (true)
            {
                
                if (name.Length > 3)
                {
                    Name = name;
                    break;
                }
                else
                {
                    Console.WriteLine("Adini Yeniden Daxil Edin");
                    name = Console.ReadLine();
                }
               
            }
            while (true)
            {
                if (pagecount > 10)
                {

                    PageCount= pagecount;
                    break;
                }
                else
                {
                    Console.WriteLine("Sayini Duzdun Daxil Edin");
                    int.TryParse(Console.ReadLine(), out pagecount);
                }
            }
           

        }
        public string Info()
        {
            return $"{Name} {PageCount}";
        }
    }
}
