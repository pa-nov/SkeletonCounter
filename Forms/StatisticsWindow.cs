using System.Text.Json;

namespace SkeletonCounter
{
	public partial class StatisticsWindow : Form
	{
		public StatisticsWindow(string file)
		{
			InitializeComponent();

			JsonSave jsonSave = JsonSerializer.Deserialize<JsonSave>(File.ReadAllText(file))!;

			long endTime = jsonSave.StartTime;
			int[] avgTime = Array.Empty<int>();
			int[] totalCount = { 0, 0, 0 };

			for (int i = 0; i < jsonSave.Skeletons.Length; i++)
			{
				JsonSkeleton skeleton = jsonSave.Skeletons[i];
				if (skeleton.CoinsCount > 0)
				{
					Array.Resize(ref avgTime, avgTime.Length + 1);
					avgTime[^1] = (int)(skeleton.PirateTime - endTime);

					totalCount[0] += skeleton.CoinsCount;
					totalCount[1]++;
				}
				else
				{
					totalCount[2]++;
				}
				endTime = skeleton.PirateTime;
			}

			long totalHours = (endTime - jsonSave.StartTime) / 60 / 60;
			long totalMinutes = (endTime - jsonSave.StartTime) / 60 - totalHours * 60;

			int avgMinutes = avgTime.Sum() / avgTime.Length / 60;
			int avgSeconds = avgTime.Sum() / avgTime.Length - avgMinutes * 60;

			StartTime.Text = "Начало: " +
				Tools.GetNiceDate(jsonSave.StartTime) + " - " +
				Tools.GetNiceTime(jsonSave.StartTime);
			TotalTime.Text = "Потрачено времени: " +
				Tools.GetNiceText((int)totalHours, "час", "часа", "часов") + " " +
				Tools.GetNiceText((int)totalMinutes, "минута", "минуты", "минут");
			AVGTime.Text = "Среднее время перерыва: " +
				Tools.GetNiceText(avgMinutes, "минута", "минуты", "минут") + " " +
				Tools.GetNiceText(avgSeconds, "секунда", "секунды", "секунд");

			TotalCount.Text = "Всего Древних монет: " + totalCount[0];
			TotalCountSkeleton.Text = "Всего Древних скелетов: " + totalCount[1];
			TotalCountReroll.Text = "Всего реролов: " + totalCount[2];

		}
	}
}