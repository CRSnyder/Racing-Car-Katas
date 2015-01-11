
using NUnit.Framework;

namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    [TestFixture]
    public class AlarmTest
    {
        [Test]
        public void Foo()
        {
            Alarm alarm = new Alarm();
            Assert.AreEqual(false, alarm.AlarmOn);
        }

        [Test]
        public void CheckDoesNotRaiseAnException()
        {
            var alarm = new Alarm();
            alarm.Check();


        }
    }
}