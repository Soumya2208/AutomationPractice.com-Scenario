//using System;
//using OpenQA.Selenium;



//namespace Com.Test.Soumya1
//{
//    class SetMethods
//    {

//        //Login
//        public static void Login()
//        {
//            PageObjects page = new PageObjects();
//            page.Login.Click();
//            page.LoginEmail.SendKeys("soumya.legend@gmail.com");
//            page.LoginPasswd.SendKeys("soumya");
//            page.LoginSubmit.Click();
//        }
//EnterText

//public static void Entertext(String element, String Value, String ElementType,string ObjectPath)
//{
//    if(ElementType == "Id")
//     PropertiesCollections.driver.FindElement(By.Id(element)).SendKeys(Value);
//    else if(ElementType == "Name")
//     PropertiesCollections.driver.FindElement(By.Name(element)).SendKeys(Value);
//    else
//         PropertiesCollections.driver.FindElement(By.XPath(ObjectPath)).SendKeys(Value);
//}


////ClickItem

//public static void ClickItem( String element, String ElementType,string ObjectPath)
//{
//    if (ElementType == "Id")
//         PropertiesCollections.driver.FindElement(By.Id(element)).Click();
//    else if (ElementType == "Name")
//         PropertiesCollections.driver.FindElement(By.Name(element)).Click();
//    else
//         PropertiesCollections.driver.FindElement(By.XPath(ObjectPath)).Click();
//}

////ExtractText

//public static string ExtractText(string ObjectPath)
//{

//    return  PropertiesCollections.driver.FindElement(By.XPath(ObjectPath)).Text;
//}
//    }


//}
