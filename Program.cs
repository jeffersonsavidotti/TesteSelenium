using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class TesteSelenium
{
    static void Main(string[] args)
    {
        // Configura o ChromeDriver
        ChromeOptions options = new ChromeOptions();
        options.AddArgument("--start-maximized");
        IWebDriver driver = new ChromeDriver(options);

        // Define a URL da página de teste
        string url = "https://www.calculadoraonline.com.br/calculadora-virtual-gratis";

        // Acessa a página de teste
        driver.Navigate().GoToUrl(url);

        // Localiza os elementos da página
        IWebElement botao2 = driver.FindElement(By.Id("b18"));
        IWebElement botaoMais = driver.FindElement(By.Id("b4"));
        IWebElement botao3 = driver.FindElement(By.Id("b19"));
        IWebElement botaoIgual = driver.FindElement(By.Id("b27"));
        IWebElement campoResultado = driver.FindElement(By.Id("TIExp"));

        // Realiza as interações do usuário
        botao2.Click();
        Thread.Sleep(3000);
        botaoMais.Click();
        Thread.Sleep(3000);
        botao3.Click();
        Thread.Sleep(3000);
        botaoIgual.Click();
        Thread.Sleep(3000);

        // Verifica o resultado
        string resultadoEsperado = "5";
        string resultadoObtido = campoResultado.GetAttribute("value");
        if (resultadoObtido == resultadoEsperado)
        {
            Console.WriteLine("Teste passou!");
        }
        else
        {
            Console.WriteLine("Teste falhou!");
        }

        // Fecha o navegador
        driver.Quit();
    }
}
