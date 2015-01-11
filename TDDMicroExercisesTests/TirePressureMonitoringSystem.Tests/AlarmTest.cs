
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
        public void CheckReturnsDouble()
        {
            var alarm = new Alarm();
            var result = alarm.Check();

            Assert.IsInstanceOf<double>(result);
        }

        [Test]
        public void AlarmAcceptsASensor()
        {
            var alarm = new Alarm(new Sensor());
        }

        //[Test]
        //public void AlarmIsOffIfPressureIs18()
        //{
        //    var alarm = new Alarm(new Sensor());
        //    alarm.Check();

        //    Assert.IsFalse(alarm.AlarmOn);
        //}
    }
}