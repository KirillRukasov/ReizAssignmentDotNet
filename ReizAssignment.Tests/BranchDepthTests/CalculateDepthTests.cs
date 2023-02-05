using BranchDepthCalc;
using Xunit;

namespace ReizAssignment.Tests.BranchDepthTests
{
    public class CalculateDepthTests
    {
        [Fact]
        public void GetDepth_SingleBranch_ReturnsOne()
        {
            // Arrange
            var branch = new Branch();

            // Act
            int depth = CalculateDepth.GetDepth(branch);

            // Assert
            Assert.Equal(1, depth);
        }

        [Fact]
        public void GetDepth_MultipleBranches_ReturnsCorrectDepth()
        {
            // Arrange
            var branch = new Branch
            {
                Branches = new List<Branch>
                {
                    new Branch
                    {
                        Branches = new List<Branch>
                        {
                            new Branch()
                        }
                    },
                    new Branch(),
                }
            };

            // Act  
            int depth = CalculateDepth.GetDepth(branch);

            // Assert
            Assert.Equal(3, depth);
        }
    }
}
