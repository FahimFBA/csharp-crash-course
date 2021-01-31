using System;

namespace GettersAndSetters
{
    class Movie
    {
        public String title;
        public String director;
        private string rating;

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }

        // Getters And Setters
        public String Rating
        {
            get { return rating; }
            set 
            { 
                if(value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {   
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}
