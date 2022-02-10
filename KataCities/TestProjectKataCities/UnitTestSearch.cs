using NUnit.Framework;
using KataCities;
using System.Linq;
using System.Collections.Generic;

namespace TestProjectKataCities
{
    public class Tests
    {

        ISearchCities _sut;
        [SetUp]
        public void Setup()
        {
            _sut = new SearchCities(new DBCities());
        }

        [Test]
        public void TestUnder2Char()
        {
            Assert.IsEmpty(_sut.Search(string.Empty));
            Assert.IsEmpty(_sut.Search("a"));
        }


        [Test]
        public void TestMatching()
        {
            var expected = "Rome";
            var actual = _sut.Search("Rome").ToList();
            Assert.AreEqual(1, actual.Count);
            Assert.AreEqual(expected, actual.Single());
        }


        [Test]
        public void TestMultipleResult()
        {
            var expected = new List<string>
            { 
                "Valencia",
                "Vancouver"
            };
            var actual = _sut.Search("va").ToList();
            var actual2 = _sut.Search("Va").ToList();
            Assert.AreEqual(2, actual.Count);
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected, actual2);
        }

        [Test]
        public void TestContains()
        {
            var expected = new List<string>
            {
                "Budapest",  
            };

            var actual = _sut.Search("ape");
            Assert.AreEqual(1, actual.ToList().Count);
            Assert.AreEqual(expected, actual);
        }

    }
}