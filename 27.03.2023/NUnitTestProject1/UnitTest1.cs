using NUnit.Framework;
using _27._03._2023;

namespace NUnitTestProject1
{
    public class Tests
    {
        Herni_postava postava = new Herni_postava();
        Hrac player = new Hrac();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1POS()
        {
            string name = postava.jmeno;    //jmeno kratší než 10;
            Assert.IsTrue(name.Length <= 10); 
        }

        [Test]
        public void Test1NEG()
        {
            string name = postava.jmeno ;   //jmeno delší než 10;
            Assert.IsTrue(name.Length > 10);
        }

        [Test]
        public void Test2POS()
        {
            int level = postava.level;      //zjištìní správne inicializace
            int x = postava.pozice_X, y = postava.pozice_Y;
            Assert.IsTrue(level == 1 && x == 0 && y == 0);
        }

        [Test]
        public void Test2NEG()
        {
            int level = postava.level;      //zjištìní nesprávne inicializace
            int x = postava.pozice_X, y = postava.pozice_Y;
            Assert.IsTrue(level != 1 && x != 0 && y != 0);
        }

        [Test]
        public void Test3POS()
        {
            int poz_x = postava.pozice_X; //testování zmìny pozice
            int poz_y = postava.pozice_Y;

            int poz_mysiX = postava.mys_pozX;
            int poz_mysiY = postava.mys_pozY;
            //volaní funkce, zmìna pozice
            postava.zmena_pozice();

            Assert.AreEqual(poz_x + poz_y, poz_mysiX + poz_mysiY);
        }

        [Test]
        public void Test3NEG()
        {
            int poz_x = postava.pozice_X; //testování zmìny pozice
            int poz_y = postava.pozice_Y;

            int poz_mysiX = postava.mys_pozX;
            int poz_mysiY = postava.mys_pozY;
            //volaní funkce, zmìna pozice
            postava.zmena_pozice();

            Assert.AreEqual(poz_x - poz_y, poz_mysiX - poz_mysiY);
        }

        [Test]
        public void Test4POS()
        {
            string specizalizace = player.specializace; //testování nespravného názvu specializace
            Assert.IsTrue(specizalizace == "Kouzelník" || specizalizace == "Berserker" || specizalizace == "Inženýr" || specizalizace == "Cizák");
        }

        [Test]
        public void Test4NEG()
        {
            string specizalizace = player.specializace; //testování nespravného názvu specializace
            Assert.IsTrue(specizalizace != "Kouzelník" && specizalizace != "Berserker" && specizalizace != "Inženýr" && specizalizace != "Cizák");
        }

        [Test]
        public void Test5POS()
        {
            int XP = player.XP; //testování  spravné inicializace XP
            Assert.AreEqual(XP, 0);
        }

        [Test]
        public void Test5NEG()
        {
            int XP = player.XP; //testování nespravné inicializace XP
            Assert.AreNotEqual(XP, 0);
        }

        [Test]
        public void Test6POS()
        {
            Assert.IsTrue(Hrac.vlasy.drdol == 0); //test pozice v enumu
        }

        [Test]
        public void Test6NEG()
        {
            Assert.IsFalse(Hrac.vlasy.drdol == 0); //test pozice v enumu
        }

        [Test]
        public void Test7POS()
        {
            int ADD_XP = 1; //testování pøidej XP funkce 
            int XP = player.XP;
            player.pridej_xp(ADD_XP);
            Assert.AreEqual(player.XP, XP + ADD_XP);
        }

        [Test]
        public void Test7NEG()
        {
            int ADD_XP = 1; //testování pøidej XP funkce 
            int XP = player.XP;
            player.pridej_xp(ADD_XP);
            Assert.AreNotEqual(player.XP, XP + ADD_XP);
        }

        [Test]
        public void Test8POS()
        {
            int lvl = postava.level; //testování pøidej XP funkce 
            player.pridej_xp(100 * lvl + 1);
            Assert.AreEqual(postava.level, lvl + 1);
        }

        [Test]
        public void Test8NEG()
        {
            int lvl = postava.level; //testování pøidej XP funkce 
            player.pridej_xp(100 * lvl + 1);
            Assert.AreNotEqual(postava.level, lvl + 1);
        }

        [Test]
        public void Test9POS()
        {
            int poz_x = postava.pozice_X; //testování rovnosti daných pozic
            int poz_y = postava.pozice_Y;

            int poz_mysiX = postava.mys_pozX;
            int poz_mysiY = postava.mys_pozY;
            //volaní funkce, zmìna pozice
            postava.zmena_pozice();

            Assert.IsTrue(poz_x == poz_mysiX && poz_y == poz_mysiY);
        }

        [Test]
        public void Test9NEG()
        {
            int poz_x = postava.pozice_X; //testování rovnosti daných pozic
            int poz_y = postava.pozice_Y;

            int poz_mysiX = postava.mys_pozX;
            int poz_mysiY = postava.mys_pozY;
            //volaní funkce, zmìna pozice
            postava.zmena_pozice();

            Assert.IsFalse(poz_x == poz_mysiX && poz_y == poz_mysiY);
        }

        [Test]
        public void Test10POS()
        {
            Assert.IsTrue(Hrac.oblicej.velky_nos == 0); //test pozice v enumu
        }

        [Test]
        public void Test10NEG()
        {
            Assert.IsFalse(Hrac.oblicej.velky_nos == 0); //test pozice v enumu
        }
    }
} 