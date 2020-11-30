using CODE_WK3_FighterDecorator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODE_WK3_FighterDecorator.Decorators
{
	class DoubleHandedFighterDecorator : BaseFighterDecorator
	{
		public DoubleHandedFighterDecorator(IFighter wrappee) : base(wrappee)
		{
			_wrappee = wrappee;
		}

		public override Attack Attack()
		{
			var attack = _wrappee.Attack();
			attack.Value += AttackValue;
			attack.Messages.Add("Doubled the original attack value: " + AttackValue);
			return attack;
		}

		public override void Defend(Attack attack)
		{
			attack.Messages.Add("One hand defended the attack: -" + DefenseValue);
			attack.Value -= DefenseValue;
			_wrappee.Defend(attack);
		}
	}
}
