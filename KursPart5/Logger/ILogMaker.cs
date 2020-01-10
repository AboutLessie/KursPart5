using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursPart5.Logger
{
    public interface ILogMaker
    {
        void AddToLog(string text);
    }
}
