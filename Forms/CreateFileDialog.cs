namespace SkeletonCounter
{
    public partial class CreateFileDialog : Form
    {
        public string[] Pirates = Array.Empty<string>();

        public CreateFileDialog()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int i = Pirates.Length;
            Array.Resize(ref Pirates, i + 1);
            Pirates[i] = AddInput.Text;

            Label label = new()
            {
                Text = AddInput.Text,
                AutoSize = true,
                MinimumSize = new(64, 32)
            };
            if (i % 2 == 0)
            {
                label.BackColor = Color.FromArgb(28, 38, 45);
            }
            else
            {
                label.BackColor = Color.FromArgb(38, 48, 55);
            }

            AddList.Controls.Add(label);
            AddInput.Text = "";
        }
    }
}