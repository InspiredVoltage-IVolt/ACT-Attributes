using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ACT.Core.Attributes.JSON
{
	public static class DefaultConverter
	{
		public static readonly JsonSerializerSettings Settings = new()
		{
			MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
			DateParseHandling = DateParseHandling.None,
			Converters =
			{
				new IsoDateTimeConverter {DateTimeStyles = DateTimeStyles.AssumeUniversal}
			}
		};
	}
}
