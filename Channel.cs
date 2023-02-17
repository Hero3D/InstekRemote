using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instek4303s.Data.Models
{
    public abstract class Channel
    {

        public abstract float Voltage { get; set; }
        public abstract float Current { get; set; }

        public virtual float OutputVoltage 
        {
            get
            {
                // Read From Device
                return new Random().Next(0, 32);
            }
        }
        public virtual float OutputCurrent
        {
            get
            {
                // Read From Device
                return new Random().Next(0, 5);
            }
        }

    }
}
