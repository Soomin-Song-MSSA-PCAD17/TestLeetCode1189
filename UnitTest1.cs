namespace TestLeetCode1189
{
    public class Tests
    {
        LeetCode1189.Solution Solution;
        string Input;
        int ExpectedOutput;

        [SetUp]
        public void Setup()
        {
            Solution = new();
        }

        [Test]
        public void Test1()
        {
            Input = "nlaebolko";
            ExpectedOutput = 1;
            var output = Solution.MaxNumberOfBalloons(Input);
            Assert.That(output, Is.EqualTo(ExpectedOutput));
        }

        [Test]
        public void Test2()
        {
            Input = "loonbalxballpoon";
            ExpectedOutput = 2;
            var output = Solution.MaxNumberOfBalloons(Input);
            Assert.That(output, Is.EqualTo(ExpectedOutput));
        }

        [Test]
        public void Test3()
        {
            Input = "leetcode";
            ExpectedOutput = 0;
            var output = Solution.MaxNumberOfBalloons(Input);
            Assert.That(output, Is.EqualTo(ExpectedOutput));
        }

        [Test]
        public void Test4()
        {
            Input = "balon";
            ExpectedOutput = 0;
            var output = Solution.MaxNumberOfBalloons(Input);
            Assert.That(output, Is.EqualTo(ExpectedOutput));
        }

        [Test]
        public void Test5()
        {
            Input = "a";
            ExpectedOutput = 0;
            var output = Solution.MaxNumberOfBalloons(Input);
            Assert.That(output, Is.EqualTo(ExpectedOutput));
        }
    }
}
