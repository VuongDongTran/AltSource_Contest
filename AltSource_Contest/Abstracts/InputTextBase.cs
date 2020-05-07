namespace AltSource_Contest.Abstracts
{
    public abstract class InputTextBase
    {
        public string[] SplitData(string message)
        {
            var items = message.Split(' ');
            return items;
        }
    }
}
