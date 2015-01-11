
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
        public void AlarmIsOnWhenPressureIs22()
        {
            var alarm = new Alarm(new TestSensor());
            alarm.Check();

            Assert.IsTrue(alarm.AlarmOn);
        }
    }

    public class TestSensor : ISensor  
    {

        public double PopNextPressurePsiValue()
        {
            return 22; ;
        }
    }
}