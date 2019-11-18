using System;
using System.Collections.Generic;
using System.Text;

namespace MovieList
{
    class Movie
    {
        //two private fields
        private string title;
        private string category;
        public int categoryCodes;
        //access private fields with the property
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        //default constructor
        public Movie() { }
        //Build overload constructors 
        public Movie(string title, string category,int categoryCodes )
        {
            this.title = title;
            this.category = category;
            this.categoryCodes = categoryCodes;
        }
    }
}
