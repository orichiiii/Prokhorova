using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTests
{
    public static class Constant
    {
        public static readonly string password = "Aa@12345678";
        public static readonly string name = "Marina";
        public static readonly string lastName = "Tropinkina";
        public static readonly string domain = "https://newbookmodels.com/";
        public static readonly string loginLink = $"{domain}join";
        public static readonly string companyLink = $"{domain}join/company";
        public static readonly string signInLink = $"{domain}auth/signin";
        public static readonly string updateLink = $"{domain}account-settings/account-info/edit";
    }
}
