using SauceDemo.Pages;
using SauceDemoAdapterPattern.Config;

namespace SauceDemo.Tests
{
    public class LoginTests
    {
        private IDriver _driver;
        private LoginPage _loginPage;
        private ProductPage _productPage;
        
        [SetUp]
        public void TestInit()
        {
            _driver = new DriverAdapter();
            _driver.Start(Browser.Chrome);
            _loginPage = new LoginPage(_driver);
            _productPage = new ProductPage(_driver);
            _driver.GoToUrl(LoginPage.URL);
        }

        [TearDown]
        public void TestCleanup()
        {
            _driver.Quit();
        }

        [Test]
        public void LoginSuccessfully()
        {
            var credentials = TestConfig.GetCredentials();

            _loginPage.Login(credentials.Username, credentials.Password);

            _productPage.AssertProductPageIsOpen();
        }

    }
}
