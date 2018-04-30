using System;
namespace Project_3_12
{
    public class Article : Edition, IComparable
    {
        public Article(string Name, string LastNameAuthor, int YearEdition, string NameMagazine, int Number)
        {
            this.Name = Name;
            this.LastNameAuthor = LastNameAuthor;
            this.YearEdition = YearEdition;
            this.NameMagazine = NameMagazine;
            this.Number = Number;
        }
        public override void Show() //переопределяем абстрактный метод
        {
            Console.WriteLine("Статья: {0} Автор: {1} Год издания: {2}г. Журнал: {3}  Номер: №{4}", Name, LastNameAuthor, YearEdition, NameMagazine, Number);
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