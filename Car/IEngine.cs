using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public interface IEngine
    {
        public void setTransmission(string transmission);
        public void getTRansmission();

    }
}
