using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlerProject;

public interface IHandler
{
    string Handler(int amout);
    void MoveNext(IHandler handler);
}
