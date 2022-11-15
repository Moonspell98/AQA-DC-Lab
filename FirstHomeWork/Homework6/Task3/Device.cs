using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6.Task3
{
    public abstract class Device
    {
        public string? modelName;
        public decimal price;

        public virtual string Description
        {
            get
            {
                return $"Price: {price}, model: {modelName}";
            }
        }

        public abstract void TurnOn();

        public abstract void TurnOff();
    }
}
