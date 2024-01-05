using System.Text.Json;

namespace SkeletonCounter
{
    public partial class MainWindow : Form
    {
        private string CurrentFile = "ErrorFile.json";

        private long StartTime = 0;
        private string[] Pirates = Array.Empty<string>();
        private Skeleton[] Skeletons = Array.Empty<Skeleton>();

        #region Основные свойства окна
        public MainWindow() { InitializeComponent(); }
        private void MenuCreate_Click(object sender, EventArgs e) { CreateFile(); }
        private void MenuOpen_Click(object sender, EventArgs e) { OpenFile(); }
        private void MenuStatistics_Click(object sender, EventArgs e)
        {
            if (CurrentFile == "ErrorFile.json" || Skeletons.Length < 1)
            {
                System.Media.SystemSounds.Exclamation.Play();
                return;
            }
            new StatisticsWindow(CurrentFile).ShowDialog();
        }
        #endregion

        #region Добавление скелета
        private void MenuNewSkeleton_Click(object sender, EventArgs e)
        {
            AddWindow.Visible = !AddWindow.Visible;
        }
        private void NewSkeleton_Click(object sender, EventArgs e)
        {
            if (CurrentFile == "ErrorFile.json")
            {
                System.Media.SystemSounds.Exclamation.Play();
                return;
            }
            AddWindow.Visible = false;
            AddSkeleton((int)CoinsCountInput.Value, PirateNameInput.Text, DateTimeOffset.Now.ToUnixTimeSeconds());
            PirateNameInput.Text = "";
            SaveFile();
        }
        private void AddSkeleton(int coinsCount, string pirateName, long pirateTime)
        {
            int i = Skeletons.Length;
            Array.Resize(ref Skeletons, i + 1);

            Skeletons[i] = new(coinsCount, pirateName, pirateTime);
            if (i % 2 == 0)
            {
                Skeletons[i].BackColor = Color.FromArgb(28, 38, 45);
            }
            else
            {
                Skeletons[i].BackColor = Color.FromArgb(38, 48, 55);
            }
            SkeletonsArea.Controls.Add(Skeletons[i]);
        }
        #endregion

        #region Сохранение файла
        private void CreateFile()
        {
            SaveFileDialog saveFileDialog = new() { Filter = "Файл конфигурации (*.json)|*.json" };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = saveFileDialog.FileName;
                CurrentFile = file;

                CreateFileDialog createFileDialog = new();
                if (createFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StartTime = DateTimeOffset.Now.ToUnixTimeSeconds();

                    PirateNameInput.Items.Clear();
                    Pirates = createFileDialog.Pirates;
                    foreach (string pirate in Pirates)
                    {
                        PirateNameInput.Items.Add(pirate);
                    }

                    Skeletons = Array.Empty<Skeleton>();
                    SkeletonsArea.Controls.Clear();

                    SaveFile();
                }
            }
        }
        private void SaveFile()
        {
            string file = CurrentFile;

            JsonSkeleton[] jsonSkeletons = Array.Empty<JsonSkeleton>();
            for (int i = 0; i < Skeletons.Length; i++)
            {
                Array.Resize(ref jsonSkeletons, i + 1);
                jsonSkeletons[i] = Skeletons[i].GetData();
            }

            JsonSave jsonSave = new()
            {
                StartTime = StartTime,
                Pirates = Pirates,
                Skeletons = jsonSkeletons
            };

            File.WriteAllText(file, JsonSerializer.Serialize(jsonSave));
        }
        private void OpenFile()
        {
            OpenFileDialog openFileDialog = new() { Filter = "Файл конфигурации (*.json)|*.json" };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                CurrentFile = file;

                JsonSave jsonSave = JsonSerializer.Deserialize<JsonSave>(File.ReadAllText(file))!;

                StartTime = jsonSave.StartTime;

                PirateNameInput.Items.Clear();
                Pirates = jsonSave.Pirates;
                foreach (string pirate in Pirates)
                {
                    PirateNameInput.Items.Add(pirate);
                }

                Skeletons = Array.Empty<Skeleton>();
                SkeletonsArea.Controls.Clear();
                AddWindow.Visible = false;

                foreach (JsonSkeleton skeleton in jsonSave.Skeletons)
                {
                    AddSkeleton(skeleton.CoinsCount, skeleton.PirateName, skeleton.PirateTime);
                }
            }
        }
        #endregion
    }
}