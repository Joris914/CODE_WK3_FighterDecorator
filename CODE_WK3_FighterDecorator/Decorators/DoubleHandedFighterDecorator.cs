using CODE_WK3_FighterDecorator.Model;

namespace CODE_WK3_FighterDecorator.Decorators
{
	class DoubleHandedFighterDecorator : BaseFighterDecorator
	{
		public DoubleHandedFighterDecorator(IFighter wrappee) : base(wrappee)
		{
		}

		public override Attack Attack()
		{
			var attack = base.Attack();
			attack.Value += AttackValue;
			attack.Messages.Add("Doubled the original attack value: " + AttackValue);
			return attack;
		}

		public override void Defend(Attack attack)
		{
			attack.Messages.Add("One hand defended the attack: -" + DefenseValue);
			attack.Value -= DefenseValue;
			base.Defend(attack);
		}
	}
}
