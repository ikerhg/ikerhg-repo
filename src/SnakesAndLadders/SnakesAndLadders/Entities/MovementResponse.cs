namespace SnakesAndLadders.Entities
{
    public class MovementResponse
    {
        public bool HasErrors { get; set; }

        public string Message { get; set; }

        public bool HasWin { get; set; }

        public int DiceResult { get; set; }
        public Player Player { get; set; }

        public MovementResponse()
        {
            HasErrors = false;
            HasWin = false;
            Message = string.Empty;
        }

    }
}
