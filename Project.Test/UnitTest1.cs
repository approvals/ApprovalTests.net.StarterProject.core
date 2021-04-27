using ApprovalTests;
using NUnit.Framework;

namespace Project.Test
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Approvals.Verify("Hello");
        }
    }
}
