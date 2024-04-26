using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity
{
    public interface IPosition
    {
        public abstract void setPosition(string position);
        public abstract void getPosition();
    }
}
