using System.Collections.Generic;


namespace KataCities
{
    public  class DBCities : IDB
    {
        private static IList<string> Cities = new List<string>
        {
            "Paris",
            "Budapest",
            "Skopje" ,
            "Rotterdam",
            "Valencia",
            "Vancouver",
            "Amsterdam",
            "Vienna",
            "Sydney",
            "New York City",
            "London",
            "Bangkok",
            "Hong Kong",
            "Dubai",
            "Rome",
            "Istanbul"
        };

        public IList<string> GetDB()
        {
            return Cities;
        }
    }
}
