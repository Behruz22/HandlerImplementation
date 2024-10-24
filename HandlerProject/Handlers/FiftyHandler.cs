using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlerProject.Handlers;

internal class FiftyHandler : IHandler
{
    private IHandler _handler;
    public string Handler(int amout)
    {
        if (amout >= 50)
        {
            int count = amout / 50;
            amout %= 50;
            return $"50 -> {count} ta, " + _handler?.Handler(amout) ?? string.Empty;
        }
        return _handler?.Handler(amout);
    }

    public void MoveNext(IHandler handler)
    {
        _handler = handler;
    }
}
