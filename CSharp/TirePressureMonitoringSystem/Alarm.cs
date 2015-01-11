namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    public class Alarm
    {
        private const double LowPressureTreshold = 17;
        private const double HighPressureTreshold = 21;

        ISensor _sensor = new Sensor();

        bool _alarmOn = false;
        private long _alarmCount = 0;

        public Alarm()
        {
        }

        public Alarm(ISensor sensor)
        {
            _sensor = sensor;
        }

        public double Check()
        {
            double psiPressureValue = _sensor.PopNextPressurePsiValue();

            if (psiPressureValue < LowPressureTreshold || HighPressureTreshold < psiPressureValue)
            {
                _alarmOn = true;
                _alarmCount += 1;
            }

            return 0;
        }

        public bool AlarmOn
        {
            get { return _alarmOn; }
        }

    }
}
