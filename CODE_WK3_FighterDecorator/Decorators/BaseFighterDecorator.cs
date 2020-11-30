using CODE_WK3_FighterDecorator.Model;

namespace CODE_WK3_FighterDecorator.Decorators
{
	public abstract class BaseFighterDecorator : IFighter
	{
		private IFighter _wrappee;

		public BaseFighterDecorator(IFighter wrappee)
		{
			_wrappee = wrappee;
		}

		public int Lives { get => _wrappee.Lives; set => _wrappee.Lives = value; }
		public int AttackValue { get => _wrappee.AttackValue; set => _wrappee.AttackValue = value; }
		public int DefenseValue { get => _wrappee.DefenseValue; set => _wrappee.DefenseValue = value; }

		public virtual Attack Attack()
		{
			return _wrappee.Attack();
		}

		public virtual void Defend(Attack attack)
		{
			_wrappee.Defend(attack);
		}
	}
}
