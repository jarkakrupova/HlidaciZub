using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace HlidaciZub {
    [TestClass]
    public class UnitTest1 {
        private ChromeDriver driver;

        [TestMethod]
        public void TestMethod1() {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://profidentist.xdent.cz/clinicSelection");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            wait.Until(driver => driver.FindElements(By.TagName("span")));
            var spany = driver.FindElements(By.TagName("span"));
            foreach (var item in spany) {
                //Console.WriteLine(item.Text);
                System.Diagnostics.Debug.WriteLine(item.Text);
                if (item.Text == "Pokraèovat") {
                    item.Click();
                }
            }

            //var spany2 = driver.FindElements(By.TagName("span"));
            //foreach (var item in spany2) {
            //    //Console.WriteLine(item.Text);
            //    System.Diagnostics.Debug.WriteLine(item.Text);
            //    if (item.Text == "Pokraèovat") {
            //        item.Click();
            //    }
            //}
            //var titulek = driver.FindElement(By.ClassName("section-title"));
            //var neniTermin = driver.FindElement(By.TagName("h2"));
            //Assert.AreEqual("Nejsou dostupné žádné volné termíny.", neniTermin.Text);
            //driver.Close();
        }
    }
}