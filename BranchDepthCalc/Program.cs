namespace BranchDepthCalc
{
    public class Program
    {
        static void Main(string[] args)
        {
            var root = new Branch
            {
                Branches = new List<Branch>
                {
                    new Branch
                    {
                        Branches = new List<Branch>
                        {
                            new Branch(),
                            new Branch
                            {
                                Branches = new List<Branch>
                                {
                                    new Branch(),
                                    new Branch()
                                }
                            }
                        }
                    },
                    new Branch()
                }
            };

            int depth = CalculateDepth.GetDepth(root);
            Console.WriteLine("Depth: " + depth);
        }
    }
}
