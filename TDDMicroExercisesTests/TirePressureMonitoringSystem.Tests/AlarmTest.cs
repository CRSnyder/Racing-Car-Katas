
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
        public void AlarmAcceptsASensor()
        {
            var alarm = new Alarm(new Sensor());
        }

        [Test]
        public void AlarmIsOffWhenPressureIs18()
        {
            var alarm = new Alarm(new TestSensor());
            alarm.Check();

            Assert.IsFalse(alarm.AlarmOn);
        }
    }

    public class TestSensor : ISensor  
    {

        public double PopNextPressurePsiValue()
        {
            return 18;
        }
    }
}