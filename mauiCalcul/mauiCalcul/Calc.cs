
namespace mauiCalcul
{
    internal class Calc
    {
        private enum Oper {None, Div, Mul, Sub, Sum}

        private double numCur;
        private Oper oper;
        private double numLast;

        public string Text
        {
            get
            {
                return numCur.ToString();
            }
        }

        public event EventHandler Changed;

        internal void CE()
        {
            numCur = 0;
            Changed?.Invoke(this, EventArgs.Empty);
        }

        internal void Pow()
        {
            numCur = Math.Pow(numCur, 2);
            Changed?.Invoke(this, EventArgs.Empty);
        }

        internal void PressDiv()
        {
            oper = Oper.Div;
            numLast = numCur;
            numCur = 0;
        }

        internal void PressMul()
        {
            oper = Oper.Mul;
            numLast = numCur;
            numCur = 0;
        }

        internal void PressNum(int v)
        {
            numCur = numCur * 10 + v;
            Changed?.Invoke(this, EventArgs.Empty);
        }

        internal void PressSub()
        {
            oper = Oper.Sub;
            numLast = numCur;
            numCur = 0;
        }

        internal void PressSum()
        {
            oper = Oper.Sum;
            numLast = numCur;
            numCur = 0;
        }

        internal void PressEqual()
        {
            switch (oper)
            {
                case Oper.Div:
                    numCur = numLast / numCur;
                    break; 
                case Oper.Mul:
                    numCur = numLast * numCur;
                    break;
                case Oper.Sub: 
                    numCur = numLast - numCur;
                    break;
                case Oper.Sum: 
                    numCur = numLast + numCur;
                    break;

                default:
                    break;
            }
            numLast = 0;
            Changed?.Invoke(this, EventArgs.Empty);
        }
    }
}