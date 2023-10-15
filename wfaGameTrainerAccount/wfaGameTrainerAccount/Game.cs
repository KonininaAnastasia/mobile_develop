namespace wfaGameTrainerAccount
{
    internal class Game
    {
        private Random rnd = new();

        public int CountCorrect { get; private set; } // свойство
        public int CountWrong { get; private set; }
        public string CodeText { get; private set; }
        public bool AnswerCorrect { get; private set; }

        public event EventHandler Change;

        public void DoReset()
        {
            CountCorrect = 0;
            CountWrong = 0;
            DoContinue();
        }


        private void DoContinue()
        {
            //CodeText = "33 + 10 = 50";
            //AnswerCorrect = false;
            int xValue1 = rnd.Next(20);
            int xValue2 = rnd.Next(20);
            int xResult = xValue1 + xValue2;
            int xResultNew = xResult;
            if (rnd.Next(2) == 1)
                xResultNew += rnd.Next(1, 7) *
                    (rnd.Next(2) == 0 ? 1 : -1);
            CodeText = $"{xValue1} + {xValue2} = {xResultNew}";
            AnswerCorrect = (xResult == xResultNew);
            Change?.Invoke(this, EventArgs.Empty);
        }

        public void DoAnswer(bool v)
        {
            if (v == AnswerCorrect)
                CountCorrect++;
            else
                CountWrong++;
            DoContinue();
        }

        
    }
}