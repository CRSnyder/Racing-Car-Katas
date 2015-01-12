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

            using (TextReader unicodeFileStream = fileOpener.OpenText(this.fullFilenameWithPath))
            {
                string html = string.Empty;

                string line = unicodeFileStream.ReadLine();
                while (line != null)
                {
                    html += htmlEncoder.HtmlEncode(line);
                    html += "<br />";
                    line = unicodeFileStream.ReadLine();
                }

                return html;
            }
        }
    }
}