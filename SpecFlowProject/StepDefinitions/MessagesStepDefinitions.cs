using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using System.Xml.Linq;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class MessagesStepDefinitions
    {
        private ChromeDriver driver;
        private IWebElement messagesLink;
        private IWebElement nameField;
        private IWebElement emailField;
        private IWebElement contentField;
        private IWebElement buttonCreate;

        [Given(@"I have opened a browser")]
        public void GivenIHaveOpenedABrowser()
        {
            driver = new ChromeDriver();
        }
        [Given(@"I have opened a website")]
        public void GivenIHaveOpenedAWebsite()
        {
            driver.Navigate().GoToUrl("https://certicon-testing.azurewebsites.net/");
        }

        [Given(@"I have clicked on Messages")]
        public void GivenIHaveClickedOnMessages()
        {
            messagesLink = driver.FindElement(By.LinkText("Messages"));
            messagesLink.Click();
        }

        [When(@"I have entered a correct name")]
        public void WhenIHaveEnteredACorrectName()
        {
            nameField = driver.FindElement(By.Id("Name"));
            nameField.SendKeys("Franta");
        }

        [When(@"I have entered a correct email")]
        public void WhenIHaveEnteredACorrectEmail()
        {
            emailField = driver.FindElement(By.Id("Email"));
            emailField.SendKeys("franta@voprcalek.cz");
        }

        [When(@"I have entered some message")]
        public void WhenIHaveEnteredSomeMessage()
        {
            contentField = driver.FindElement(By.Id("Content"));
            contentField.SendKeys("Ahoj,tady Francek");
        }

        [When(@"I have clicked the Submit button")]
        public void WhenIHaveClickedTheSubmitButton()
        {
            buttonCreate = driver.FindElement(By.Id("buttonCreate"));
            buttonCreate.Click();
        }
        IWebElement messageInfo;
        [Then(@"I should see that there is a message")]
        public void ThenIShouldSeeThatThereIsAMessage()
        {
            messageInfo = driver.FindElement(By.Id("messageNumber"));
            Assert.AreEqual("You have 1 messages", messageInfo.Text);
        }
        IWebElement savedSuccessInfo;
        [Then(@"I should see the green confirmation message")]
        public void ThenIShouldSeeTheGreenConfirmationMessage()
        {
            savedSuccessInfo = driver.FindElement(By.Id("success"));
            Assert.AreEqual("The message has been saved", savedSuccessInfo.Text);
        }
        [When(@"I haven't entered a correct name")]
        public void WhenIHaventEnteredACorrectName()
        {
            nameField = driver.FindElement(By.Id("Name"));
            nameField.Click();
        }
        IWebElement errorMessage;
        [Then(@"I should see that the name is required")]
        public void ThenIShouldSeeThatTheNameIsRequired()
        {
            errorMessage = driver.FindElement(By.ClassName("validation-summary-errors"));
            Assert.AreEqual("Name is Required", errorMessage.Text);
        }

        [Then(@"I close the Browser")]
        public void ThenICloseTheBrowser()
        {
            driver.Close();
        }

    }
}
