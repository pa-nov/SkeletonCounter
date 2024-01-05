using SkeletonCounter.Properties;

namespace SkeletonCounter
{
    public partial class Skeleton : UserControl
    {
        private readonly int _CoinsCount = 0;
        private readonly string _PirateName = "";
        private readonly long _PirateTime = 0;

        public Skeleton(int coinsCount, string pirateName, long pirateTime)
        {
            InitializeComponent();

            _CoinsCount = coinsCount;
            _PirateName = pirateName;
            _PirateTime = pirateTime;

            if (_CoinsCount > 0)
            {
                Title.Text = Tools.GetNiceText(_CoinsCount, "Древняя монета", "Древние монеты", "Древних монет");
                if (_CoinsCount < 200)
                {
                    Icon.Image = Resources.CoinsSmall;
                }
                else
                {
                    if (_CoinsCount > 400)
                    {
                        Icon.Image = Resources.CoinsLarge;
                    }
                    else
                    {
                        Icon.Image = Resources.CoinsMiddle;
                    }
                }
                SubTitle.Text = _PirateName;
                Date.Text = Tools.GetNiceDate(_PirateTime);
                Time.Text = Tools.GetNiceTime(_PirateTime);
            }
            else
            {
                Title.Text = "РЕРОЛЛ";
                Date.Text = Tools.GetNiceDate(_PirateTime);
                Time.Text = Tools.GetNiceTime(_PirateTime);
                SubTitle.Text = "";

                Title.Font = new(SubTitle.Font.Name, 33);

                Icon.Image = Resources.Reroll;
            }
        }

        public JsonSkeleton GetData()
        {
            return new()
            {
                CoinsCount = _CoinsCount,
                PirateName = _PirateName,
                PirateTime = _PirateTime
            };
        }
    }
}