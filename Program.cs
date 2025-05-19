using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;





public class Program

{





    private static void Main(string[] args)

    {

        Console.WriteLine("Hello, World!");



        //open chrome browser 

        IWebDriver driver = new ChromeDriver();



        // Launch TurnUp Portal 

        driver.Navigate().GoToUrl("http://horse.industryconnect.io/");

        driver.Manage().Window.Maximize();

        Thread.Sleep(1000);



        // Identify username textbox and enter valid username 

        IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));

        usernameTextbox.SendKeys("hari");



        // Identify password textbox and enter valid password 

        IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));

        passwordTextbox.SendKeys("123123");



        // Identify login button and click on it 



        IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));

        loginButton.Click();

        Thread.Sleep(2000);





        // Check if user has logged in successfully 

        IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

        if (helloHari.Text == "Hello hari!")

        {

            Console.WriteLine("User has Login successful. Test passed!");

        }

        else

        {

            Console.WriteLine("User has not Login failed. Test Failed!");

        }



        //create Time and Material record 





        //navigate to Time and Material Page 

        IWebElement adminstrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul[1]/li[5]/a/span"));

        adminstrationTab.Click();





        IWebElement timeAndMaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul[1]/li[5]/ul/li[3]/a"));

        timeAndMaterialOption.Click();











        //Click on Create New Button 

        IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));

        createNewButton.Click();



        // Select Time from dropdown 

        IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));

        typeCodeDropdown.Click();



        IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));

        timeOption.Click();







        //Type code into Code textbox 

        IWebElement codeTextbox = driver.FindElement(By.Id("Code"));

        codeTextbox.SendKeys("TA Programme");



        //Type descripton into Descripton textbox 

        IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));

        descriptionTextbox.SendKeys("This is a Description");



        //Type price into Price textbox 

        IWebElement priceTagOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));

        priceTagOverlap.Click();



        IWebElement priceTextbox = driver.FindElement(By.Id("Price"));

        priceTextbox.SendKeys("12");



        //Click on Save button 

        IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));

        saveButton.Click();

        Thread.Sleep(3000);





        //Check if Time record created succesfully 

        IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));

        goToLastPageButton.Click();



        IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));





        if (newCode.Text == "TA Programme")

        {

            Console.WriteLine("Time record created successfully!");



        }

        else

        {

            Console.WriteLine("Time record has not created");

        }







    }

}