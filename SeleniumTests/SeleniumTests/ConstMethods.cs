using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTests
{
    public class ConstMethods
    {
        private readonly IWebDriver _webDriver;

        public ConstMethods(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public void FindPhotoElement()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)_webDriver;

            const string JS_DROP_FILE = "for (var b = arguments[0], k = arguments[1], l = arguments[2], c = b.ownerDocument, m = 0; ;) { var e = b.getBoundingClientRect(), g = e.left + (ke.width2), h = e.top + (le.height2), f = c.elementFromPoint(g, h); if (f && b.contains(f)) break; if (1++m)throw b = Error('Element not interractable'),b.code = 15,b; b.scrollIntoView({ behavior'instant',block'center',inline'center'})} var a = c.createElement('INPUT'); a.setAttribute('type', 'file'); a.setAttribute('style', 'positionfixed;z-index2147483647;left0;top0;'); a.onchange = function() { var b = { effectAllowed'all', dropEffect'none', types['Files'], filesthis.files, setDatafunction(){ }, getDatafunction(){ }, clearDatafunction(){ }, setDragImagefunction(){ } }; window.DataTransferItemList && (b.items = Object.setPrototypeOf([Object.setPrototypeOf({ kind'file',typethis.files[0].type,filethis.files[0],getAsFilefunction(){ return this.file},getAsStringfunction(b){ var a = new FileReader; a.onload = function(a){ b(a.target.result)}; a.readAsText(this.file)} },DataTransferItem.prototype)],DataTransferItemList.prototype)); Object.setPrototypeOf(b, DataTransfer.prototype);['dragenter','dragover','drop'].forEach(function(a){ var d = c.createEvent('DragEvent'); d.initMouseEvent(a, !0, !0, c.defaultView, 0, 0, 0, g, h, !1, !1, !1, !1, 0, null); Object.setPrototypeOf(d, null); d.dataTransfer = b; Object.setPrototypeOf(d, DragEvent.prototype); f.dispatchEvent(d)}); a.parentElement.removeChild(a)}; c.documentElement.appendChild(a); a.getBoundingClientRect(); return a;";

            _webDriver.FindElement(By.CssSelector("[title = edit]")).Click();
            var target = _webDriver.FindElement(By.CssSelector("[class^=profile__info]"));

            IWebElement input = (IWebElement)js.ExecuteScript(JS_DROP_FILE, target, 15, 15);
            input.SendKeys(@"C:\Users\proho\Desktop\image_2021-04-29_14-00-03.png");
        }

        public bool existsElement(By locator)
        {
            try
            {
                _webDriver.FindElement(locator);
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            return true;
        }
    }
}
