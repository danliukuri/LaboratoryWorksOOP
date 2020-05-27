namespace Laboratory_work_7
{
    internal sealed class Node
    {
        internal float Data { get; }
        internal Node Next { get; set; }
        internal Node(float value)
        {
            Data = value;
            Next = null;
        }
    }
}