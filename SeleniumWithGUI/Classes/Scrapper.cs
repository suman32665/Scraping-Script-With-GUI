using OfficeOpenXml;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithGUI.Classes
{
    class Scrapper
    {
        string TeamName = "//*[@class='p0c-competition-tables__team--short-name']";
        string TeamNameValue;
        public IWebDriver Webdriver;
		public void Run(InputItems input)
		{
			ExcelPackage package = new ExcelPackage();
			ExcelWorksheet worksheet = CreateSheet(package, "Football Sheet");
			OpenBrowser(input.AppUrl, input.isHeadless);
			Scrap(worksheet);
			WriteExcelFile(package, input.OutputPath);
		}

		public void OpenBrowser(string url, bool runHeadlessMode)
		{
			ChromeOptions chromeBrowserOptions = new ChromeOptions();
			chromeBrowserOptions.AddArgument("--start-maximized");
			chromeBrowserOptions.AddArgument("--test-type");
			chromeBrowserOptions.AddArgument("--silent");
			chromeBrowserOptions.AddArgument("--disable-plugins");
			chromeBrowserOptions.AddArgument("--disable-infobars");
			chromeBrowserOptions.AddArgument("--incognito");
			if (runHeadlessMode)
			{
				chromeBrowserOptions.AddArgument("--headless");
			}
			Webdriver = new ChromeDriver(".", chromeBrowserOptions);
			Webdriver.Navigate().GoToUrl(url);
		}

		public void Scrap(ExcelWorksheet ws)
		{
			string Tr = "(//*[@class='p0c-competition-tables__table'])[1]/tbody/tr";

			for (int i = 1; i <= 5; i++)
			{
				TeamNameValue = Webdriver.FindElement(By.XPath(Tr + '[' + i + ']' + TeamName)).Text;
				ws.Cells[i, 1].Value = TeamNameValue;
			}
			Webdriver.Quit();
		}

		private static ExcelWorksheet CreateSheet(ExcelPackage p, string sheetName)
		{
			ExcelWorksheet ws = p.Workbook.Worksheets.Add(sheetName);
			ws.Name = sheetName; //Setting Sheet's name
			ws.Cells.Style.Font.Size = 11; //Default font size for whole sheet
			ws.Cells.Style.Font.Name = "Calibri"; //Default Font name for whole sheet

			return ws;
		}

		public void WriteExcelFile(ExcelPackage package, string OutputPath)
		{
			string timeStamp = DateTime.Now.ToString("yyyyMMdd");
			string path =OutputPath  + "output" + timeStamp + ".xlsx";
			if (File.Exists(path))
			{
				File.Delete(path);
			}

			FileStream fileStream = File.Create(path);
			fileStream.Close();
			File.WriteAllBytes(path, package.GetAsByteArray());
			package.Dispose();
		}
	}
}
