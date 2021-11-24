using System;
using System.Collections.Generic;

namespace MyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publ_new = new Publisher("Вестник ночей бессонных", "have_a_nice_day@mail.ru", 54, new DateTime(2012, 12, 12));
            Book b1 = new Book("Пушкин А.С.", "Капитанская дочка", publ_new, 1, 1824);
            b1.SetPrice(22);
            //b1.SetBook("Пушкин А.С.", "Капитанская дочка", "Вильямс", 123, 2018);
            //Book.SetPrice(12);
            //b1.Print();
            //Console.WriteLine("\n Итоговая стоимость аренды: {0} р.", b1.PriceBook(3));
            Publisher publ = new Publisher("Наука и жизнь", "nauka@mail.ru", 1234, new DateTime(2014, 12, 14));
            Book b2 = new Book("Толстой Л.Н.", "Война и мир", publ, 1234, 2013, 101, true);
            b2.SetPrice(33);
            b2.Print(); // везде одинакова
            Book b3 = new Book("Лермонтов М.Ю.", "Мцыри", publ, 123, 2014, 122, true);
            b3.SetPrice(30);
            b3.Print();
            Console.WriteLine("******************************");
            
            
            
            //Item item1 = new Item();  // нельзя вызывать абстрактный класс (создать объект этого класса!)
            Console.WriteLine("Сейчас будет item1");
            //item1.Print();
            
            
            
            
            Console.WriteLine("*************************");
            //Book b4 = new Book("Толстой Л.Н.", "Война и мир", "Наука и жизнь", 1234, 2013, 101, true);
            //b4.TakeItem();
            //b4.Print(); // и ячейку хранения в базовом классе вызывает
            Console.WriteLine("******************************\n Тест mag1 \n");
            Console.WriteLine("Проверка делегата\n");
            Audit.RunAudit(); // включаем подписку на событие
            Magazine mag1 = new Magazine("О природе", 5, "Земля и мы", 2014, 1235, true);
            //mag1.TakeItem();
            mag1.Print();
            mag1.Subs(); // статус подписки поменялся в текстовом файле (отобразился)
            mag1.Print();
            Magazine mag2 = new Magazine("1984", 12, "Оруэлл", 1956, 222, true);
            //mag2.TakeItem();
            mag2.Print();
            Audit.StopAudit();
            mag2.Subs();  // не отобразится подписка в текстовом файле, так как подписка на событие отключена
            mag2.Print();
            Console.WriteLine("************************");
            Console.WriteLine("\n Тестирование полиморфизма.");
            b2.ReturnSrok();
            Item it;
            it = b2; // Ссылка базового класса сама понимает, какой тип данных использует объект класса и сама выбирает метод
                     // она видит, что это книга и поэтому переопределяет методы
            it.TakeItem(); // вызывает виртуальные (точнее, перезаписанные) методы производного класса
            it.Return();
            it.Print();
            Console.WriteLine("*******************************88");
            it = mag1;
            it.TakeItem();
            it.Return();
            it.Print();    // то же самое
            Console.WriteLine("Тест нового интерфейса \n Тест \n Тест:*****88\n");
            List<Item> itlist = new List<Item>();
            itlist.AddRange(new Item[] { b1, b2, b3, mag1, mag2 });
            itlist.Sort();
            Console.WriteLine("\nСортировка по инвентарному номеру");
            foreach (Item x in itlist)
            {
                x.Print();
            }


        }
    }
}
