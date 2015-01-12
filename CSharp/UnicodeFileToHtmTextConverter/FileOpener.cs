using System.IO;
using System.Web;

namespace TDDMicroExercises.UnicodeFileToHtmTextConverter
{
    public class FileOpener
    {
        public StreamReader OpenText(string fileName)
        {
            return File.OpenText(fileName);
        }
    }
}
