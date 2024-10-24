using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlerProject.Handlers;

public class OneHandler : IHandler
{
    private IHandler _handler;
    public string Handler(int amout)
    {
        if (amout >= 1)
        {
            int count = amout / 1;
            amout-=count*1;
            return $"1 -> {count} ta, "+_handler?.Handler(amout) ?? string.Empty;
        }
        return _handler?.Handler(amout);
    }

    public void MoveNext(IHandler handler)
    {
        _handler = handler;
    }
}
