using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_15_СамРабота_ИНТЕРФЕЙСЫ
{
    public interface ISeries
    {
        void setStart(int x);
        int getNext();
        void rEset();
    }
}
