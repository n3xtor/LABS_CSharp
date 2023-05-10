using System;

namespace Lab4
{
    class Program
    {
        // Метод-обробник події
        static public void OnPageDamage(object sender, PageDamageEventArgs e)
        {
            Console.WriteLine($"Page {e.PageNumber} of {((Book)sender).Title} was damaged ({e.DamageType}).\n");
        }
        static void Main(string[] args)
        {
            Book book = new Book("John Smith", "PoorBook", "Addison-Wesley", 2007);
            book.PageDamage += OnPageDamage;

            // Якщо хтось зігнув сторінку 10
            book.DamagePage(10, "page was folded");

            // Якщо хтось написав текст на сторінці 15
            book.DamagePage(15, "text was written on the page");

            // Якщо хтось вирвав сторінку 5
            book.DamagePage(5, "page was torn out");
        }
    }
}
