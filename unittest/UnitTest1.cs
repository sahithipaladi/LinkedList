using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListImplementation;

namespace unittest

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ///AAA Methodology
            //Arrange
            LinkedList linkedList = new LinkedList();

            //Act
            linkedList.Append(56);
            linkedList.Append(70);
            linkedList.Insert(2, 30);

            //Assert
            Assert.IsTrue(linkedList.Search(30));
        }

        [TestMethod]
        public void TestMethod2()
        {
            ///AAA Methodology
            //Arrange
            LinkedList linkedList = new LinkedList();

            //Act
            linkedList.Append(56);
            linkedList.Append(70);
            linkedList.Insert(2, 30);
            linkedList.Insert(3, 40);

            //Assert
            Assert.IsTrue(linkedList.Search(40));
        }
    }
}
