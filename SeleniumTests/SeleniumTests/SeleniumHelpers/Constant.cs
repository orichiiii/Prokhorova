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
        public static readonly string registrationLink = $"{domain}join";
        public static readonly string companyLink = $"{domain}company";
        public static readonly string signInLink = $"{domain}join/company?goBackUrl=%2Fexplore";
        public static readonly string updateProfileLink = $"{domain}account-settings/account-info/edit";
    }
}
