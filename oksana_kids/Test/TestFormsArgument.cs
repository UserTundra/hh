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
        private int _idxCurrentTest;

        public List<SimplyTest> CurrentTest => ListOfArguments[IdxCurrentTest];

        public TestFormsArgument(List<List<SimplyTest>> listOfArguments, PupilSelectionWindow callback)
        {
            this.ListOfArguments = listOfArguments;
            this.Callback = callback;
        }

        public List<SimplyTest> GetNextTest()
        {
            if (IdxCurrentTest >= ListOfArguments.Count || ++IdxCurrentTest < 0)
                return null;
            return this.CurrentTest;
        }
    }
}
