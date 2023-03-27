using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parrot
{
	public class NorwegianBlueParrot : Parrot
	{
		private readonly bool _isNailed;
		private readonly double _voltage;
		public NorwegianBlueParrot(double voltage, bool isNailed)
		{
			_voltage = voltage;
			_isNailed = isNailed;
		}
		public override double GetSpeed()
		{
			return _isNailed ? 0 : GetBaseSpeed(_voltage);
		}

		public override string GetCry()
		{
			return _voltage > 0 ? "Bzzzzzz" : "...";
		}
	}
}
