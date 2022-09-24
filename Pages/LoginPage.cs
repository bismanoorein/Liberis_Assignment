using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Liberis_Assignment.Pages
{
    public class LoginPage
    {

        public IWebDriver WebDriver { get; }
        public LoginPage(IWebDriver webDriver)
        {

            WebDriver = webDriver;

        }
        //  Webpage Elements
        public IWebElement getademopagebtn => WebDriver.FindElement(By.XPath("//*[@id=\"site-inner-wrapper\"]/main/div[1]/div/div[2]/div/div/div/a"));

        public IWebElement title => WebDriver.FindElement(By.XPath("//div[@class='inner-content' ]"));
        public IWebElement broker => WebDriver.FindElement(By.XPath("//*[@id=\"site-inner-wrapper\"]/main/section/div[2]/div/div[2]/div/div[1]/div[1]/label"));
        public IWebElement ISO => WebDriver.FindElement(By.XPath("//*[@id=\"site-inner-wrapper\"]/main/section/div[2]/div/div[2]/div/div[1]/div[2]/label"));
        public IWebElement Strategic_partner => WebDriver.FindElement(By.XPath("//*[@id=\"site-inner-wrapper\"]/main/section/div[2]/div/div[2]/div/div[1]/div[3]/label"));
        public IWebElement demobtn => WebDriver.FindElement(By.XPath("//a[@class='btn btn--medium js-partner-hero-button']"));
        public IWebElement NoOptiontext => WebDriver.FindElement(By.XPath("//div[@class='ph-error-inner']"));

        //  click on Get a demo page
        public void GetDemopage()=> getademopagebtn.Click();
        
        // verify if user on correct webpage
        public bool Verify()
        {
            bool flag;
            string Actualtitle = WebDriver.Title;
            string expectedtitle = "Become A Partner | Liberis";
            flag = Actualtitle.Equals(expectedtitle);
            return flag;
        }
        // verify if selected option get selected or not
        public bool verifyoption()
        {
            string selectedoption = Strategic_partner.Text;
            bool flag = selectedoption.Equals("I'm a Strategic Partner");
            return flag;
        }
        // Verify all options displayed on partner page
        public  bool AllOptionsdisplayed()
        {
            bool flag=false;
            string brk=broker.Text;
            string iso = ISO.Text;
            string strategic = Strategic_partner.Text;
            if (brk.Equals("I'm a Broker") && iso.Equals("I'm an ISO") && strategic.Equals("I'm a Strategic Partner"))
            flag = true;
            return flag;
        }
        // Return website URL
        public string  windowurl()
        {                       
            return this.WebDriver.Url;
        }
        // Selecting options
        public void Set_broker_option() => broker.Click();
        public void Set_ISO_option() => ISO.Click();
        public void Set_StrategicPartner_option() => Strategic_partner.Click();

        // Going to registration page after selecting option
        public void submitoption()=>   demobtn.Click();
         
        // Verify if no option selected
        public bool validation()
        {
            bool flag;
            string text = NoOptiontext.Text;
            flag = text.Equals("Please select a type of partner");
            return flag;

        }
        // Right cick on the options
        public void Rightclickfunc()
        {
            Actions action = new Actions(WebDriver);
            action.ContextClick(broker).Perform();
                  

        }
        //  Close the Browser
        public void CloseBrowser() => this.WebDriver.Close();
        
    }
}
