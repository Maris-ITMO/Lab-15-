using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_15_СамРабота_ИНТЕРФЕЙСЫ
{
    public class ArithProgression : ISeries
    {
        int e;
        int startValue;
        int currentValue;
        public int E
        {
            get => e;
            set => e = value;
        }
        public int getNext()
        {
            currentValue += E;
            return currentValue;
        }

        public void rEset()
        {
            currentValue = startValue;
        }

        public void setStart(int x)
        {
            startValue = x;
            currentValue = startValue;
        }
    }
}
