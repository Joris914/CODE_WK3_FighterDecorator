using CODE_WK3_FighterDecorator.Model;

namespace CODE_WK3_FighterDecorator.Decorators
{
	class PoisonFighterDecorator : BaseFighterDecorator
	{
		public int PoisonStrength { get; set; }

		public PoisonFighterDecorator(IFighter wrappee) : base(wrappee)
		{
			PoisonStrength = 10;
		}

		public override Attack Attack()
		{
			var attack = base.Attack();
			if (PoisonStrength > 0)
			{
				attack.Messages.Add("Poison weakening, current value: " + PoisonStrength);
				attack.Value += PoisonStrength;
				PoisonStrength -= 2;
			}
			else
			{
				attack.Messages.Add("Poison ran out.");
			}
			return attack;
		}
	}
}
