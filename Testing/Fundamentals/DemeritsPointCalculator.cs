using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Fundamentals
{
    public class DemeritsPointCalculator
    {
        private const int speedLimit = 65;
        private const int maxSpeed = 300;

        public int CalculateDemeritsPoint(int speed)
        {
            if (speed < 0 || speed > maxSpeed)
                throw new ArgumentOutOfRangeException();
            if (speed <= speedLimit)
                return 0;
            const int kmPerDemeritsPoint = 5;
            var demeritsPoint = (speed - speedLimit) / kmPerDemeritsPoint;

            return demeritsPoint;
        }
    }
}
