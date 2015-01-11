namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    public class Alarm
    {
        private const double LowPressureTreshold = 17;
        private const double HighPressureTreshold = 21;

        Sensor _sensor = new Sensor();

        bool _alarmOn = false;
        private long _alarmCount = 0;


        public Alarm()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Alarm"/> class.
        /// </summary>
        /// <param name="sensor"></param>
        public Alarm(Sensor sensor)
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
            _alarmOn = true;

            return 0;
        }

        public bool AlarmOn
        {
            get { return _alarmOn; }
        }

    }
}
