using _3._4_Deque;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_Found()
        {
            Deque<int> usersDeck = new Deque<int>();
            usersDeck.AddFirst(10);
            usersDeck.AddFirst(123);
            usersDeck.AddLast(8);
            usersDeck.AddLast(8);
            List<int> expect = new List<int>() { 2, 3 }; 
            CollectionAssert.AreEqual(expect, usersDeck.Found(8), "Error in Method Found");   
        }
        [TestMethod]
        public void TestMethod_RemoveFound()
        {
            Deque<int> usersDeck = new Deque<int>();
            usersDeck.AddFirst(10);
            usersDeck.AddFirst(123);
            usersDeck.AddLast(8);
            usersDeck.AddLast(8);
            usersDeck.RemoveFound(123);
            List<int> expect = new List<int>() { 10, 8, 8 };
           
            CollectionAssert.AreEqual(usersDeck.Value(), expect, "Error in Method Remove_Found");
            
        }
        [TestMethod]
        public void TestMethod_RemoveFirst()
        {
            Deque<int> usersDeck = new Deque<int>();
            usersDeck.AddFirst(10);
            usersDeck.AddFirst(123);
            usersDeck.AddLast(8);
            usersDeck.AddLast(8);
            usersDeck.RemoveFirst();
            List<int> expect = new List<int>() { 10, 8, 8 };
            CollectionAssert.AreEqual(expect, usersDeck.Value(), "Error in Method Remove_First");
        }
        [TestMethod]
        public void TestMethod_ReturnFirst_throw()
        {
            Deque<int> usersDeck = new Deque<int>();
            try
            {
                usersDeck.RemoveFirst();
            }
            catch( InvalidOperationException e)
            {
                return;
            }
            Assert.Fail("Error in Method_ReturnFirst_throw");
            
        }
        [TestMethod]
        public void TestMethod_ReturnLast()
        {
            Deque<int> usersDeck = new Deque<int>();
            usersDeck.AddFirst(10);
            usersDeck.AddFirst(123);
            usersDeck.AddLast(8);
            usersDeck.AddLast(8);
            usersDeck.RemoveLast();
            List<int> expect = new List<int>() { 123, 10, 8 };
            
            CollectionAssert.AreEqual(expect, usersDeck.Value(), "Error in Method Remove_Last");

        }
        [TestMethod]
        public void TestMethod_ReturnLast_throw()
        {
            Deque<int> usersDeck = new Deque<int>();
            try
            {
                usersDeck.RemoveLast();
            }
            catch (InvalidOperationException e)
            {
                return;
            }
            Assert.Fail("Error in Method_ReturnLast_throw");
        }
    }
}