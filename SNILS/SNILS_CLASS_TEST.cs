using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SNILS_LIBRARY;

namespace SNILS
{
    [TestClass]
    public class SNILS_CLASS_TEST
    {
        [TestMethod]
        public void Null_Text_CheckPersonakCode()
        {
            //Arange
            string textString = " ";
            bool expected = false;
            //Act
            SNILS_CLASS sn = new SNILS_CLASS();
            bool actual = sn.CheckPersonakCode(textString);
            //Assets
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Uncorect_Text_CheckPersonakCode()
        {
            //Arange
            string textString = "112-233-445 95";
            bool expected = false;
            //Act
            SNILS_CLASS sn = new SNILS_CLASS();
            bool actual = sn.CheckPersonakCode(textString);
            //Assets
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Uncorect_Limit_Text_CheckPersonakCode()
        {
            //Arange
            string textString = "333";
            bool expected = false;
            //Act
            SNILS_CLASS sn = new SNILS_CLASS();
            bool actual = sn.CheckPersonakCode(textString);
            //Assets
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Uncorect_Limit_Max_Text_CheckPersonakCode()
        {
            //Arange
            string textString = "999999999999999999999";
            bool expected = false;
            //Act
            SNILS_CLASS sn = new SNILS_CLASS();
            bool actual = sn.CheckPersonakCode(textString);
            //Assets
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Correct01_Text_CheckPersonakCode()
        {
            //Arange
            string textString = "15795916329";
            bool expected = true;
            //Act
            SNILS_CLASS sn = new SNILS_CLASS();
            bool actual = sn.CheckPersonakCode(textString);
            //Assets
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void Correct02_Text_CheckPersonakCode()
        {
            //Arange
            string textString = "20401330880";
            bool expected = true;
            //Act
            SNILS_CLASS sn = new SNILS_CLASS();
            bool actual = sn.CheckPersonakCode(textString);
            //Assets
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Correct03_Text_CheckPersonakCode()
        {
            //Arange
            string textString = "17611432955";
            bool expected = true;
            //Act
            SNILS_CLASS sn = new SNILS_CLASS();
            bool actual = sn.CheckPersonakCode(textString);
            //Assets
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Correct04_Text_CheckPersonakCode()
        {
            //Arange
            string textString = "19160771478";
            bool expected = true;
            //Act
            SNILS_CLASS sn = new SNILS_CLASS();
            bool actual = sn.CheckPersonakCode(textString);
            //Assets
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Correct05_Text_CheckPersonakCode()
        {
            //Arange
            string textString = "16570395587";
            bool expected = true;
            //Act
            SNILS_CLASS sn = new SNILS_CLASS();
            bool actual = sn.CheckPersonakCode(textString);
            //Assets
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Correct06_Text_CheckPersonakCode()
        {
            //Arange
            string textString = "17838689649";
            bool expected = true;
            //Act
            SNILS_CLASS sn = new SNILS_CLASS();
            bool actual = sn.CheckPersonakCode(textString);
            //Assets
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Correct07_Text_CheckPersonakCode()
        {
            //Arange
            string textString = "16992402305";
            bool expected = true;
            //Act
            SNILS_CLASS sn = new SNILS_CLASS();
            bool actual = sn.CheckPersonakCode(textString);
            //Assets
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Correct08_Text_CheckPersonakCode()
        {
            //Arange
            string textString = "20398397186";
            bool expected = true;
            //Act
            SNILS_CLASS sn = new SNILS_CLASS();
            bool actual = sn.CheckPersonakCode(textString);
            //Assets
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Correct09_Text_CheckPersonakCode()
        {
            //Arange
            string textString = "19978255360";
            bool expected = true;
            //Act
            SNILS_CLASS sn = new SNILS_CLASS();
            bool actual = sn.CheckPersonakCode(textString);
            //Assets
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Correct10_Text_CheckPersonakCode()
        {
            //Arange
            string textString = "16067055052";
            bool expected = true;
            //Act
            SNILS_CLASS sn = new SNILS_CLASS();
            bool actual = sn.CheckPersonakCode(textString);
            //Assets
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Correct11_Text_CheckPersonakCode()
        {
            //Arange
            string textString = "20043715906";
            bool expected = true;
            //Act
            SNILS_CLASS sn = new SNILS_CLASS();
            bool actual = sn.CheckPersonakCode(textString);
            //Assets
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Correct12_Text_CheckPersonakCode()
        {
            //Arange
            string textString = "20874913181";
            bool expected = true;
            //Act
            SNILS_CLASS sn = new SNILS_CLASS();
            bool actual = sn.CheckPersonakCode(textString);
            //Assets
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Correct13_Text_CheckPersonakCode()
        {
            //Arange
            string textString = "15955163599";
            bool expected = true;
            //Act
            SNILS_CLASS sn = new SNILS_CLASS();
            bool actual = sn.CheckPersonakCode(textString);
            //Assets
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Correct14_Text_CheckPersonakCode()
        {
            //Arange
            string textString = "19596091835";
            bool expected = true;
            //Act
            SNILS_CLASS sn = new SNILS_CLASS();
            bool actual = sn.CheckPersonakCode(textString);
            //Assets
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Correct15_Text_CheckPersonakCode()
        {
            //Arange
            string textString = "16454064666";
            bool expected = true;
            //Act
            SNILS_CLASS sn = new SNILS_CLASS();
            bool actual = sn.CheckPersonakCode(textString);
            //Assets
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Correct16_Text_CheckPersonakCode()
        {
            //Arange
            string textString = "15974550714";
            bool expected = true;
            //Act
            SNILS_CLASS sn = new SNILS_CLASS();
            bool actual = sn.CheckPersonakCode(textString);
            //Assets
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Correct17_Text_CheckPersonakCode()
        {
            //Arange
            string textString = "20208120183";
            bool expected = true;
            //Act
            SNILS_CLASS sn = new SNILS_CLASS();
            bool actual = sn.CheckPersonakCode(textString);
            //Assets
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Correct18_Text_CheckPersonakCode()
        {
            //Arange
            string textString = "20149847051";
            bool expected = true;
            //Act
            SNILS_CLASS sn = new SNILS_CLASS();
            bool actual = sn.CheckPersonakCode(textString);
            //Assets
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Correct19_Text_CheckPersonakCode()
        {
            //Arange
            string textString = "17460248064";
            bool expected = true;
            //Act
            SNILS_CLASS sn = new SNILS_CLASS();
            bool actual = sn.CheckPersonakCode(textString);
            //Assets
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Correct20_Text_CheckPersonakCode()
        {
            //Arange
            string textString = "20057830427";
            bool expected = true;
            //Act
            SNILS_CLASS sn = new SNILS_CLASS();
            bool actual = sn.CheckPersonakCode(textString);
            //Assets
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Correct21_Text_CheckPersonakCode()
        {
            //Arange
            string textString = "20508756552";
            bool expected = true;
            //Act
            SNILS_CLASS sn = new SNILS_CLASS();
            bool actual = sn.CheckPersonakCode(textString);
            //Assets
            Assert.AreEqual(expected, actual);
        }
    }
}
