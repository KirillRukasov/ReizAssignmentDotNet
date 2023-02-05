namespace BranchDepthCalc
{
    public class CalculateDepth
    {
        public static int GetDepth(Branch branch)
        {
            if (branch.Branches.Count == 0)
            {
                return 1;
            }
            else
            {
                return 1 + branch.Branches.Max(b => GetDepth(b));
            }
        }
    }
}
