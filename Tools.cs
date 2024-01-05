namespace SkeletonCounter
{
	public static class Tools
	{
		public static string GetNiceDate(long unixTime)
		{
			string currentDate = "";

			DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(unixTime).ToLocalTime();

			currentDate += GetNiceNumber(dateTime.Day) + ".";
			currentDate += GetNiceNumber(dateTime.Month) + ".";
			currentDate += dateTime.Year.ToString().Remove(0, 2);

			return currentDate;
		}
		public static string GetNiceTime(long unixTime)
		{
			string currentTime = "";

			DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(unixTime).ToLocalTime();

			currentTime += GetNiceNumber(dateTime.Hour) + ":";
			currentTime += GetNiceNumber(dateTime.Minute) + ":";
			currentTime += GetNiceNumber(dateTime.Second);

			return currentTime;
		}

		public static string GetNiceText(int value, string oneText, string smallText, string largeText)
		{
			if (Math.Floor((float)value / 10) % 10 == 1)
			{
				return value + " " + largeText;
			}
			else
			{
				if (value % 10 == 1)
				{
					return value + " " + oneText;
				}
				if (value % 10 == 2 || value % 10 == 3 || value % 10 == 4)
				{
					return value + " " + smallText;
				}

				return value + " " + largeText;
			}
		}
		public static string GetNiceNumber(int number)
		{
			if (number < 10)
			{
				return "0" + number.ToString();
			}
			return number.ToString();
		}
	}

	public class JsonSave
	{
		public long StartTime { get; set; } = 0;
		public string[] Pirates { get; set; } = Array.Empty<string>();
		public JsonSkeleton[] Skeletons { get; set; } = Array.Empty<JsonSkeleton>();
	}
	public class JsonSkeleton
	{
		public string PirateName { get; set; } = "";
		public int CoinsCount { get; set; } = 0;
		public long PirateTime { get; set; } = 0;
	}
}