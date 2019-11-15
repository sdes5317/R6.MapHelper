using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuppeteerSharp;

namespace VoiceMananger
{
    public class ChromeMananger
    {
        private Page _page;

        public ChromeMananger()
        {
            InitChrome();
        }

        public void InitChrome()
        {
            new BrowserFetcher().DownloadAsync(BrowserFetcher.DefaultRevision).Wait();
            var browser = Puppeteer.LaunchAsync(new LaunchOptions
            {
                Headless = false
            }).Result;
            _page = browser.PagesAsync().Result.First();
        }

        public void GoToPage(string url)
        {
            _page.GoToAsync(url).Wait();
        }
    }
}
