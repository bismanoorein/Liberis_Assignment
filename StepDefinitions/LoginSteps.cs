using Liberis_Assignment.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Liberis_Assignment.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {    //Step Definitions
        
        LoginPage loginPage = null;
        private IWebDriver webdriver;

        [Given(@"\[ I Log  into website]")]
        public void GivenILogIntoWebsite()
        {
            IWebDriver webdriver = new ChromeDriver();
            webdriver.Navigate().GoToUrl("https://www.liberis.com/");
            webdriver.Manage().Window.Maximize();
            webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            loginPage = new LoginPage(webdriver);

        }
        [Given(@"\[ I Open  Get a Demo page]")]
        public void GivenIOpenGetADemoPage()
        {
            
            loginPage.GetDemopage();
        }
               
        
        [Then(@"\[ I navigated to Website ]")]
        public void ThenINavigatedToWebsite()
        {
            
            Assert.That(loginPage.Verify, Is.True);
        }
        [Then(@"\[I see Three types of partners]")]
        public void ThenISeeThreeTypesOfPartners()
        {
            Assert.That(loginPage.AllOptionsdisplayed(), Is.True);
        }



        [Given(@"\[I click on I'm a Broker  option]")]
        public void GivenIClickOnImABrokerOption()
        {
            loginPage.Set_broker_option();
        }

        [Given(@"\[I click on get a demo button]")]
        public void GivenIClickOnGetADemoButton()
        {
            loginPage.submitoption();
            
        }

        [Then(@"\[I  should navigated to broker-form page]")]
        public void ThenIShouldNavigatedToBroker_FormPage()
        {
            
            Assert.That(loginPage.Verify, Is.False);

        }
        [Given(@"\[I click  I'm an ISO  option]")]
        public void GivenIClickImAnISOOption()
        {
            loginPage.Set_ISO_option();
        }

        [Given(@"\[I click on I'm a Strategic Partner  option]")]
        public void GivenIClickOnImAStrategicPartnerOption()
        {
            loginPage.Set_StrategicPartner_option();
        }
        

        [Then(@"\[I see message Please select a type of partner]")]
        public void ThenISeeMessagePleaseSelectATypeOfPartner()
        {
            Assert.That(loginPage.validation(), Is.True);
        }
        [Then(@"\[It select  I'm a strategic Partner option only]")]
        public void ThenItSelectImAStrategicPartnerOptionOnly()
        {
            Assert.That(loginPage.verifyoption, Is.True);
        }


        [Then(@"\[I  should navigated to ""([^""]*)"" page]")]
        public void ThenIShouldNavigatedToPage(string expectedurl)
        {
            expectedurl = "https://www.liberis.com/become-a-partner/broker-iso-form";
            
            string actualurl = loginPage.windowurl();
            Assert.That(actualurl, Is.EqualTo(expectedurl));
        }

       
        [Then(@"\[I sould navigated to ""(.*)"" page]")]
        public void ThenISouldNavigatedToPage(string expectedurl)
        {
            expectedurl = "https://www.liberis.com/become-a-partner/strategic-partner-form";
            string actualurl = loginPage.windowurl();
            Assert.That(actualurl, Is.EqualTo(expectedurl));
        }
        [Given(@"\[I right click on I'm a Broker  option]")]
        public void GivenIRightClickOnImABrokerOption()
        {
            loginPage.Rightclickfunc();
        }
        [Then(@"\[Close the Driver]")]
        public void ThenCloseTheDriver()
        {
            loginPage.CloseBrowser();
           
        }


    }
}

