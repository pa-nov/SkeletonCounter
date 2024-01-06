using SkeletonCounter.Properties;

namespace SkeletonCounter
{
	partial class StatisticsWindow
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			StartTime = new Label();
			TotalTime = new Label();
			AVGTime = new Label();
			TotalCount = new Label();
			TotalCountSkeleton = new Label();
			TotalCountReroll = new Label();
			SuspendLayout();
			// 
			// StartTime
			// 
			StartTime.AutoSize = true;
			StartTime.Location = new Point(20, 20);
			StartTime.Name = "StartTime";
			StartTime.Size = new Size(249, 23);
			StartTime.TabIndex = 0;
			StartTime.Text = "Начало: ??.??.?? - ??:??:??";
			// 
			// TotalTime
			// 
			TotalTime.AutoSize = true;
			TotalTime.Location = new Point(20, 53);
			TotalTime.Name = "TotalTime";
			TotalTime.Size = new Size(326, 23);
			TotalTime.TabIndex = 0;
			TotalTime.Text = "Потрачено времени: ? часов ? минут";
			// 
			// AVGTime
			// 
			AVGTime.AutoSize = true;
			AVGTime.Location = new Point(20, 85);
			AVGTime.Name = "AVGTime";
			AVGTime.Size = new Size(382, 23);
			AVGTime.TabIndex = 0;
			AVGTime.Text = "Среднее время перерыва: ? минут ? секунд";
			// 
			// TotalCount
			// 
			TotalCount.AutoSize = true;
			TotalCount.Location = new Point(20, 128);
			TotalCount.Name = "TotalCount";
			TotalCount.Size = new Size(213, 23);
			TotalCount.TabIndex = 0;
			TotalCount.Text = "Всего Древних монет: ?";
			// 
			// TotalCountSkeleton
			// 
			TotalCountSkeleton.AutoSize = true;
			TotalCountSkeleton.Location = new Point(20, 161);
			TotalCountSkeleton.Name = "TotalCountSkeleton";
			TotalCountSkeleton.Size = new Size(237, 23);
			TotalCountSkeleton.TabIndex = 0;
			TotalCountSkeleton.Text = "Всего Древних скелетов: ?";
			// 
			// TotalCountReroll
			// 
			TotalCountReroll.AutoSize = true;
			TotalCountReroll.Location = new Point(20, 204);
			TotalCountReroll.Name = "TotalCountReroll";
			TotalCountReroll.Size = new Size(154, 23);
			TotalCountReroll.TabIndex = 2;
			TotalCountReroll.Text = "Всего реролов: ?";
			// 
			// StatisticsWindow
			// 
			AutoScaleDimensions = new SizeF(11F, 23F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(11, 30, 36);
			ClientSize = new Size(480, 247);
			Controls.Add(StartTime);
			Controls.Add(TotalCountReroll);
			Controls.Add(AVGTime);
			Controls.Add(TotalCountSkeleton);
			Controls.Add(TotalTime);
			Controls.Add(TotalCount);
			Font = new Font("Windlass Extended", 12F, FontStyle.Bold, GraphicsUnit.Point);
			ForeColor = Color.FromArgb(211, 200, 172);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Icon = Resources.icon;
			Margin = new Padding(6);
			Name = "StatisticsWindow";
			Text = "Статистика";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label StartTime;
		private Label TotalTime;
		private Label AVGTime;
		private Label TotalCount;
		private Label TotalCountSkeleton;
		private Label TotalCountReroll;
	}
}