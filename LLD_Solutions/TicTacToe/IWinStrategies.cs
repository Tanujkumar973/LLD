namespace TicTacToe
{
    public interface IWinStrategies
    {
        bool IsWinner(Symbol symbol, Cell[,] cells,int length);
    }
}