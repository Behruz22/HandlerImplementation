using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlerProject.Handlers;

internal class TwentyHandler : IHandler
{
    private IHandler _handler;
    public string Handler(int amout)
    {
        if (amout >= 20)
        {
            int count = amout / 20;
            amout %= 20;
            return $"20 -> {count} ta, " + _handler?.Handler(amout) ?? string.Empty;
        }
        return _handler?.Handler(amout);
    }

    public void MoveNext(IHandler handler)
    {
        _handler = handler;
    }
}

