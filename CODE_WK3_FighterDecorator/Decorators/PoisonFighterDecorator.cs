﻿using CODE_WK3_FighterDecorator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODE_WK3_FighterDecorator.Decorators
{
	class PoisonFighterDecorator : BaseFighterDecorator
	{
		public int PoisonStrength { get; set; }

		public PoisonFighterDecorator(IFighter wrappee) : base(wrappee)
		{
			_wrappee = wrappee;
			PoisonStrength = 10;
		}

		public override Attack Attack()
		{
			var attack = _wrappee.Attack();
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
