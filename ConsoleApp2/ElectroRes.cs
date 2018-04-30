using System;
namespace Project_3_12
{
    public class ElectroRes : Edition, IComparable
    {
        public ElectroRes(string Name, string LastNameAuthor, string Link, string Annotation)
        {
            this.Name = Name;
            this.LastNameAuthor = LastNameAuthor;
            this.Link = Link;
            this.Annotation = Annotation;
        }

        public override void Show() //переопределяем абстрактный метод
        {
            Console.WriteLine("Название: {0} Автор: {1} Ссылка: {2} Аннотация: {3}", Name, LastNameAuthor, Link, Annotation);
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