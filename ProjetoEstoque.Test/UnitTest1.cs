using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ProjetoEstoque.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.taketest.com.br/");
            driver.Manage().Window.Maximize();

            var sobre = driver.FindElement(By.Id("menu-item-19"));
            sobre.Text.Equals("SOBRE");

            driver.Quit();
        }
    }
}
