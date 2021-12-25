namespace Task5
{
    public enum VideoOutput
    {
        HDMI,
        DVI
    }
    
    public class VideoPlayer : Player
    {
        public bool RecordingState { get; private set; }
        public VideoOutput VideoOutput { get; set; }

        public void ChangeRecordingState()
        {
            RecordingState = !RecordingState;
        }
    }
}