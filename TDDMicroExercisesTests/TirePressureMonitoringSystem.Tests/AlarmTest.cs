
using NUnit.Framework;

namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    [TestFixture]
    public class AlarmTest
    {
        [Test]
        public void NewAlarmHasAlarmOff()
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
        
        [Test]
        public void CheckTurnsAlarmOn()
        {
            var alarm = new Alarm();
            alarm.Check();
            Assert.IsTrue(alarm.AlarmOn);
        }
    }
}