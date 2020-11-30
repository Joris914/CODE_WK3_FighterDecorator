using CODE_WK3_FighterDecorator.Model;
using System;

namespace CODE_WK3_FighterDecorator.Decorators
{
	class MinionFighterDecorator : BaseFighterDecorator
	{
		public int MinionLives { get; set; }
		public int MinionAttackValue { get; set; }

		public MinionFighterDecorator(IFighter wrappee) : base(wrappee)
		{
			MinionLives = Lives / 2;
			MinionAttackValue = AttackValue / 2;
		}

		public override Attack Attack()
		{
			var attack = base.Attack();
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
			base.Defend(attack);
		}
	}
}
