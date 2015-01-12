using System.IO;
using System.Web;

namespace TDDMicroExercises.UnicodeFileToHtmTextConverter
{
    public class UnicodeFileToHtmTextConverter
    {
        private string fullFilenameWithPath;
        private IHtmlEncoder htmlEncoder;
        private IFileOpener fileOpener;
        public UnicodeFileToHtmTextConverter(string fullFilenameWithPath)
            : this(fullFilenameWithPath, new FileOpener(), new HtmlEncoder())
        {
        }

        public UnicodeFileToHtmTextConverter(string fullFilenameWithPath, IFileOpener fileOpener, IHtmlEncoder htmlEncoder)
        {
            this.fullFilenameWithPath = fullFilenameWithPath;
            this.htmlEncoder = htmlEncoder;
            this.fileOpener = fileOpener;
        }

        public string ConvertToHtml()
        {
            using (var unicodeFileStream = fileOpener.OpenText(this.fullFilenameWithPath))
            {
                return GetHtml(unicodeFileStream);
            }
        }
        private string GetHtml(TextReader unicodeFileStream)
        {
            const string HTMLBR = "<br />";
            string html = string.Empty;

            string line = unicodeFileStream.ReadLine();
            while (line != null)
            {
                html += htmlEncoder.HtmlEncode(line);
                html += HTMLBR;
                line = unicodeFileStream.ReadLine();
            }
            return html;
        }
    }
}