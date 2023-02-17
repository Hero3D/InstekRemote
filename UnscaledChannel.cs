using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instek4303s.Data.Models
{
    internal class UnscaledChannel : Channel
    {
       
        private ChannelSettings<float> _settings;
        public UnscaledChannel(ChannelSettings<float> settings)
        {
            _settings = settings;
        }

        private float _voltage;
        private float _current;

        public override float Voltage
        {
            get
            {
                //_voltage = new Random().Next(0, (int)_settings.MaxVoltage);
                return _voltage;
            }
            set
            {
                value = Math.Clamp(value, 0, (int)_settings.MaxVoltage);
                _voltage = value;
            }
        }
        public override float Current
        {
            get
            {
                _current = new Random().Next(0, (int)_settings.MaxVoltage);
                return _current;
            }
            set
            {
                _current = Math.Clamp(value, 0, _settings.MaxCurrent);
            }
        }
    }
}
