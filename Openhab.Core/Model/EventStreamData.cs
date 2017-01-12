namespace OpenHAB.Core.Model
{
    public class EventStreamData
    {
        public string Topic { get; set; }

        public string Payload { get; set; }

        public string Type { get; set; }
    }

    public class EventStreamPayload
    {
        public string type { get; set; }
        public string value { get; set; }
    }
}