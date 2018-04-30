using System;
namespace Project_3_12
{
    public class Book : Edition
    {
        public Book(string Name, string LastNameAuthor, int YearEdition, string NameEdition)
        {
            this.Name = Name;
            this.LastNameAuthor = LastNameAuthor;
            this.YearEdition = YearEdition;
            this.NameEdition = NameEdition;
        }
        public override void Show() //переопределяем абстрактный метод
        {
            Console.WriteLine("Книга: {0} Автор: {1} Год издания: {2}г.  Издательство: {3}", Name, LastNameAuthor, YearEdition, NameEdition);
        }
        public override bool Check(string Seek) //переопределяем абстрактный метод
        {
            if (LastNameAuthor == Seek) return true;
            else
            {
                return false;
            }
        }
    }
}