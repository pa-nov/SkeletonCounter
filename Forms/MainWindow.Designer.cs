using SkeletonCounter.Properties;

namespace SkeletonCounter
{
    partial class MainWindow
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
            Menu = new MenuStrip();
            MenuCreate = new ToolStripMenuItem();
            MenuOpen = new ToolStripMenuItem();
            MenuNewSkeleton = new ToolStripMenuItem();
            MenuStatistics = new ToolStripMenuItem();
            AddWindow = new Panel();
            CoinsCountInput = new NumericUpDown();
            PirateNameInput = new ComboBox();
            NewSkeleton = new Button();
            SkeletonsArea = new FlowLayoutPanel();
            Menu.SuspendLayout();
            AddWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CoinsCountInput).BeginInit();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.BackColor = Color.FromArgb(1, 20, 26);
            Menu.Font = new Font("Windlass Extended", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Menu.Items.AddRange(new ToolStripItem[] { MenuCreate, MenuOpen, MenuNewSkeleton, MenuStatistics });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(480, 28);
            Menu.TabIndex = 0;
            // 
            // MenuCreate
            // 
            MenuCreate.ForeColor = Color.FromArgb(211, 200, 172);
            MenuCreate.Name = "MenuCreate";
            MenuCreate.Size = new Size(82, 24);
            MenuCreate.Text = "Создать";
            MenuCreate.Click += MenuCreate_Click;
            // 
            // MenuOpen
            // 
            MenuOpen.ForeColor = Color.FromArgb(211, 200, 172);
            MenuOpen.Name = "MenuOpen";
            MenuOpen.Size = new Size(86, 24);
            MenuOpen.Text = "Открыть";
            MenuOpen.Click += MenuOpen_Click;
            // 
            // MenuNewSkeleton
            // 
            MenuNewSkeleton.Alignment = ToolStripItemAlignment.Right;
            MenuNewSkeleton.ForeColor = Color.FromArgb(211, 200, 172);
            MenuNewSkeleton.Name = "MenuNewSkeleton";
            MenuNewSkeleton.Size = new Size(91, 24);
            MenuNewSkeleton.Text = "Добавить";
            MenuNewSkeleton.Click += MenuNewSkeleton_Click;
            // 
            // MenuStatistics
            // 
            MenuStatistics.Alignment = ToolStripItemAlignment.Right;
            MenuStatistics.ForeColor = Color.FromArgb(211, 200, 172);
            MenuStatistics.Name = "MenuStatistics";
            MenuStatistics.Size = new Size(106, 24);
            MenuStatistics.Text = "Статистика";
            MenuStatistics.Click += MenuStatistics_Click;
            // 
            // AddWindow
            // 
            AddWindow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddWindow.BackColor = Color.FromArgb(21, 40, 46);
            AddWindow.Controls.Add(CoinsCountInput);
            AddWindow.Controls.Add(PirateNameInput);
            AddWindow.Controls.Add(NewSkeleton);
            AddWindow.Location = new Point(0, 28);
            AddWindow.Name = "AddWindow";
            AddWindow.Size = new Size(480, 140);
            AddWindow.TabIndex = 0;
            AddWindow.Visible = false;
            // 
            // CoinsCountInput
            // 
            CoinsCountInput.BackColor = Color.FromArgb(11, 30, 36);
            CoinsCountInput.BorderStyle = BorderStyle.FixedSingle;
            CoinsCountInput.Font = new Font("Windlass Extended", 16.5F, FontStyle.Regular, GraphicsUnit.Point);
            CoinsCountInput.ForeColor = Color.FromArgb(211, 200, 172);
            CoinsCountInput.Location = new Point(20, 80);
            CoinsCountInput.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            CoinsCountInput.Name = "CoinsCountInput";
            CoinsCountInput.Size = new Size(74, 40);
            CoinsCountInput.TabIndex = 0;
            CoinsCountInput.TabStop = false;
            CoinsCountInput.TextAlign = HorizontalAlignment.Center;
            CoinsCountInput.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // PirateNameInput
            // 
            PirateNameInput.BackColor = Color.FromArgb(11, 30, 36);
            PirateNameInput.FlatStyle = FlatStyle.Flat;
            PirateNameInput.Font = new Font("Windlass Extended", 16.5F, FontStyle.Regular, GraphicsUnit.Point);
            PirateNameInput.ForeColor = Color.FromArgb(211, 200, 172);
            PirateNameInput.Location = new Point(20, 20);
            PirateNameInput.Name = "PirateNameInput";
            PirateNameInput.Size = new Size(440, 40);
            PirateNameInput.TabIndex = 0;
            PirateNameInput.TabStop = false;
            // 
            // NewSkeleton
            // 
            NewSkeleton.BackColor = Color.FromArgb(11, 30, 36);
            NewSkeleton.FlatStyle = FlatStyle.Flat;
            NewSkeleton.Location = new Point(332, 80);
            NewSkeleton.Name = "NewSkeleton";
            NewSkeleton.Size = new Size(128, 40);
            NewSkeleton.TabIndex = 0;
            NewSkeleton.TabStop = false;
            NewSkeleton.Text = "Добавить";
            NewSkeleton.UseVisualStyleBackColor = false;
            NewSkeleton.Click += NewSkeleton_Click;
            // 
            // SkeletonsArea
            // 
            SkeletonsArea.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SkeletonsArea.AutoScroll = true;
            SkeletonsArea.FlowDirection = FlowDirection.TopDown;
            SkeletonsArea.Location = new Point(0, 28);
            SkeletonsArea.Name = "SkeletonsArea";
            SkeletonsArea.Size = new Size(480, 760);
            SkeletonsArea.TabIndex = 0;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 30, 36);
            ClientSize = new Size(480, 788);
            Controls.Add(Menu);
            Controls.Add(AddWindow);
            Controls.Add(SkeletonsArea);
            Font = new Font("Windlass Extended", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(211, 200, 172);
            Icon = Resources.icon;
            Margin = new Padding(5);
            MinimumSize = new Size(496, 187);
            Name = "MainWindow";
            Text = "Счётчик Древних Скелетов";
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            AddWindow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CoinsCountInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip Menu;
        private ToolStripMenuItem MenuCreate;
        private ToolStripMenuItem MenuOpen;
        private ToolStripMenuItem MenuNewSkeleton;
        private ToolStripMenuItem MenuStatistics;
        private Panel AddWindow;
        private NumericUpDown CoinsCountInput;
        private ComboBox PirateNameInput;
        private Button NewSkeleton;
        private FlowLayoutPanel SkeletonsArea;
    }
}