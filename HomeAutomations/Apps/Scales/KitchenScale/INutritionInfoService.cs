using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeAutomations.Apps.Scales.KitchenScale;

public interface INutritionInfoService
{
	Task<IEnumerable<NutritionInfo>> GetNutritionInfoAsync(string searchTerm);
}
