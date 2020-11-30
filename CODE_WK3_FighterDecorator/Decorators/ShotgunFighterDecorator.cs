using CODE_WK3_FighterDecorator.Model;

namespace CODE_WK3_FighterDecorator.Decorators
{
	class ShotgunFighterDecorator : BaseFighterDecorator
	{
		public int ShotgunRoundsFired { get; set; }

		public ShotgunFighterDecorator(IFighter wrappee) : base(wrappee)
		{
		}

		public override Attack Attack()
		{
			var attack = base.Attack();
			if (ShotgunRoundsFired < 2)
			{
				attack.Messages.Add("Shotgun: 20");
				attack.Value += 20;
				ShotgunRoundsFired++;
			}
			else
			{
				attack.Messages.Add("Shotgun reloading, no extra damage.");
				ShotgunRoundsFired = 0;
			}
			return attack;
		}
	}
}
