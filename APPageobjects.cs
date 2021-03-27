using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
//using SeleniumExtras.PageObjects;




namespace Com.Test.Soumya1
{
    public class APPageObjects
    {

        public APPageObjects()
        {


            PageFactory.InitElements(PropertiesCollections.Driver, this);




        }


        [FindsBy(How = How.XPath, Using = ("//a[@class='login']"))]

        public IWebElement Login { get; set; }


        [FindsBy(How = How.Id, Using = ("email"))]

        public IWebElement LoginEmail { get; set; }


        [FindsBy(How = How.Id, Using = ("passwd"))]

        public IWebElement LoginPasswd { get; set; }


        [FindsBy(How = How.Id, Using = ("SubmitLogin"))]

        public IWebElement LoginSubmit { get; set; }


        [FindsBy(How = How.XPath, Using = ("//a[@title ='Home']"))]

        public IWebElement HomeBtn { get; set; }


        [FindsBy(How = How.XPath, Using = ("//div[@class='cat-title']"))]

        public IWebElement CategoriesMenubar { get; set; }


        [FindsBy(How = How.XPath, Using = ("//a[@title='Women']"))]

        public IWebElement WomenMenu { get; set; }


        [FindsBy(How = How.XPath, Using = ("//a[text() ='T-shirts']"))]

        public IWebElement TshirtMenu { get; set; }


        [FindsBy(How = How.XPath, Using = ("//img[@title='Faded Short Sleeve T-shirts']"))]

        public IWebElement AvailableTshirt { get; set; }


        [FindsBy(How = How.XPath, Using = ("//a[@id ='color_2']"))]

        public IWebElement SelectColor { get; set; }


        [FindsBy(How = How.XPath, Using = ("//a[@title='Add to cart']"))]

        public IWebElement AddToCart { get; set; }


        [FindsBy(How = How.XPath, Using = ("//a[@title='Proceed to checkout']"))]

        public IWebElement ProceedCheckout { get; set; }


        [FindsBy(How = How.XPath, Using = ("//a[@class='button btn btn-default standard-checkout button-medium']"))]

        public IWebElement StandardCheckout { get; set; }


        [FindsBy(How = How.XPath, Using = ("//button[@name='processAddress']"))]

        public IWebElement ProcessAdderssBtn { get; set; }


        [FindsBy(How = How.XPath, Using = ("//input[@name='cgv']"))]

        public IWebElement IAgreeTxtBox { get; set; }



        [FindsBy(How = How.XPath, Using = ("//button[@name='processCarrier']"))]

        public IWebElement ProcessOrder { get; set; }



        [FindsBy(How = How.XPath, Using = ("//a[@ title ='Pay by check.']"))]

        public IWebElement PayByCheck { get; set; }



        [FindsBy(How = How.XPath, Using = ("//button[@class ='button btn btn-default button-medium']"))]

        public IWebElement OrdrCnfrm { get; set; }



        [FindsBy(How = How.XPath, Using = ("//div[@class ='box order-confirmation']"))]

        public IWebElement ConfirmationReference { get; set; }



        [FindsBy(How = How.XPath, Using = ("//p[@class ='alert alert-success']"))]

        public IWebElement textconfirmation { get; set; }



        [FindsBy(How = How.XPath, Using = ("//a[@title ='View my customer account']"))]

        public IWebElement MyAccount { get; set; }


        [FindsBy(How = How.XPath, Using = ("//i[@class ='icon-list-ol']"))]

        public IWebElement OrderHistory { get; set; }


        [FindsBy(How = How.XPath, Using = ("//a[@class='color-myaccount'][1]"))]

        public IWebElement Referencetext { get; set; }


        [FindsBy(How = How.XPath, Using = ("//i[@class='icon-user']"))]

        public IWebElement PersonalInfoClick { get; set; }


        [FindsBy(How = How.Id, Using = ("firstname"))]

        public IWebElement FirstNameTextBox { get; set; }


        [FindsBy(How = How.Name, Using = ("old_passwd"))]

        public IWebElement OldPwdTxtBox { get; set; }


        [FindsBy(How = How.Name, Using = ("passwd"))]

        public IWebElement NewPwdTxtBox { get; set; }


        [FindsBy(How = How.Name, Using = ("confirmation"))]

        public IWebElement ConfirmPwdTxtBox { get; set; }


        [FindsBy(How = How.XPath, Using = ("//button[@name='submitIdentity']"))]

        public IWebElement SubmitProfileChange { get; set; }
       

        public void LoginFunction(String Username, String Password)
        {

            APPageObjects page = new APPageObjects();

            page.Login.Click();
            page.LoginEmail.SendKeys(Username);
            page.LoginPasswd.SendKeys(Password);
            page.LoginSubmit.Click();
        }


    }
}
