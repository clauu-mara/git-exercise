using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestClassLib
{
    [TestFixture]
    public class NUnitTestClass
    {

        [Test]
        public void FirstTest()
        {
            int x = 2, y = 3;   
            Assert.AreEqual(x,y);

        }
        [Test]
        public void MySecondTest_Conflicts()
        {
            Console.WriteLine("Resolving conflicts");
        }
    }
}
