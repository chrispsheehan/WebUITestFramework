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
            Assert.True(_homePageObject.SignInBtnIsDisplayed(), "User is alread logged in.");
        }

        [Then(@"I can see the login and email fields")]
        public void ThenICanSeeTheLoginAndPasswordFields()
        {
            Assert.True(_homePageObject.UserFieldIsdisplayed(), "User field was not displayed.");

            Assert.True(_homePageObject.EmailFieldIsdisplayed(), "Email field was not displayed.");
        }
    }
}