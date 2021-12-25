namespace Task5
{
    public abstract class Player : ITechnique
    {
        public bool TurnState { get; private set; } = false;

        public int Volume { get; private set; } = 50;

        public bool MuteState { get; private set; } = false;

        public void VolumeUp()
        {
            Volume = Volume != 100 ? Volume++ : 100;
        }

        public void VolumeDown()
        {
            Volume = Volume != 0 ? Volume++ : 0;
        }

        public void ChangeTurnState()
        {
            TurnState = !TurnState;
        }

        public void ChangeMuteState()
        {
            MuteState = !MuteState;
        }
    }
}