using OpenQA.Selenium;

namespace SauceDemo.Pages
{
    public class LoginPage : WebPage
    {
        public LoginPage(IDriver driver) : base(driver)
        {
        }

        public IComponent UsernameField => Driver.FindComponent(By.XPath("//input[@data-test='username']"));
        public IComponent PasswordField => Driver.FindComponent(By.XPath("//input[@data-test='password']"));
        public IComponent LoginButton => Driver.FindComponent(By.Id("login-button"));

        public void Login(string username, string password) 
        {
            UsernameField.TypeText(username);
            PasswordField.TypeText(password);
            LoginButton.Click();
        }

        public const string URL = "https://www.saucedemo.com/";
    }
}