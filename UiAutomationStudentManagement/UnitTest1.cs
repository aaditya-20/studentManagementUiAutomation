using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Safari;

namespace UiAutomationStudentManagement;

public class Tests
{
    public IWebDriver Driver;

    [SetUp]
    public void Setup()
    {
        var chromeOptions = new ChromeOptions();
        //chromeOptions.BinaryLocation("/Applications/Google\Chrome.app/Contents/MacOS/Google\Chrome");

        chromeOptions.AddArguments("headless");
        chromeOptions.AddArguments("window-size=1920,1080");
        Driver = new ChromeDriver(chromeOptions);
        Console.WriteLine("setup");
    }

    [Test]
    public void Test1()
    {
        Console.WriteLine("test1");
        Driver.Navigate().GoToUrl("http://localhost:3000");
        // send keys are for typing
        Driver.FindElement(By.Id("name")).SendKeys("Aaditya");
        Thread.Sleep(2000);
        Driver.FindElement(By.Id("email")).SendKeys("aaditya@gmail.com");
        Thread.Sleep(2000);
        Driver.FindElement(By.Id("password")).SendKeys("Aaditya");
        Thread.Sleep(2000);
        Driver.FindElement(By.Id("submit")).Click();
        Thread.Sleep(2000);
        // Assert.That(Driver.Url, Is.EqualTo('http://localhost:3000'));
        // adding a student and then checking
        Thread.Sleep(2000);
        Driver.FindElement(By.Id("studentName")).SendKeys("student1");
        Driver.FindElement(By.Id("studentPhoneNumber")).SendKeys("1234567890");
        Driver.FindElement(By.Id("addStudent")).Click();



        // viewing student
        Thread.Sleep(2000);
        Driver.FindElement(By.Id("viewList")).Click();

        Thread.Sleep(2000);

        Assert.Pass();
    }


    [Test]
    public void Test2()
    {
        Console.WriteLine("test2");
        Thread.Sleep(2000);
        Driver.Navigate().GoToUrl("http://localhost:3000/login");
        Thread.Sleep(2000);
       
        Driver.FindElement(By.Id("email")).SendKeys("aaditya@gmail.com");
        Thread.Sleep(2000);
        Driver.FindElement(By.Id("password")).SendKeys("Aaditya");
        Thread.Sleep(2000);
        Driver.FindElement(By.Id("submit")).Click();
        Thread.Sleep(2000);
        // Assert.That(Driver.Url, Is.EqualTo('http://localhost:3000'));
        //adding a student and then checking

        Driver.FindElement(By.Id("studentName")).SendKeys("student2");
        Thread.Sleep(2000);
        Driver.FindElement(By.Id("studentPhoneNumber")).SendKeys("01234567890");
        Thread.Sleep(2000);
        Driver.FindElement(By.Id("addStudent")).Click();
        // viewing student
        Thread.Sleep(2000);


        Driver.FindElement(By.Id("viewList")).Click();
        Thread.Sleep(2000);

        Assert.Pass();
    }
    [Test]
    public void Test3()
    {
        Console.WriteLine("test1");
        Thread.Sleep(2000);
        Driver.Navigate().GoToUrl("http://localhost:3000/login");
        Thread.Sleep(2000);
        // send keys are for typing
        //Driver.FindElement(By.Id("name")).SendKeys("Aaditya");
        Thread.Sleep(2000);
        Driver.FindElement(By.Id("email")).SendKeys("aaditya@gmail.com");
        Thread.Sleep(2000);
        Driver.FindElement(By.Id("password")).SendKeys("Aaditya");
        Thread.Sleep(2000);
        Driver.FindElement(By.Id("submit")).Click();
        Thread.Sleep(2000);
        // Assert.That(Driver.Url, Is.EqualTo('http://localhost:3000'));
        //adding a student and then checking

        


        Driver.FindElement(By.Id("logOut")).Click();


        Assert.Pass();
    }
    [TearDown]
    public void TearDown()
    {
        // Close the browser after each test
       // Driver.Quit();
    }
}
