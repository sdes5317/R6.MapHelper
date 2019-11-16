using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PuppeteerSharp;

namespace VoiceMananger
{
    public class ChromeMananger
    {
        private Page _page;

        private bool _setLanguage = false;

        public ChromeMananger()
        {
            InitChrome();
        }

        public void InitChrome()
        {
            new BrowserFetcher().DownloadAsync(BrowserFetcher.DefaultRevision).Wait();
            var browser = Puppeteer.LaunchAsync(new LaunchOptions
            {
                Args = new[] { "--start-maximized" },
                //Args = new[] { "--start-maximized","--start-fullscreen" },
                Headless = false,
                DefaultViewport = null,
            }).Result;
            _page = browser.PagesAsync().Result.First();
        }

        public void GoToPage(string url)
        {
            _page.GoToAsync(url).Wait();

            if (_setLanguage is false)
            {
                _page.WaitForSelectorAsync(".menu-text").Wait();
                _page.ClickAsync(".menu-text").Wait();
                Thread.Sleep(1000);
                _page.WaitForSelectorAsync("button[data-lang=zh_cn]").Wait();
                _page.ClickAsync("button[data-lang=zh_cn]").Wait();
                _page.ClickAsync(".menu-text").Wait();
                _setLanguage = true;
            }
            else
            {
                _page.ReloadAsync().Wait();
            }

            
        }
    }
}
