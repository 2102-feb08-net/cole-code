using System;
using rockpaperscissors;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // arrange
            var roundResult = new RoundResult(Move.Paper, Move.Paper);

            Assert.True(RoundResult,RoundResult.win)

           

            Console.WriteLine(roundResult);

            // act

            // assert
            // throw new NotImplementedException();
        }
    }
}
