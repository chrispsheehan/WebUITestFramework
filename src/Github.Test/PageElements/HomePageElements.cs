using OpenQA.Selenium;

namespace WebUITestFramework.PageObjects
{
    public static class HomePageElements
    {
        public static readonly By SignInBtn = By.LinkText("Sign in");

        public static readonly By UserField = By.Id("user[login]");

        public static readonly By EmailField = By.Id("user[email]");
    }
}