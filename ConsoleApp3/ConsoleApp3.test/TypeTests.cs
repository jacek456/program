

using System.Reflection.Metadata;

namespace ConsoleApp3.test
{
    public class TypeTests
    {
        [Test]
        public void TEST()
            // arrage
            var user1 = GetUser("Adam");
        var user2 = GetUser("Tomasz");
       

            // act



            // assert


            private User GetUser(string name)
        {
            return new User(name);
        }





    }
}
