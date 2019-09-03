using Dawa.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dawa.Tests
{
    [TestClass]
    public class AddressServiceTests
    {
        private AddressService service;

        public AddressServiceTests()
        {
            service = new AddressService();
        }

        [TestMethod]
        public void AutocompleteTest()
        {
            var result = service.Autocomplete("Brettevillesgade 14, 9000").Result;

            Assert.IsTrue(result[0].Tekst.Equals("Brettevillesgade 14, 9000 Aalborg"));
        }

        [TestMethod]
        public void ReverseTest()
        {
            var result = service.Reverse("36f67b7c-cd5a-4b39-84dc-1738fc902719").Result;

            Assert.IsTrue(result.Adressebetegnelse.Equals("Brettevillesgade 14, 9000 Aalborg"));
        }
    }
}
