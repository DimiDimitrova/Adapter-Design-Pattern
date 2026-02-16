using AngleSharp.Dom;
using OpenQA.Selenium;
using SauceDemo.Enums;

namespace SauceDemo.Pages
{
    public class ProductPage : WebPage
    {
        public ProductPage(IDriver driver) : base(driver)
        {
        }

        public IComponent AddToCartButton => Driver.FindComponent(By.Id("add-to-cart"));
        public IComponent OpenProductButton(string productName) => Driver.FindComponent(By.XPath($"//*[text()='{productName}']"));

        public void AddToCart()
        {
            AddToCartButton.Click();
        }

        public void SelectProduct(ProductName product)
        {
            OpenProductButton(product.GetDescription()).Click();
        }

        public void AssertProductPageIsOpen()
        {
            Assert.That(Driver.Url, Is.EqualTo("https://www.saucedemo.com/inventory.html"));
        }
    }
}
