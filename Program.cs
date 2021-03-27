using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace Com.Test.Soumya1
{
    class MainClass
    {
        // private  SetMethods;

        //IWebDriver driver = new ChromeDriver();

        //public static void Main(string[] args)
        //{

        //}



        [SetUp]

        public void Initialize()
        {
            PropertiesCollections.Driver = new ChromeDriver();

            PropertiesCollections.Driver.Navigate().GoToUrl("http://automationpractice.com");

            Console.WriteLine("Opened URL");

            //Maximize the window

            PropertiesCollections.Driver.Manage().Window.Maximize();

            PropertiesCollections.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);




        }



        [Test]

        public void ExecuteTest1()
        {
            //implicit wait
            //PropertiesCollections.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //Using page Object model
            APPageObjects page = new APPageObjects();

            //Login
            page.LoginFunction("soumya.legend@gmail.com", "soumya");



            page.HomeBtn.Click();
            if (page.CategoriesMenubar.Displayed == true)
            {
                page.CategoriesMenubar.Click();
            }

            //Select T- Shirt
            page.WomenMenu.Click();
            Actions actions = new Actions(PropertiesCollections.Driver);
            actions.MoveToElement(page.WomenMenu).Perform();

            if (page.TshirtMenu.Displayed == true)
            { page.TshirtMenu.Click(); }
            if (page.AvailableTshirt.Displayed == true)
            { page.SelectColor.Click(); }

            //Adding To cart and Checkout

            page.AddToCart.Click();
            page.ProceedCheckout.Click();
            page.StandardCheckout.Click();
            page.ProcessAdderssBtn.Click();

            page.IAgreeTxtBox.Click();
            page.ProcessOrder.Click();
            page.PayByCheck.Click();
            page.OrdrCnfrm.Click();

            string OrderReference = page.ConfirmationReference.Text;

            //Check If Order Is Placed

            page.MyAccount.Click();
            page.OrderHistory.Click();
            string FinalOrderReference = page.Referencetext.Text;

            if (OrderReference.Contains(FinalOrderReference))
            {
                Console.WriteLine("Scenario One Passed");
            }
            else
            {
                Console.WriteLine("Scenario One Failed");
            }

            ////Login
            //var Login = "//a[@class='login']";
            // PropertiesCollections.driver.FindElement(By.XPath(Login)).Click();


            // PropertiesCollections.driver.FindElement(By.Id("email")).SendKeys("soumya.legend@gmail.com");
            // PropertiesCollections.driver.FindElement(By.Id("passwd")).SendKeys("soumya");
            // PropertiesCollections.driver.FindElement(By.Id("SubmitLogin")).Click();


            ////Click on Home Button
            //var Homebtn = "//a[@title ='Home']";

            // PropertiesCollections.driver.FindElement(By.XPath(Homebtn)).Click();

            //var categories =  PropertiesCollections.driver.FindElement(By.XPath("//div[@class='cat-title']"));


            //if (categories.Displayed == true)
            //{

            //    categories.Click();

            //}

            ////Selecting T-Shirt From Menu

            //var WomenMenu =  PropertiesCollections.driver.FindElement(By.XPath("//a[@title='Women']"));
            //Actions actions = new Actions(PropertiesCollections.driver);
            //actions.MoveToElement(WomenMenu).Perform();

            //var TshirtMenu =  PropertiesCollections.driver.FindElement(By.XPath("//a[text() ='T-shirts']"));


            //if (TshirtMenu.Displayed == true)
            //{ TshirtMenu.Click(); }

            //if ( PropertiesCollections.driver.FindElement(By.XPath("//img[@title='Faded Short Sleeve T-shirts']")).Displayed == true)
            //{
            //     PropertiesCollections.driver.FindElement(By.XPath("//a[@id ='color_2']")).Click();

            //}

            // PropertiesCollections.driver.FindElement(By.XPath("//a[@title='Add to cart']")).Click();
            ////Proceed to checkout

            // PropertiesCollections.driver.FindElement(By.XPath("//a[@title='Proceed to checkout']")).Click();

            // PropertiesCollections.driver.FindElement(By.XPath("//a[@class='button btn btn-default standard-checkout button-medium']")).Click();

            ////Address Confirmation Page

            // PropertiesCollections.driver.FindElement(By.XPath("//button[@name='processAddress']")).Click();

            ////Shipping Page

            //PropertiesCollections.driver.FindElement(By.XPath("//input[@name='cgv']")).Click();

            // PropertiesCollections.driver.FindElement(By.XPath("//button[@name='processCarrier']")).Click();

            ////Choosing Payment

            // PropertiesCollections.driver.FindElement(By.XPath("//a[@ title ='Pay by check.']")).Click();

            ////confirming the order

            // PropertiesCollections.driver.FindElement(By.XPath("//button[@class ='button btn btn-default button-medium']")).Click();

            ////Get Text

            //string ConfirmationReference =  PropertiesCollections.driver.FindElement(By.XPath("//div[@class ='box order-confirmation']")).Text;

            //string textconfirmation =  PropertiesCollections.driver.FindElement(By.XPath("//p[@class ='alert alert-success']")).Text;

            //if (textconfirmation.Contains("complete"))
            //{
            //    Console.WriteLine("The Order Is Completed");

            //}

            //else
            //{
            //    Console.WriteLine("Order Failed");

            //}

            ////Go to Account

            // PropertiesCollections.driver.FindElement(By.XPath("//a[@title ='View my customer account']")).Click();

            ////Click on Order History and Details

            // PropertiesCollections.driver.FindElement(By.XPath("//i[@class ='icon-list-ol']")).Click();


            ////if( PropertiesCollections.driver.FindElement(By.XPath("//tr[@class='first_item ']")).Displayed==true)
            //// {
            //string Referencetext =  PropertiesCollections.driver.FindElement(By.XPath("//a[@class='color-myaccount'][1]")).Text;

            //// }

            //if (ConfirmationReference.Contains(Referencetext))

            //{
            //    Console.WriteLine("Scenario 1 Passed");

            //}
            //else
            //{
            //    Console.WriteLine("Scenario 1 Failed");
            //}

            ///*******************************************************************************************************/
            ///*******************************************************************************************************/

            //Console.WriteLine("Executed Test1");

        }

        [Test]
        public void ExecuteTest2()
        {
            //Scenario 2

            APPageObjects page = new APPageObjects();

            //Go to Account
            if (page.Login.Displayed == true)
            {
                Console.WriteLine("Login Required");

                page.LoginFunction("soumya.legend@gmail.com", "soumya");
            }
           

            page.MyAccount.Click();
            page.PersonalInfoClick.Click();
            //Update name
            page.FirstNameTextBox.Clear();
            page.FirstNameTextBox.SendKeys("Soumya");
            String FirstNameText = page.FirstNameTextBox.Text;
            page.OldPwdTxtBox.SendKeys("soumya");
            page.NewPwdTxtBox.SendKeys("soumya");
            page.ConfirmPwdTxtBox.SendKeys("soumya");

            page.SubmitProfileChange.Click();

            if (page.MyAccount.Text.Contains(FirstNameText))
            { Console.WriteLine("Scenario 2 Passed"); }
            else
            { Console.WriteLine("Scenario 2 Failed"); }
            // PropertiesCollections.driver.FindElement(By.XPath("//a[@title ='View my customer account']")).Click();

            ////Click on my personal Information
            // PropertiesCollections.driver.FindElement(By.XPath("//i[@class='icon-user']")).Click();

            ////Update first Name

            // PropertiesCollections.driver.FindElement(By.Id("firstname")).SendKeys("Soumya");
            //string firstname =  PropertiesCollections.driver.FindElement(By.XPath("//input[@id='firstname']")).Text;

            ////save text in a variable

            ////var Firstnamecheck =  PropertiesCollections.driver.FindElement(By.XPath("//input[@id='firstname']")).Text;

            ////save changes
            // PropertiesCollections.driver.FindElement(By.Name("old_passwd")).SendKeys("soumya");
            // PropertiesCollections.driver.FindElement(By.Name("passwd")).SendKeys("soumya");
            // PropertiesCollections.driver.FindElement(By.Name("confirmation")).SendKeys("soumya");


            // PropertiesCollections.driver.FindElement(By.XPath("//button[@name='submitIdentity']")).Click();

            //if ( PropertiesCollections.driver.FindElement(By.XPath("//a[@title ='View my customer account']")).Text.Contains(firstname))
            //{
            //    Console.WriteLine("Scenario 2 Passed");
            //}
            //else
            //{
            //    Console.WriteLine("Scenario 2 Failed");
            //}
            Console.WriteLine("Executed Test2");
        }


        [TearDown]
        public void Cleanup()
        {
            //Closing Driver
            PropertiesCollections.Driver.Close();
            Console.WriteLine("Closed Browser");
        }
    }
}
