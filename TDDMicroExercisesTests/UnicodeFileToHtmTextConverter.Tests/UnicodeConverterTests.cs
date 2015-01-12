using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDMicroExercises.UnicodeFileToHtmTextConverter;

namespace TDDMicroExercisesTests.UnicodeConverter.Tests
{
    class UnicodeConverterTests
    {

        [Test]
        public void UnicodeConverterReadsFile()
        {
            var expected = @"&lt;h2&gt;Experience the music you love.&lt;/h2&gt;<br />&lt;p&gt;Hear your favorite music live. Follow a composer from orchestra to orchestra.&lt;/p&gt;<br /><br /><br />	<br />";
            var filename = Path.Combine(Environment.CurrentDirectory, "SimpleHtml.html");

            // Not part of the *actual* test, just a way to ensure that the file is available.
            Assert.IsTrue(File.Exists(filename));

            var converter = new UnicodeFileToHtmTextConverter(filename);
            var actual = converter.ConvertToHtml();

            StringAssert.AreEqualIgnoringCase(expected, actual);
        }


    }
}
