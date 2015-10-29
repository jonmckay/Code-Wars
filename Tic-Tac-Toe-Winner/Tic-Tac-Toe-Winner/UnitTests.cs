using NUnit.Framework;

namespace Tic_Tac_Toe_Winner
{
    [TestFixture]
    public class UnitTests
    {
        private static string Message_WinnerX = "Player X is the winner";
        private static string Message_WinnerO = "Player O is the winner";
        private static string Message_Tie = "Game is a tie";

        [Test]
        public static void ExampleTest()
        {
            Assert.AreEqual(
              Message_WinnerX,
              Program.TicTacToeWinner("xxx|oxo|.oo"));

            Assert.AreEqual(Message_WinnerX, Program.TicTacToeWinner(".ox|o.x|o.x"));
        }
    }
}