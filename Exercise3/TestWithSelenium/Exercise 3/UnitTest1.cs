using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Exercise_3
{
    public class Tests
    {

        private WebDriver WebDriver { get; set; } = null!;
        private string DriverPath { get; set; } = "..\\..\\..\\..\\Resources\\ChromDriver";
        private string BaseUrl { get; set; } = "https://www.saucedemo.com";

        private void TestLogin(string username, string password)
        {
            WebDriver.Navigate().GoToUrl(BaseUrl);

            var userName = WebDriver.FindElement(By.Id("user-name"));
            userName.Clear();
            userName.SendKeys(username);

            var Password = WebDriver.FindElement(By.Id("password"));
            Password.Clear();
            Password.SendKeys(password);

            var loginButton = WebDriver.FindElement(By.Id("login-button"));
            loginButton.Click();

            Assert.AreEqual("https://www.saucedemo.com/inventory.html", WebDriver.Url); ;
        }

        [SetUp]
        public void Setup()
        {
            WebDriver = GetChromeDriver();
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
        }

        [TearDown]
        public void Teardown()
        {
            WebDriver.Quit();
        }

        [Test]
        public void TestWith_standard_user()
        {
            string username = "standard_user";

            string password = "secret_sauce";

            TestLogin(username, password);
        }

        [Test]
        public void TestWith_visual_user()
        {
            string username = "visual_user";

            string password = "secret_sauce";

            TestLogin(username, password);
        }
        private WebDriver GetChromeDriver()
        {
            var options = new ChromeOptions();
            options.AddArguments("--headless");


            return new ChromeDriver(DriverPath, options, TimeSpan.FromSeconds(300));
        }
    }
}