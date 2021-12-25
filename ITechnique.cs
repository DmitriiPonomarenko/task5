namespace Task5
{
    public interface ITechnique
    {
        bool TurnState { get; }

        public void ChangeTurnState();
    }
}