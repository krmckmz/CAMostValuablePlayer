using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAMostValuablePlayer
{
    public interface ICalculator
    {
        public abstract int CalculatePoint();
        public abstract Player GetMostValuablePlayer();
    }
}
