using Couchbase;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CouchbaseTest
{
    [TestClass]
    public class CouchbaseClientTests
    {
        [TestMethod]
        public void InstantiateClient()
        {
            var client = new CouchbaseClient();
        }
    }
}
