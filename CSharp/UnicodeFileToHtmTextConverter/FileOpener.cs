using System.IO;
using System.Web;

namespace TDDMicroExercises.UnicodeFileToHtmTextConverter
{
    public class FileOpener : IFileOpener
    {
        public StreamReader OpenText(string fileName)
        {
            return File.OpenText(fileName);
        }
    }
}
