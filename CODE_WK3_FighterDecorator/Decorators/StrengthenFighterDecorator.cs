using CODE_WK3_FighterDecorator.Model;

namespace CODE_WK3_FighterDecorator.Decorators
{
	internal class StrengthenFighterDecorator : BaseFighterDecorator
	{
		public StrengthenFighterDecorator(IFighter wrappee) : base(wrappee)
		{
			_wrappee = wrappee;
			AttackValue += AttackValue / 10;
			DefenseValue += DefenseValue / 10;
		}
	}
}