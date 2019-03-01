using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests1
{
    [TestFixture]
    public class TestClass : Initialization
    {
        [Test]
        public void Test1()
        {
            driver.FindElement(By.XPath("//a[@id='uhfLogo']")).Click();
        }
    }
    
}
