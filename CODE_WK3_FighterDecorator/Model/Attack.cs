using System.Collections.Generic;

namespace CODE_WK3_FighterDecorator.Model
{
	public class Attack
	{
		public IList<string> Messages { get; private set; }
		public int Value { get; set; }

		public Attack(string message, int value)
		{
			Messages = new List<string>();
			Messages.Add(message);

			Value = value;
		}
	}
}
