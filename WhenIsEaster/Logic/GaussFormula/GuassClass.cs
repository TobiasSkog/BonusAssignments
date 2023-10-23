using BonusAssignments.WhenIsEaster.Logic;

namespace WhenIsEaster.App.Logic.GaussFormula
{
    public class GuassClass
    {
        public int EasterYear { get; private set; }
        public int a { get; private set; }
        public int b { get; private set; }
        public int c { get; private set; }
        public int d { get; private set; }
        public int e { get; private set; }

        public int M { get; private set; }
        public int N { get; private set; }
        public DateTime EasterDate { get; private set; }

        public GuassClass(int year)
        {
            EasterYear = year;
            var tableValues = MetonsCykel.GetMetonsCykel(EasterYear);
            M = tableValues.Item1;
            N = tableValues.Item2;
            a = EasterYear % 19;
            b = EasterYear % 500;
            c = EasterYear % 285;
            d = (19 * a + M) % 30;
            e = (2 * b + 4 * c + 6 * d + N) % 7;
            SetEasterDate(22 + d + e);
        }

        private void SetEasterDate(int day)
        {
            if (day <= 31)
            {
                if (day == 26)
                {
                    EasterDate = new DateTime(EasterYear, 4, day - 7);
                }
                else if (day == 25 && d == 28 && e == 6 && a > 10)
                {
                    EasterDate = new DateTime(EasterYear, 4, day - 7);
                }
                else
                {
                    EasterDate = new DateTime(EasterYear, 4, day);
                }

            }
            else
            {
                EasterDate = new DateTime(EasterYear, 5, day - 31);
            }
        }

        public override string ToString()
        {
            return $"\n\tEaster {(EasterDate <= DateTime.Now ? "was" : "is")} the {EasterDate:M} {EasterDate:yyyy}";
        }
    }
}
