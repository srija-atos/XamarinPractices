
using Student_Management_1.DependencyInterfaces;
using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace Student_Management_1.Localisation
{
    [ContentProperty("Key")]
    public class TranslateExtension : IMarkupExtension
    {
        private static CultureInfo ci = null;
        const string ResourceId = "Student_Management_1.Localisation.LocalisedFiles.AppResource";
        const string NotFoundText = "Undefined";
        static readonly Lazy<ResourceManager> ResMgr = new Lazy<ResourceManager>(
        () => new ResourceManager(ResourceId, IntrospectionExtensions.GetTypeInfo(typeof(TranslateExtension)).Assembly)); public TranslateExtension()
        {
            if (Device.RuntimePlatform == Device.iOS || Device.RuntimePlatform == Device.Android)
                ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
        }
        public string Key { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (ci == null)
            {
                if (Device.RuntimePlatform == Device.iOS || Device.RuntimePlatform == Device.Android)
                    ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            }
            string result = string.Empty;
            try
            {
                if (Key == null)
                    result = string.Empty; if (ResMgr == null)
                    result = NotFoundText; result = ResMgr.Value.GetString(Key, ci); if (string.IsNullOrEmpty(result))
                    result = NotFoundText;
            }
            catch (Exception ex)
            { }
            return result;
        }
        public static string ProvideValue(string key)
        {
            string result = string.Empty; if (ci == null)
            {
                if (Device.RuntimePlatform == Device.iOS || Device.RuntimePlatform == Device.Android)
                    ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            }
            if (ci == null)
                return result; try
            {
                if (key == null)
                    result = string.Empty; if (ResMgr == null)
                    result = NotFoundText; result = ResMgr.Value.GetString(key, ci); if (string.IsNullOrEmpty(result))
                    result = NotFoundText;
            }
            catch (Exception ex)
            { }
            return result;
        }
    }
}

