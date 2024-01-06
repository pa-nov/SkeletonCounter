using SkeletonCounter.Properties;

namespace SkeletonCounter
{
    partial class CreateFileDialog
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
            AddList = new FlowLayoutPanel();
            AddInput = new TextBox();
            AddButton = new Button();
            StartButton = new Button();
            SuspendLayout();
            // 
            // AddList
            // 
            AddList.AutoScroll = true;
            AddList.FlowDirection = FlowDirection.TopDown;
            AddList.Location = new Point(20, 20);
            AddList.Name = "AddList";
            AddList.Size = new Size(320, 240);
            AddList.TabIndex = 0;
            // 
            // AddInput
            // 
            AddInput.BackColor = Color.FromArgb(11, 30, 36);
            AddInput.BorderStyle = BorderStyle.FixedSingle;
            AddInput.ForeColor = Color.FromArgb(211, 200, 172);
            AddInput.Location = new Point(20, 280);
            AddInput.Name = "AddInput";
            AddInput.Size = new Size(261, 39);
            AddInput.TabIndex = 0;
            AddInput.TabStop = false;
            // 
            // AddButton
            // 
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Location = new Point(301, 280);
            AddButton.Margin = new Padding(0);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(39, 39);
            AddButton.TabIndex = 0;
            AddButton.TabStop = false;
            AddButton.Text = "+";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // StartButton
            // 
            StartButton.DialogResult = DialogResult.OK;
            StartButton.FlatStyle = FlatStyle.Flat;
            StartButton.Location = new Point(20, 339);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(320, 39);
            StartButton.TabIndex = 0;
            StartButton.TabStop = false;
            StartButton.Text = "Начать";
            StartButton.UseVisualStyleBackColor = true;
            // 
            // CreateFileDialog
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 30, 36);
            ClientSize = new Size(360, 398);
            Controls.Add(AddList);
            Controls.Add(AddInput);
            Controls.Add(AddButton);
            Controls.Add(StartButton);
            Font = new Font("Windlass Extended", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(211, 200, 172);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = Resources.icon;
            Margin = new Padding(6);
            Name = "CreateFileDialog";
            Text = "Создание нового файла";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel AddList;
        private TextBox AddInput;
        private Button AddButton;
        private Button StartButton;
    }
}