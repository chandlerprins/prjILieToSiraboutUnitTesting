using prjILieToSiraboutUnitTesting;

namespace TestIWantANewProgLect
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestgetName()
        {
            DoWhatEver doWhat = new DoWhatEver();
            String Actual = doWhat.getName();
            String Expected = "Jeff";
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void TestgetEmail()
        {
            DoWhatEver doWhat = new DoWhatEver();
            String Actual = doWhat.getEmail();
            String Expected = "jess@gmail.com";
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void TestgetDate()
        {
            DoWhatEver doWhat = new DoWhatEver();
            String Actual = doWhat.getDate();
            String Expected = "2024/04/04";
            Assert.AreEqual(Expected, Actual);
        }
    }
}