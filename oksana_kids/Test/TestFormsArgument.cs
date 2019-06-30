using System.Collections.Generic;

namespace oksana_kids.Test
{
    public class TestFormsArgument
    {
        public List<List<SimplyTest>> ListOfArguments { get; private set; }
        public PupilSelectionWindow Callback { get; private set; }
        public int TestsCount => ListOfArguments.Count;

        public int IdxCurrentTest {
            get { return _idxCurrentTest; }
            set { _idxCurrentTest = value; }
        }
        private int _idxCurrentTest = -1;
        public int testQuestionCount()
        {
            int ans = 0;
            foreach (var el in ListOfArguments)
            {
                foreach (var el2 in el)
                {
                    ans++;
                }
            }
            return ans;
        }
        public List<SimplyTest> CurrentTest => ListOfArguments[IdxCurrentTest];

        public TestFormsArgument(List<List<SimplyTest>> listOfArguments, PupilSelectionWindow callback)
        {
            this.ListOfArguments = listOfArguments;
            this.Callback = callback;
        }

        public List<SimplyTest> GetNextTest()
        {
            IdxCurrentTest++;
            if (IdxCurrentTest >= ListOfArguments.Count)
                return null;
            return this.CurrentTest;
        }
    }
}
