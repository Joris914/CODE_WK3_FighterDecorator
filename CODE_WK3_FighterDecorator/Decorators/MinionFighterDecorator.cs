using CODE_WK3_FighterDecorator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODE_WK3_FighterDecorator.Decorators
{
	class MinionFighterDecorator : BaseFighterDecorator
	{
		public int MinionLives { get; set; }
		public int MinionAttackValue { get; set; }

		public MinionFighterDecorator(IFighter wrappee) : base(wrappee)
		{
			_wrappee = wrappee;
			MinionLives = _wrappee.Lives / 2;
			MinionAttackValue = _wrappee.AttackValue / 2;
		}

		public override Attack Attack()
		{
			var attack = _wrappee.Attack();
			if (MinionLives > 0)
			{
				attack.Messages.Add("Minion helping the attack: " + MinionAttackValue);
				attack.Value += MinionAttackValue;
			}
			return attack;
		}

		public override void Defend(Attack attack)
		{
			if (MinionLives > 0)
			{
				int tmpLives = MinionLives;
				attack.Messages.Add("Minion defended from the attack: -" + Math.Min(Math.Max(0, attack.Value), MinionLives));
				MinionLives -= Math.Min(Math.Max(0, attack.Value), MinionLives);
				if (MinionLives == 0)
				{
					attack.Messages.Add("Minion died.");
				}
				attack.Value -= Math.Max(0, tmpLives - MinionLives);
			}
			_wrappee.Defend(attack);
		}
	}
}
