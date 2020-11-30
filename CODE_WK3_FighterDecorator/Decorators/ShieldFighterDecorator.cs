using CODE_WK3_FighterDecorator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODE_WK3_FighterDecorator.Decorators
{
	class ShieldFighterDecorator : BaseFighterDecorator
	{
		public int ShieldDefends { get; set; }
		public ShieldFighterDecorator(IFighter wrappee) : base(wrappee)
		{
			_wrappee = wrappee;
			ShieldDefends = 3;
		}

		public override void Defend(Attack attack)
		{
			if (ShieldDefends > 0)
			{
				attack.Messages.Add($"Shield protected, blocked {attack.Value} damage.");
				attack.Value = 0;
				ShieldDefends--;
			}
			_wrappee.Defend(attack);
		}
	}
}
