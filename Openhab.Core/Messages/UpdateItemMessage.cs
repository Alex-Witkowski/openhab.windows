namespace OpenHAB.Core.Messages
{
    public class UpdateItemMessage
    {
        public string ItemName { get; set; }

        public string Value { get; set; }

        public UpdateItemMessage(string itemName, string value)
        {
            ItemName = itemName;
            Value = value;
        }
    }
}
