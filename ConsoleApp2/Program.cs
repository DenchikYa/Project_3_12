using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;

namespace Project_3_12
{
    class Program
    {
        static void Main()
        {
            var arrayEdition = new List<Edition>();
            Edition newArrayEdition = new Book("Дочь священника", "Оруэлл", 1935, "Victor Gollancz");
            arrayEdition.Add(newArrayEdition);
            newArrayEdition = new Article("Космос", "Йоркс", 2014, "Наука", 42);
            arrayEdition.Add(newArrayEdition);
            newArrayEdition = new ElectroRes("LibreBook", "Kaonasi", "http://librebook.me/", "Лучший сервис для бесплатного чтения электронных книг онлайн! ");
            arrayEdition.Add(newArrayEdition);
            newArrayEdition = new Book("Великий Бисмарк", "Власов", 2011, "Эксмо");
            arrayEdition.Add(newArrayEdition);
            newArrayEdition = new Article("Первая машина", "Корнилов", 2015, "Авто", 152);
            arrayEdition.Add(newArrayEdition);
            newArrayEdition = new ElectroRes("Auto.ru", "ЯндексВертикали", "http://Auto.ru/", "Большая база объявлений о продаже новых и подержанных авто.");
            arrayEdition.Add(newArrayEdition);
            newArrayEdition = new Book("Справедливость силы", "Власов", 1989, "Эксмо");
            arrayEdition.Add(newArrayEdition);
            newArrayEdition = new Article("Учеба", "Арнольд", 2017, "Умный и тупой", 12);
            arrayEdition.Add(newArrayEdition);
            newArrayEdition = new ElectroRes("Internet.ru", "Правительство", "http://internet.ru/", "Настройка интернета.");
            arrayEdition.Add(newArrayEdition);
            newArrayEdition = new Book("История", "Сидякин", 2008, "Эксмо");
            arrayEdition.Add(newArrayEdition);
            newArrayEdition = new Book("Восточный мир", "Brown", 2004, "Эксмо");
            arrayEdition.Add(newArrayEdition);
            newArrayEdition = new Book("Математика", "Аркадий", 1001, "Неизвестно");
            arrayEdition.Add(newArrayEdition);

            Console.WriteLine("Список:");
            arrayEdition.Sort();
            foreach (var item in arrayEdition)

            {
                item.Show();
                Console.WriteLine();
            }
            Console.Write("Искать по зарпрос: ");
            string Seek = Console.ReadLine();

            Console.WriteLine("Поиск по зарпросу '{0}':", Seek);

            foreach (Edition item in arrayEdition)
            {
                if (item.Check(Seek)) item.Show();
            }
        }
    }
}