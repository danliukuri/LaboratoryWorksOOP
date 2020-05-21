namespace Laboratory_work_7
{
    internal class Node
    {
        internal object Data { get; }
        internal Node Next { get; set; }
        internal Node(object value)
        {
            Data = value;
            Next = null;
        }
    }
}