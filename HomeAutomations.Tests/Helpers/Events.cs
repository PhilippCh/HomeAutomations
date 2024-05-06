using HomeAutomations.Models.Generated;

namespace HomeAutomations.Tests.Helpers;

public static class Events
{
	public static class Cover
	{
		public static object Open(CoverEntity entity) =>
			new
			{
				Domain = "cover",
				Service = "open_cover",
				Target = new
				{
					EntityIds = new[] { entity.EntityId }
				},
			};

		public static object Close(CoverEntity entity) =>
			new
			{
				Domain = "cover",
				Service = "close_cover",
				Target = new
				{
					EntityIds = new[] { entity.EntityId }
				},
			};
	}
}
