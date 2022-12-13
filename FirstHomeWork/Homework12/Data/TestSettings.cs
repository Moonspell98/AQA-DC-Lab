using Homework12.Data.Enums;
using Microsoft.Extensions.Configuration;

namespace Homework12
{
    public static class TestSettings
    {
        public static Browsers Browser { get; set; }
        public static string CheckBoxPageUrl { get; set; }
        public static string RadioButtonPageUrl { get; set; }
        public static string WebTablePageUrl { get; set; }
        public static string ButtonsPageUrl { get; set; }
        public static string LinksPageUrl { get; set; }
        public static string BrokenLinkAndImagesPageUrl { get; set; }
        public static string DynamicPropertiesPageUrl { get; set; }


        public static IConfiguration TestConfiguration { get; } = new ConfigurationBuilder().AddJsonFile("testsettings.json").Build();

        static TestSettings()
        {
            Enum.TryParse(TestConfiguration["Common:Browser"], out Browsers browser);
            Browser = browser;
            CheckBoxPageUrl = TestConfiguration["Common:DemoQAUrls:CheckBoxPage"];
            RadioButtonPageUrl = TestConfiguration["Common:DemoQAUrls:RadioButtonPage"];
            WebTablePageUrl = TestConfiguration["Common:DemoQAUrls:WebTablePage"];
            ButtonsPageUrl = TestConfiguration["Common:DemoQAUrls:ButtonsPage"];
            LinksPageUrl = TestConfiguration["Common:DemoQAUrls:LinksPage"];
            BrokenLinkAndImagesPageUrl = TestConfiguration["Common:DemoQAUrls:BrokenLinks&ImagesPage"];
            DynamicPropertiesPageUrl = TestConfiguration["Common:DemoQAUrls:DynamicPropertiesPage"];
        }
    }
}
