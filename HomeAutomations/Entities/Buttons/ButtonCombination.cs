using System.Collections.Generic;
using System.Linq;

namespace HomeAutomations.Entities.Buttons;

public enum ButtonCombination
{
	Reset
}

public static class ButtonCombinationDecoder
{
	private static readonly IReadOnlyDictionary<ButtonCombination, Func<IList<bool?>, bool>> _decoders = new Dictionary<ButtonCombination, Func<IList<bool?>, bool>>
	{
		{
			ButtonCombination.Reset, x => x is [false, true] or [true, false]
		}
	};

	public static bool? IsButtonCombination(IEnumerable<bool?> states, ButtonCombination combination)
	{
		if (!_decoders.TryGetValue(combination, out var decoder))
		{
			return null;
		}

		return decoder(states.ToList());
	}
}
