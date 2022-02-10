using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCities
{
    public interface ISearchCities
    {
        IEnumerable<string> Search(string search);
    }
}
