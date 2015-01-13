
using NUnit.Framework;
using System;

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

        [TestCase(18)]
        [TestCase(17)]
        [TestCase(21)]
        public void AlarmIsOffWhenPressureIsBetween17And21Inclusive(int pressure)
        {
            var alarm = new Alarm(new TestSensor(pressure));
            alarm.Check();

            Assert.IsFalse(alarm.AlarmOn);
        }

        [Test]
        public void CheckGetsTheNextPressureReadingFromTheSensor()
        {
            TestSensor testSensor = new TestSensor(0);
            var alarm = new Alarm(testSensor);
            alarm.Check();

            Assert.AreEqual(1, testSensor.PopNextPressureCalled);
        }
    }

    public class TestSensor : ISensor  
    {
        private double pressure;

        public int PopNextPressureCalled { get; private set; }

        public TestSensor(double pressure)
        {
            this.pressure = pressure;
        }

        public double PopNextPressurePsiValue()
        {
            PopNextPressureCalled++;
            return this.pressure; 
        }
    }
}