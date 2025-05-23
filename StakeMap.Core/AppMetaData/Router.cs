namespace StakeMap.Core.AppMetaData
{
    public static class Router
    {
        public const string root = "Api";
        public const string version = "V1";
        public const string Rule = root + "/" + version + "/";


        public static class AppUserRouting
        {
            public const string perfix = Rule + "User";
            public const string Create = perfix + "/Register";

        }
        public static class Authentication
        {
            public const string perfix = Rule + "Authentication";
            public const string LogIn = perfix + "/LogIn";

        }
        public static class Contact
        {
            public const string CreateContact = Rule + "Contact";

        }
        public static class Metrics
        {
            public const string perfix = Rule + "Metrics";
            public const string DashBoard = perfix + "/DashBoard";
        }
        public static class Report
        {
            public const string GetList = Rule + "Report";

        }

    }

}
