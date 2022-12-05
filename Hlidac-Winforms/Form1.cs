using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System.Net.Mail;
using SeleniumExtras.WaitHelpers;
using System.Text;

namespace Hlidac_Winforms {
    public partial class Form1 : Form {
        WebDriver driver;
        IWebElement neniTermin;
        string adresa;
        private string casSpusteni;
        private int pocet;
        String ZkontrolovanoOd;
        double interval;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            casSpusteni = DateTime.Now.ToString();
        }
        //30 minut: 1800000 milisekund
        //20 minut: 1200000 milisekund
        //10 minut: 600000 milisekund

        private void casovac_Tick(object sender, EventArgs e) {
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            driver = new ChromeDriver();
            driver.Manage().Window.Minimize();
            driver.Navigate().GoToUrl("https://profidentist.xdent.cz/clinicSelection");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Pokraèovat']"))).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Pokraèovat']"))).Click();
            wait.Until(ExpectedConditions.UrlToBe("https://profidentist.xdent.cz/staffSelection"));
            try {
                neniTermin = driver.FindElement(By.TagName("h2"));
            }
            catch {
                MailMessage mail = new MailMessage("hlidacizub@vsb.cz", adresa, "Hlídací zub hlásí volný termín!", "viz 'https://profidentist.xdent.cz/clinicSelection'");
                SmtpClient klient = new SmtpClient("smtp.vsb.cz");
                klient.Send(mail);
                casovac.Stop();
            }
            finally {
                driver.Quit();
            }
            ZkontrolovanoOd = $"Zkontrolováno {pocet}x od {casSpusteni}";
            pocet++;
        }

        private void btnHlidej_Click(object sender, EventArgs e) {
            casovac.Interval = Convert.ToInt32(nudMinuty.Value) * 60 * 1000;
            casovac.Start();
            if (tbAdresa.Text != string.Empty) {
                adresa = tbAdresa.Text;
                notifyIcon.ShowBalloonTip(500);
                notifyIcon.Visible = true;
                this.Hide();
            }
            else {
                MessageBox.Show("Zadejte e-mailovou adresu");
            }
        }

        private void Form1_Resize(object sender, EventArgs e) {
            if (this.WindowState == FormWindowState.Minimized) {
                notifyIcon.ShowBalloonTip(500);
                notifyIcon.Visible = true;
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState) {
                notifyIcon.Visible = false;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e) {
            this.Show(); //hodi okno na listu
            WindowState = FormWindowState.Normal; //otevre zase normalni okno 
            lbCheckCount.Text = ZkontrolovanoOd;
        }
    }
}