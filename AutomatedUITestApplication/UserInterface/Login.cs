using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace WebApplicationTest.UserInterface
{
    /// <summary>
    /// Class login
    /// </summary>
    public class Login : IDisposable
    {
        /// <summary>
        /// Web driver
        /// </summary>
        private readonly IWebDriver _driver;

        /// <summary>
        /// Login constructor
        /// </summary>
        public Login()
        {
            _driver = new ChromeDriver();
            _driver.Navigate()
                .GoToUrl("http://localhost:1693/");
        }

        [Test]
        public void CheckTitle()
        {
            Assert.IsNotEmpty(_driver.Title);
            Assert.IsNotNull(_driver.Title);
            Assert.AreEqual("Login Page", _driver.Title);
        }

        [Test]
        public void CheckH1Title()
        {
            var h1Text = _driver.FindElement(By.CssSelector("h1"));

            Assert.IsNotNull(h1Text);
            Assert.IsNotNull(h1Text.Text);
            Assert.IsNotEmpty(h1Text.Text);
            Assert.AreEqual("Login", h1Text.Text);
        }

        [Test]
        public void CheckUsernameField()
        {
            var userNameField = _driver.FindElement(By.CssSelector("Input[type*='text'"));
            
            Assert.IsNotNull(userNameField);
        }

        [Test]
        public void CheckPasswordField()
        {
            var passwordField = _driver.FindElement(By.CssSelector("Input[type*='password'"));

            Assert.IsNotNull(passwordField);
        }

        [Test]
        public void CheckRememberMeField()
        {
            var passwordField = _driver.FindElement(By.CssSelector("Input[type*='checkbox'"));

            Assert.IsNotNull(passwordField);
        }

        [Test]
        public void CheckForgetPasswordField()
        {
            var forgetPasswordField = _driver.FindElement(By.LinkText("Forgot Password?"));

            Assert.IsNotNull(forgetPasswordField);
        }

        [Test]
        public void CheckSubmitbuttonField()
        {
            var submitButtonField = _driver.FindElement(By.CssSelector("Button[type *= 'submit'"));

            Assert.IsNotNull(submitButtonField);
            Assert.IsNotNull(submitButtonField.Text);
            Assert.IsNotEmpty(submitButtonField.Text);
            Assert.AreEqual("Login", submitButtonField.Text);
        }

        [Test]
        public void CheckSignupLinkField()
        {
            var signupLinkField = _driver.FindElement(By.LinkText("Sign Up"));

            Assert.IsNotNull(signupLinkField);
        }

        [Test]
        public void CheckUsernameFieldPlaceholder()
        {
            var userNameFieldPlaceHolder = _driver.FindElement(By.CssSelector("Input[type*='text'")).GetAttribute("placeholder");

            Assert.IsNotNull(userNameFieldPlaceHolder);
            Assert.IsNotEmpty(userNameFieldPlaceHolder);
            Assert.AreEqual("Username", userNameFieldPlaceHolder);
        }

        [Test]
        public void CheckPasswordFieldPlaceholder()
        {
            var userNameFieldPlaceHolder = _driver.FindElement(By.CssSelector("Input[type*='password'")).GetAttribute("placeholder");

            Assert.IsNotNull(userNameFieldPlaceHolder);
            Assert.IsNotEmpty(userNameFieldPlaceHolder);
            Assert.AreEqual("Password", userNameFieldPlaceHolder);
        }

        public void Dispose()
        {
            _driver.Quit();
            _driver.Dispose();
        }
    }
}
