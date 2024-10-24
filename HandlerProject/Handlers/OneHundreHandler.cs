namespace HandlerProject.Handlers;

public class OneHundreHandler : IHandler
{
    private IHandler _handler;
    public string Handler(int amout)
    {
        if (amout >= 100)
        {
            int count = amout / 100;
            amout -= count * 100;
            return $"100 -> {count} ta, " + _handler?.Handler(amout) ?? string.Empty;
        }
        return _handler.Handler(amout);
    }

    public void MoveNext(IHandler handler)
    {
        _handler = handler;
    }
}
