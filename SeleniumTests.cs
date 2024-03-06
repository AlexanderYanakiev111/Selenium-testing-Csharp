using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
namespace selenium_tests;

public class SeleniumTests
{
    [Test]
    [Category("Selenium")]
    public void goToUrlTest_01()
    {

        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://ecommerce-playground.lambdatest.io/index.php?route=common/home"); 

        driver.Quit(); 
             
    }

    public void logInTest_02()
    {
          
        IWebDriver driver = new ChromeDriver();
          
        IWebElement myAccountDropdownList = driver.FindElement(By.XPath("//span[text()[normalize-space()='My account']]"));
        SelectElement logInButton = new SelectElement(myAccountDropdownList);
        logInButton.SelectByText("//a[contains(text(),'My account')]");

        IWebElement emailAddressField = driver.FindElement(By.Id("input-email"));
        emailAddressField.SendKeys("agyanakiev.workspace@gmail.com");
        IWebElement passwordField = driver.FindElement(By.Id("input-password"));
        passwordField.SendKeys("Alex_123");
       
        IWebElement loginButton = driver.FindElement(By.XPath("//input[@class='btn btn-primary']"));
        loginButton.Click();

        driver.Quit();

    }

    public void addToCartTest_03()
    {

        IWebDriver driver = new ChromeDriver();
        
        IWebElement product = driver.FindElement(By.XPath("//a[@id='mz-product-listing-image-37213259-0-2']/div[1]/div[1]/img[1]"));
        product.Click();
                 
        IWebElement addToCartButton = driver.FindElement(By.XPath("(//button[text()='Add to Cart'])[2]"));
        addToCartButton.Click(); 

        driver.Quit();

    }

    public void ElementIsVisibleInCart_04()
    {

        IWebDriver driver = new ChromeDriver();

        IWebElement cartLink = driver.FindElement(By.XPath("//div[@class='cart-icon']//div)[2])"));
        cartLink.Click();

        IWebElement addedProduct = driver.FindElement(By.XPath("//td[@class='text-left']//a[1]"));
        string productName = addedProduct.Text;

        if (productName == "//td[@class='text-left']//a[1]")
        {
            Console.WriteLine("Product successfully added to cart.");
        }
        else
        {
            Console.WriteLine("Failed to add product to cart.");
        }

        driver.Quit();
    }

    public void checkoutInformationTest_05()
    {

        IWebDriver driver = new ChromeDriver();
      
        IWebElement firstNameField = driver.FindElement(By.Id("input-payment-firstname"));
        firstNameField.SendKeys("Alexander");

        IWebElement lastnameField = driver.FindElement(By.Id("input-payment-lastname"));
        lastnameField.SendKeys("Yanakiev");

        IWebElement emailField = driver.FindElement(By.Id("input-payment-email"));
        emailField.SendKeys("agyanakiev.workspace123@gmail.com");

        IWebElement telephoneField = driver.FindElement(By.Id("input-payment-telephone"));
        telephoneField.SendKeys("+359878589041");

        IWebElement passwordField = driver.FindElement(By.Id("input-payment-password"));
        passwordField.SendKeys("Alex_123");

        IWebElement confirmPasswordField = driver.FindElement(By.Id("input-payment-confirm"));
        confirmPasswordField.SendKeys("Alex_123");

        IWebElement addressField = driver.FindElement(By.Id("input-payment-address-1"));
        addressField.SendKeys("Nicola Vaptsarov 89");

        IWebElement cityField = driver.FindElement(By.Id("input-payment-city"));
        cityField.SendKeys("Plovdiv");

        IWebElement postCodeField = driver.FindElement(By.Id("input-payment-postcode"));
        postCodeField.SendKeys("4000");

        IWebElement countryDropdownList = driver.FindElement(By.XPath("(//div[@class='col-sm-9']//select)[1]"));
        SelectElement country = new SelectElement(countryDropdownList);
        country.SelectByText("(//option[text()='Bulgaria'])[1]");       

        IWebElement regionDropdownList = driver.FindElement(By.XPath("(//select[@class='custom-select'])[2]"));
        SelectElement region = new SelectElement(regionDropdownList);
        region.SelectByValue("//option[@value='491']"); 

        IWebElement agreeToPolicy = driver.FindElement(By.XPath("//label[@for='input-account-agree']"));
        agreeToPolicy.Click();

        IWebElement agreeToTerms = driver.FindElement(By.XPath("//label[@for='input-agree']"));
        agreeToTerms.Click();

        IWebElement continueButton = driver.FindElement(By.XPath("//button[text()='Continue ']"));
        continueButton.Click();

        IWebElement confirmOrderButton = driver.FindElement(By.XPath("//button[text()='Confirm Order ']"));
        confirmOrderButton.Click();

        driver.Quit();

    }

    public void LogoutTest_06()
    {

        IWebDriver driver = new ChromeDriver();
        
        IWebElement myAccountDropdownList = driver.FindElement(By.XPath("//span[text()[normalize-space()='My account']]"));
        SelectElement logOutButton = new SelectElement(myAccountDropdownList);

        logOutButton.SelectByText("//span[text()[normalize-space()='Logout']]");
        
        driver.Quit();
    }


}
