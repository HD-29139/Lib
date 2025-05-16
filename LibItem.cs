using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lib
{
    public abstract class LibItem
    {
        // priv field 
        private string title = string.Empty;
        private int pubYear;

        // pub properties
        public LibItem(string title, int pubYear)
        {
            Title = title;
            PubYear = pubYear;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public int PubYear
        {
            // "BETTER" year cannot be less than or equal to 0
            get { return pubYear; }
            set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException("negative pub year.");
                }
                else
                {
                    pubYear = value;
                }
            }
        }

        public abstract string ShowDetails();
    }
}