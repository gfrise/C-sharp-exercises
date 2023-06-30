namespace Ex19
{
    internal class CustomRanker : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return y.Grade.CompareTo(x.Grade);
        }

    }
};