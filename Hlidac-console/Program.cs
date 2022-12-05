using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Net.Mail;

WebDriver driver = new ChromeDriver();
driver.Navigate().GoToUrl("https://profidentist.xdent.cz/clinicSelection");
var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Pokračovat']"))).Click();
wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Pokračovat']"))).Click();
wait.Until(ExpectedConditions.UrlToBe("https://profidentist.xdent.cz/staffSelection"));
bool OK = false;
IWebElement neniTermin;
try {
    neniTermin = driver.FindElement(By.TagName("h2"));
    OK = true;
}
catch {
        MailMessage mail = new MailMessage("hlidacizub@vsb.cz", "jarmila.krupova@vsb.cz", "Hlídací zub hlásí volný termín!", "viz 'https://profidentist.xdent.cz/clinicSelection'");
        SmtpClient klient = new SmtpClient("smtp.vsb.cz");
        klient.Send(mail); 
}
finally {
    driver.Close();
}
