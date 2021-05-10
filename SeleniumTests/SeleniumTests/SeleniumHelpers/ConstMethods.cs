using OpenQA.Selenium;

namespace SeleniumTests
{
    public class ConstMethods
    {
        private IWebDriver _webDriver;

        public ConstMethods(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public void FindPhotoElement()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)_webDriver;

            const string JS_DROP_FILE = "for(var b=arguments[0],k=arguments[1],l=arguments[2],c=b.ownerDocument,m=0;;){var e=b.getBoundingClientRect(),g=e.left+(k||e.width/2),h=e.top+(l||e.height/2),f=c.elementFromPoint(g,h);if(f&&b.contains(f))break;if(1<++m)throw b=Error('Element not interractable'),b.code=15,b;b.scrollIntoView({behavior:'instant',block:'center',inline:'center'})}var a=c.createElement('INPUT');a.setAttribute('type','file');a.setAttribute('style','position:fixed;z-index:2147483647;left:0;top:0;');a.onchange=function(){var b={effectAllowed:'all',dropEffect:'none',types:['Files'],files:this.files,setData:function(){},getData:function(){},clearData:function(){},setDragImage:function(){}};window.DataTransferItemList&&(b.items=Object.setPrototypeOf([Object.setPrototypeOf({kind:'file',type:this.files[0].type,file:this.files[0],getAsFile:function(){return this.file},getAsString:function(b){var a=new FileReader;a.onload=function(a){b(a.target.result)};a.readAsText(this.file)}},DataTransferItem.prototype)],DataTransferItemList.prototype));Object.setPrototypeOf(b,DataTransfer.prototype);['dragenter','dragover','drop'].forEach(function(a){var d=c.createEvent('DragEvent');d.initMouseEvent(a,!0,!0,c.defaultView,0,0,0,g,h,!1,!1,!1,!1,0,null);Object.setPrototypeOf(d,null);d.dataTransfer=b;Object.setPrototypeOf(d,DragEvent.prototype);f.dispatchEvent(d)});a.parentElement.removeChild(a)};c.documentElement.appendChild(a);a.getBoundingClientRect();return a;"; ;

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

        public void RegistrationProcess(string phone, string email, string password, string name, string lastName)
        {
            var registration = new RegistrationPage(_webDriver);

            registration.GoToRegistrationPage()
                .SetFirstName(name)
                .SetLastName(lastName)
                .SetEmail(email)
                .SetPassword(password)
                .SetPasswordConfirm(password)
                .SetPhoneNumber(phone)
                .ClickNextButton();
        }
    }
}
