using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver("C:\\");
            driver.Navigate().GoToUrl("file:///C:/Users/Alejandra/Downloads/QA%20Form.html");
            driver.Manage().Window.Maximize();
            IWebElement imput = driver.FindElement(By.Id("exampleInputName"));
            imput.SendKeys("Hans Gomez");
            driver.FindElement(By.Id("exampleInputEmail1")).SendKeys("hgomezcoron@gmail.com");
            driver.FindElement(By.Id("exampleInputPassword1")).SendKeys("111111");
            IWebElement btn = driver.FindElement(By.Id("saveBTN"));
            btn.Click();

            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(10));
            //wait.until(Your condition)

            //limpiar registros
            driver.FindElement(By.Id("exampleInputName")).SendKeys("pruebas");
            driver.FindElement(By.Id("exampleInputEmail1")).SendKeys("hgomezcoron@gmail.com");
            driver.FindElement(By.Id("exampleInputPassword1")).SendKeys("111111");
            driver.FindElement(By.Id("clearBTN")).Click();

            //Solo enviar registro en blanco
            driver.FindElement(By.Id("saveBTN")).Click();
            driver.Quit();
        }
    }
}
