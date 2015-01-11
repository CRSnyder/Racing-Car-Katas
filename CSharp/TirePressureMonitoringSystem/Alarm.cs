namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    public class Alarm
    {
        private const double LowPressureTreshold = 17;
        private const double HighPressureTreshold = 21;

        ISensor _sensor;

        bool _alarmOn = false;
        private long _alarmCount = 0;

        public Alarm() : this(new Sensor())
        {
        }

        public Alarm(ISensor sensor)
        {
            _sensor = sensor;
        }

        public void Check()
        {
            double psiPressureValue = _sensor.PopNextPressurePsiValue();

            if (PressureIsOutsideOfSafeRange(psiPressureValue))
            {
                _alarmOn = true;
                _alarmCount += 1;
            }

        }

        private static bool PressureIsOutsideOfSafeRange(double psiPressureValue)
        {
            return psiPressureValue < LowPressureTreshold || HighPressureTreshold < psiPressureValue;
        }
        public bool AlarmOn
        {
            get { return _alarmOn; }
        }

    }
}
