namespace PingApp
{
    internal interface IPV4
    {
        string Address { get; }
        IPV4 Increment(int value);
    }
}
