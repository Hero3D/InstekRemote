namespace Instek4303s.Data.Models
{
    public class ChannelSettings<T>
    {
        private T _maxVoltage;
        private T _maxCurrent;

        public ChannelSettings(T maxVoltage, T maxCurrent)
        {
            _maxVoltage = maxVoltage;
            _maxCurrent = maxCurrent;
        }

        public T MaxVoltage
        {
            get { return _maxVoltage; }
        }
        public T MaxCurrent
        {
            get { return _maxCurrent; }
        }
    }
}
