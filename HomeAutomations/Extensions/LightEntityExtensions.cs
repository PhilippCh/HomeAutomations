﻿using HomeAutomations.Models.Generated;

namespace HomeAutomations.Extensions;

public static class LightEntityExtensions
{
	public static void SetState(this LightEntity entity, bool state)
	{
		if (state)
		{
			entity.TurnOn();
		}
		else
		{
			entity.TurnOff();
		}
	}
}