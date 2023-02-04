using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_15_СамРабота_ИНТЕРФЕЙСЫ
{
    public class GeomProgression : ISeries
    {
        int vl;
        int startValue;
        int currentValue;
        public int Vl
        {
            get => vl;
            set => vl = value;
        }
        public int getNext()
        {
            currentValue *= Vl;
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
