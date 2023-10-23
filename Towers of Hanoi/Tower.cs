namespace BonusAssignments.Towers_of_Hanoi
{
    public class Tower
    {
        private Stack<int> Discs { get; set; }

        public Tower()
        {
            Discs = new Stack<int>();
        }
        public Tower(int discAmount)
        {
            var discArray = new int[discAmount];
            for (int i = 0; i < discArray.Length; i++)
            {
                discArray[i] = discArray.Length - i;
            }
            Discs = new Stack<int>(discArray);
        }
        public bool ValidMove(Tower targetTower)
        {
            // Console.WriteLine($"{(targetTower.Discs.Count == 0 || Discs.Count == 0 ? "" : $"\tDiscs.Peek(): {Discs.Peek()} \n\ttargetTower.Discs.Peek(): {targetTower.Discs.Peek()}\n\tSum: {(targetTower.Discs.Peek() - Discs.Peek())}")}");

            if (Discs.Count > 0)
            {

                if (targetTower.Discs.Count == 0 || Discs.Peek() < targetTower.Discs.Peek() && targetTower.Discs.Peek() - Discs.Peek() <= 1)
                {
                    //Console.WriteLine("\t\tTrue");
                    return true;
                }
            }
            //Console.WriteLine("\t\tFalse");
            return false;
        }
        public void MakeMove(Tower target) => target.Discs.Push(Discs.Pop());
        public static void DrawGame(Tower A, Tower B, Tower C, int moves)
        {
            Console.WriteLine($"{(A.Discs.Count > 0 ? $"\t| {A.Discs.Peek()}" : "\t| 0")}" + " | " + $"{(B.Discs.Count > 0 ? $"{B.Discs.Peek()}" : "0")}" + " | " + $"{(C.Discs.Count > 0 ? $"{C.Discs.Peek()}" : "0")} | Moves: {moves}");
        }
        public bool VictoryCondition(Tower rest) => Discs.Count == 1 && rest.Discs.Count == 0;
    }
}
