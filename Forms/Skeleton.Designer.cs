namespace SkeletonCounter
{
    partial class Skeleton
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            Icon = new PictureBox();
            Title = new Label();
            SubTitle = new Label();
            Date = new Label();
            Time = new Label();
            ((System.ComponentModel.ISupportInitialize)Icon).BeginInit();
            SuspendLayout();
            // 
            // Icon
            // 
            Icon.Anchor = AnchorStyles.None;
            Icon.Location = new Point(8, 8);
            Icon.Name = "Icon";
            Icon.Size = new Size(64, 64);
            Icon.TabIndex = 0;
            Icon.TabStop = false;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.None;
            Title.AutoSize = true;
            Title.ForeColor = Color.FromArgb(241, 238, 229);
            Title.Location = new Point(80, 8);
            Title.Name = "Title";
            Title.Size = new Size(253, 32);
            Title.TabIndex = 0;
            Title.Text = "Кол-во Древних монет";
            // 
            // SubTitle
            // 
            SubTitle.Anchor = AnchorStyles.None;
            SubTitle.AutoSize = true;
            SubTitle.Location = new Point(80, 40);
            SubTitle.Name = "SubTitle";
            SubTitle.Size = new Size(188, 32);
            SubTitle.TabIndex = 0;
            SubTitle.Text = "Никнейм пирата";
            // 
            // Date
            // 
            Date.Anchor = AnchorStyles.None;
            Date.Location = new Point(316, 8);
            Date.Name = "Date";
            Date.Size = new Size(144, 32);
            Date.TabIndex = 0;
            Date.Text = "??:??:??";
            Date.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Time
            // 
            Time.Anchor = AnchorStyles.None;
            Time.Location = new Point(316, 40);
            Time.Name = "Time";
            Time.Size = new Size(144, 32);
            Time.TabIndex = 0;
            Time.Text = "??:??:??";
            Time.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Skeleton
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 30, 36);
            Controls.Add(Icon);
            Controls.Add(Title);
            Controls.Add(SubTitle);
            Controls.Add(Date);
            Controls.Add(Time);
            Font = new Font("Windlass Extended", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(211, 200, 172);
            Margin = new Padding(0);
            Name = "Skeleton";
            Size = new Size(480, 80);
            ((System.ComponentModel.ISupportInitialize)Icon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Icon;
        private Label Title;
        private Label SubTitle;
        private Label Date;
        private Label Time;
    }
}