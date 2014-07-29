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
            //http://docs.couchbase.com/couchbase-sdk-net-1.3/index.html
            var client = new CouchbaseClient();
        }
    }
}
