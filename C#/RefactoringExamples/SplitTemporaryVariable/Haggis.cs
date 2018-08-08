using System;

namespace RefactoringExamples.SplitTemporaryVariable
{
    public class Haggis
    {
        private readonly double _primaryForce;
        private readonly double _mass;
        private readonly int _delay;
        private readonly double _secondaryForce;

        public Haggis(double primaryForce, double mass, int delay, double secondaryForce)
        {
            _primaryForce = primaryForce;
            _mass = mass;
            _delay = delay;
            _secondaryForce = secondaryForce;
        }

        public double GetDistanceTravelled(int time)
        {
            var primaryAcceleration = _primaryForce / _mass;
            var primaryTime = Math.Min(time, _delay);

            var result = 0.5 * primaryAcceleration * primaryTime * primaryTime;
            var secondaryTime = time - _delay;

            if (secondaryTime <= 0) return result;

            var primaryVelocity = primaryAcceleration * _delay;
            var secondaryAcceleration = (_primaryForce + _secondaryForce) / _mass;

            result += primaryVelocity * secondaryTime + 0.5 * secondaryAcceleration * secondaryTime * secondaryTime;

            return result;
        }
    }
}