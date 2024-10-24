using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlerProject.Handlers;

public class TenHandler : IHandler
{
    private IHandler _handler;
    public string Handler(int amout)
    {
        if (amout >= 10)
        {
            int count=amout/10;
            amout %= 10;
            return $"10 -> {count} ta, " + _handler?.Handler(amout) ?? string.Empty;
        }
        return _handler?.Handler(amout);
    }

    public void MoveNext(IHandler handler)
    {
        _handler = handler;
    }
}
