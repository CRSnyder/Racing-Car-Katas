using System.IO;
using System.Web;

namespace TDDMicroExercises.UnicodeFileToHtmTextConverter
{
    public class HtmlEncoder : IHtmlEncoder
    {
        public string HtmlEncode(string text)
        {
            return HttpUtility.HtmlEncode(text);
        }
    }
}
