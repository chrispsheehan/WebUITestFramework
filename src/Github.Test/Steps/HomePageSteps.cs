using TechTalk.SpecFlow;
using WebUITestFramework.PageObjects;
using Xunit;

namespace WebUITestFramework.Steps
{
    [Binding]
    public class HomePageSteps
    {
        private readonly HomePageObject _homePageObject;

        public HomePageSteps(HomePageObject homePageObject)
        {
            _homePageObject = homePageObject;
        }

        [Given(@"I have not logged in")]
        public void GivenIHaveNotLoggedIn()
        {
            Assert.True(_homePageObject.SignInBtnIsDisplayed());
        }

        [Then(@"I can see the login and password fields")]
        public void ThenICanSeeTheLoginAndPasswordFields()
        {

        }
    }
}