using System.IO;
using System.Web;

namespace TDDMicroExercises.UnicodeFileToHtmTextConverter
{
    public class UnicodeFileToHtmTextConverter
    {
        private string _fullFilenameWithPath;


        public UnicodeFileToHtmTextConverter(string fullFilenameWithPath)
        {
            _fullFilenameWithPath = fullFilenameWithPath;
        }

        public string ConvertToHtml()
        {
            var fileOpener = new FileOpener();
            var htmlEncoder = new HtmlEncoder();

            using (TextReader unicodeFileStream = fileOpener.OpenText(_fullFilenameWithPath))
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