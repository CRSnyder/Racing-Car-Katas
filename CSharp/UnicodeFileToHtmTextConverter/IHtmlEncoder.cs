using System.IO;
using System.Web;

namespace TDDMicroExercises.UnicodeFileToHtmTextConverter
{
    public interface IHtmlEncoder
    {
        string HtmlEncode(string text);
    }
}
