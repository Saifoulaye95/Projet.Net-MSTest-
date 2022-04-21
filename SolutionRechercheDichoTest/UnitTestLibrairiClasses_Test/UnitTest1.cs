using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolutionRechercheDichoTest;

namespace UnitTestLibrairiClasses_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestChemin1()
        {
            // chemin 	1-5,	6,	17,	18
            int[] tableau = new int[5] { 1, 2, 3, 4, 5 };
            int nbElts = 5;
            int cle = 6;
            int positionCle = Util.rechercheDicho(tableau, nbElts, cle);
            int positionAttendu = -1;
            Assert.AreEqual(positionCle, positionAttendu);
        }

        [TestMethod]
        public void TestChemin2()
        {
            // chemin 	1-5,	6,	7-8,	9,	10,	18
            int[] tableau = new int[5] { 1, 2, 3, 4, 5 };
            int nbElts = 5;
            int cle = 3;
            int positionCle = Util.rechercheDicho(tableau, nbElts, cle);
            int positionAttendu = 2;
            Assert.AreEqual(positionCle, positionAttendu);
        }

        [TestMethod]
        public void TestChemin3()
        {
            // chemin 1-5,	6,	7-8,	9,	11,	12,	13,    6,   7-8,  9,  10,  18
            int[] tableau = new int[5] { 1, 2, 3, 4, 5 };
            int nbElts = 5;
            int cle = 4;
            int positionCle = Util.rechercheDicho(tableau, nbElts, cle);
            int positionAttendu = 3;
            Assert.AreEqual(positionCle, positionAttendu);
        }

        [TestMethod]
        public void TestChemin4()
        {
            // chemin (4)	1-5,	6,	7-8,	9,	11,	12,	14,    15-16,    13,    6,   7-8,  9,  10,  18
            int[] tableau = new int[5] { 1, 2, 3, 4, 5 };
            int nbElts = 5;
            int cle = 1;
            int positionCle = Util.rechercheDicho(tableau, nbElts, cle);
            int positionAttendu = 0;
            Assert.AreEqual(positionCle, positionAttendu);
        }
    }
}