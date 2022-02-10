using System.Collections.Generic;
using System.Linq;


namespace KataCities
{
    public class SearchCities : ISearchCities
    {
        private readonly IDB _dB;

        public SearchCities(IDB dB)
        {
            _dB = dB;
        }

        public IEnumerable<string> Search(string input)
        {
            if (input.Length < 2)
                return Enumerable.Empty<string>();
            return _dB.GetDB().Where(x => x.ToUpper().Contains(input.ToUpper()));
        }
    }
}
