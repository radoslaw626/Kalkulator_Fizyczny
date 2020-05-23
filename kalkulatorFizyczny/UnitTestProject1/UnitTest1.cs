using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using kalkulatorFizyczny;
using System.Reflection;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod0()
        {
            string expected = "50";
            var test1 = new Form1();
            test1.list1.SelectedIndex = 0;
            test1.textBox1.Text = "10";
            test1.textBox2.Text = "5";
            test1.ObliczButton();
            Assert.AreEqual(expected, test1.label3.Text, "Nie dziala");

        }
        [TestMethod]
        public void TestMethod1()
        {
            string expected = "1"; 
            var test1 = new Form1();
            test1.listBox1.SelectedIndex = 4;
            test1.listBox2.SelectedIndex = 8;
            test1.textBox4.Text = "1000000";
            test1.PrzelicznikButton();
            Assert.AreEqual(expected, test1.label4.Text, "Nie dziala") ; 
        }
        [TestMethod]
        public void TestMethod2()
        {
            int expected = 4;
            var test1 = new Form1();
            test1.listBox1.SelectedIndex = 4;
            Assert.AreEqual(expected, test1.listBox1.SelectedIndex, "Nie dziala");
        }
        [TestMethod]
        public void TestMethod3() 
        {
            int expected = 8;
            var test1 = new Form1();
            test1.listBox2.SelectedIndex = 8;
            Assert.AreEqual(expected, test1.listBox2.SelectedIndex, "Nie dziala");
        }
    }
}
