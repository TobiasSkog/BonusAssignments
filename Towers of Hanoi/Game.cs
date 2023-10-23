namespace BonusAssignments.Towers_of_Hanoi
{
    public class Game
    {
        public Tower A { get; private set; }
        public Tower B { get; private set; }
        public Tower C { get; private set; }
        private int Moves = 0;
        public Game(Tower a, Tower b, Tower c)
        {
            A = a;
            B = b;
            C = c;
        }

        public int Play()
        {
            return RecursiveTowerOfHanoi(A, B, C);
        }

        private int RecursiveTowerOfHanoi(Tower source, Tower rest, Tower target)
        {
            Tower.DrawGame(A, B, C, Moves);
            Moves++;
            if (!A.VictoryCondition(B))
            {
                if (source.ValidMove(target))
                {
                    source.MakeMove(target);
                    return RecursiveTowerOfHanoi(source, target, rest);
                }
                else
                {
                    if (target.ValidMove(rest))
                    {
                        target.MakeMove(rest);

                        return RecursiveTowerOfHanoi(source, rest, target);
                    }
                    else if (target.ValidMove(source))
                    {
                        target.MakeMove(source);

                        return RecursiveTowerOfHanoi(target, source, rest);
                    }
                    else
                    {
                        return Moves;
                    }
                }
            }

            else
            {
                target.MakeMove(rest);
                Tower.DrawGame(A, B, C, Moves);
                return Moves;
            }

        }

    }
}
