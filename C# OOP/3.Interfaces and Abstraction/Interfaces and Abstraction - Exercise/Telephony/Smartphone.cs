namespace Telephony
{
    public class Smartphone : ICallable, IBrowserable
    {
        public string Calling(string number)
        {
            return $"Calling... {number}";
        }

        public string Browsing(string url)
        {
            return $"Browsing: {url}!";
        }
    }
}
