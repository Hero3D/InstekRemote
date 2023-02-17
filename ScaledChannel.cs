using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Instek4303s.Data.Models
{
    internal class ScaledChannel : Channel
    {
        private ChannelSettings<Vector2> _settings;

        private float _voltage;
        private float _current;
        
        public ScaledChannel(ChannelSettings<Vector2> settings)
        {
            _settings = settings;
        }

        public override float Voltage
        {
            get
            {
                _voltage = new Random().Next(1, (int)_settings.MaxVoltage.Y);
                return _voltage;
            }
            set
            {
                // Clamp current to scale 2 if Voltage is above threshold
                if (value > _settings.MaxVoltage.X)
                {
                    Current = Math.Clamp(Current, 0, _settings.MaxCurrent.Y);
                }
                // Set value to device
                _voltage = Math.Clamp(value, 0, _settings.MaxVoltage.Y);
            }
        }
        public override float Current
        {
            get
            {
                _current = new Random().Next(0, (int)_settings.MaxCurrent.Y);
                return _current;
            }
            set
            {
                // Clamp Voltage to scale 1 if current is above threshold
                if (value > _settings.MaxCurrent.Y)
                {
                    Voltage = Math.Clamp(Voltage, 0, _settings.MaxVoltage.X);
                }

                // Set value to device
                _current = Math.Clamp(value, 0, _settings.MaxCurrent.X);
            }
        }
    }
}
