using System;

namespace MyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book(); // Создали отрезок - объект класса Book
            b1.SetBook("Пушкин А.С.", "Капитанская дочка", "Вильямс", 123, 2018);
            // Book.SetPrice(12);
            b1.Print(); // выводит прошлое строковое представление
            Console.WriteLine("\n Итоговая стоимость аренды: {0} р.", b1.PriceBook(3));
            // Book.SetPrice(5);
            Console.WriteLine("\n Итоговая стоимость аренды: {0} р.", b1.PriceBook(3));
            // Book.SetPrice(-1);
            Console.WriteLine("\n Итоговая стоимость аренды: {0} р.", b1.PriceBook(3));
            // Ничего не изменилось из-за условия в setter. (-1) не заменило 5.
            // Второе упражнение
            Console.WriteLine("*************************");
            Book b2 = new Book("Толстой Л.Н.", "Война и мир", "Наука и жизнь", 1234, 2013, 101, true);
            b2.TakeItem();
            b2.Print(); // Будет false, т.к. книгу взяли
            // базовые поля инициализируются 101 и true, а остальные уже в производном классе.
            
            b2.Print(); // Price = 5, т.к. это актуальное значение переменной price. Выполнилась перезагрузка
                        // конструктора

            // Если использовать статический конструктор, то всем...
            // объектам класса - одно значение переменной
            Book b3 = new Book("Лермонтов М.Ю", "Мцыри");
            b3.Print(); // по умолчанию = 0

            // Упражнение 3
            Triangle answer = new Triangle(12, 14, 1);
            answer.Print();
            answer.Perimeter();
            answer.Square();
            // Упражнение 1
            Item item1 = new Item();
            item1.Print();
            // Упражнение 2
            Magazine mag1 = new Magazine("О природе", 5, "Земля и мы", 2014, 1235, true);
            mag1.TakeItem(); // Take - внутри того же класса
            mag1.Print();

            Console.WriteLine("\n Тестирование полиморфизма.");
            Item it; // ссылка на объект базового класса.
            it = b2;
            it.TakeItem(); // так как метод виртуален, то вызов приводит к вызову
                           // методов производного класса
            it.Print();

            it = mag1;
            it.TakeItem();
            it.Print();
        }

    }
}
