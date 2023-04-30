namespace Telephony
{
    public class StationaryPhone : ICallable
    {
        public string Calling(string number)
        {
            return $"Dialing... {number}";
        }
    }
}
