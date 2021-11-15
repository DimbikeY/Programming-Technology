using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    class Book: Item
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public int Pages { get; set; }
        public int Year { get; set; }
        private static double price = 9;
        public static double Price
        {
            get { return price; }
            set { if (value > 0) price = value; }
        }
        public void SetBook(string author, string title, string publisher, int pages, int year)
        {
            this.Author = author;
            this.Title = title;
            this.Publisher = publisher;
            this.Pages = pages;
            this.Year = year; // Обращение к конкретному объекту класса (экземпляр)
        }
        public static void SetPrice(double price)
        {
            Book.Price = price; // обращение для всех объектов класса через имя класса, а не через имя экземпляра
        }
        public override string ToString()
        {
            string bs = String.Format("\nКнига: \n Автор: {0}\n Название: {1}\n Год издания: {2}\n {3} стр.\n Стоимость аренды: {4}", Author, Title, Year, Pages, Book.price); // Book.price
            return bs;
        }
        public override void Print() // Явный вид скрытия метода базового класса.
        {
            Console.WriteLine(this);
            base.Print(); // 
        }
        public double PriceBook(int s)
        {
            double cust = s * price;
            return cust;
        }
        // Второе упражнение
        public Book(string author, string title, string publisher, int pages, int year)
        {
            this.Author = author;
            this.Title = title;
            this.Publisher = publisher;
            this.Pages = pages;
            this.Year = year;
        }
        public Book()
        { }             // Перезагрузка конструктора
        
        // Добавим статический констуктор для инициализации полей до ... 
        // первого обраения к любому элементу класса
        static Book()
        {
            Price = 9;
        }
        public Book(string author, string title)
        {
            this.Author = author;
            this.Title = title;
        }
        /// public void TakeItem()
        ///{
           /// if (this.IsAvailable())
            ///{
               /// this.Take();
            ///}
        ///}
        public Book(string author, string title, string publisher, int pages, int year, long invNumber, bool taken) 
                                                                    : base(invNumber, taken)
        {
            this.Author = author;
            this.Title = title;
            this.Publisher = publisher;
            this.Pages = pages;
            this.Year = year;
        }
        public override void Return()
        {
            if (returnSrok == true)
            {
                taken = true;
            }
            else
            {
                taken = false;
            }
        }

    }
}
