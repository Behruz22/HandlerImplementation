namespace HandlerProject.Handlers;

public class FiveHandler : IHandler
{
    private IHandler _handler;
    public string Handler(int amout)
    {
        if (amout >= 5)
        {
            int count = amout / 5;
            amout -= count * 5;
            return $"5 -> {count} ta, " + _handler?.Handler(amout) ?? string.Empty;
        }
        return _handler?.Handler(amout);
    }

    public void MoveNext(IHandler handler)
    {
        _handler = handler;
    }
}
