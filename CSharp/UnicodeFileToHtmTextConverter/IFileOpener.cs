using System.IO;
using System.Web;

namespace TDDMicroExercises.UnicodeFileToHtmTextConverter
{
    public interface IFileOpener
    {
        StreamReader OpenText(string fileName);
    }
}
