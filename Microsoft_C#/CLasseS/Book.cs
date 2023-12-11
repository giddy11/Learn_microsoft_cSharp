﻿namespace CLasseS
{
    // classes have a name, unique within the namespace
    public class Book
    {
        // TODO: classes have one or more constructors
        public Book(string name, string author, int pageCount)
        {
            _name = name;
            _author = author;
            _pageCount = pageCount;
        }

        // TODO: methods are used to operate on the class and data
        public string GetDescription()
        {
            return $"{_name} by {_author}";
        }



        // TODO: classes have member variables, or "fields" to hold data
        public string _name;
        string _author;
        int _pageCount;
    }
}