using _3._2_queue;

namespace _1.test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void TestMethod_Size()
        {
            Queue s = new Queue();
            s.push(1);
            s.push(2);
            s.push(3);
            int expected = 3;
            int a = s.size();
            //Equals(expected, a);
            Assert.AreEqual(expected, a, 0.001, "Size is false");
        }
        [TestMethod]
        public void TestMethods_front_and_push()
        {
            Queue s = new Queue();
            s.push(1);
            int actual = s.front();
            int expected = 1;
            Assert.AreEqual(expected, actual, 0, "metod front had taken error ");
        }
        [TestMethod]
        public void TestMethods_push_ShouldThrowArgumentOutOfRange()
        {
            Queue s = new Queue();           
            try{
               while(true)
                s.push(1);
            }
            catch (System.ArgumentOutOfRangeException e) {
                StringAssert.Contains(e.Message, s.SizeMostThatRange);
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }
        [TestMethod]
        public void TestMethods_front_ShouldThrowArgumentOutOfRange()
        {
            Queue s = new Queue();          
            try {
                s.front();
            }
            catch(System.ArgumentOutOfRangeException e) {
                StringAssert.Contains(e.Message, s.SizeLessThatZeroMessege);
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod]
        public void TestMethod_pop()
        {
            Queue s = new Queue();
            s.push(1);
            s.push(2);
            s.push(3);
            int actual = s.pop();
            int expected = 1;
            Assert.AreEqual(expected, actual, 0, "metod pop had taken error ");
        }

        [TestMethod]
        public void TestMethod_pop_ShouldThrowArgumentOutOfRange()
        {
            Queue s = new Queue();
            try{
                s.pop();
            }
            catch (System.ArgumentOutOfRangeException e){
                StringAssert.Contains(e.Message, s.SizeLessThatZeroMessege);
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod]    
        public void TestMethod_clear() {
            Queue s = new Queue();
            s.push(1);
            s.push(2);
            s.push(3);
            s.clear();
            int actual = s.size();
            int expected = 0;
            Assert.AreEqual(expected, actual, 0, "metod clear had taken error ");
        }
       
    }

}