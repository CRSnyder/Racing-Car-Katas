
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

        [TestCase(22)]
        [TestCase(24)]
        [TestCase(28)]
        [TestCase(15)]
        [TestCase(12)]
        [TestCase(11)]
        public void AlarmIsOnWhenPressureIsOver21OrUnder17(double pressure)
        {
            var alarm = new Alarm(new TestSensor(pressure));
            alarm.Check();

            Assert.IsTrue(alarm.AlarmOn);
        }
    }

    public class TestSensor : ISensor  
    {
        private double pressure;

        public TestSensor(double pressure)
        {
            this.pressure = pressure;
        }

        public double PopNextPressurePsiValue()
        {
            return this.pressure; 
        }
    }
}