using System;
using System.Dynamic;
using System.IO;

namespace Project_3_12
{
    public abstract class Edition : IComparable
    {
        protected string Name;
        protected string LastNameAuthor;
        protected int YearEdition;
        protected string NameEdition;
        protected string NameMagazine;
        protected int Number;
        protected string Link;
        protected string Annotation;

        public string ShowLastName()
        {
            return LastNameAuthor;
        }
        public abstract void Show();
        public abstract bool Check(string Seek);
        public int CompareTo(object obj)
        {
            Edition b = (Edition)obj;
            return LastNameAuthor.CompareTo(b.ShowLastName());
        }
    }
}