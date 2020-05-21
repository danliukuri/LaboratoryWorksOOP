namespace Laboratory_work_7
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList list = new SinglyLinkedList();
            list.AddLast(-15.4f);
            list.AddLast(0.1f);
            list.AddLast(1.8f);
            list.AddLast(2.4f);
            list.AddLast(9.5f);
            list.AddLast(11.1f);
            list.AddLast(16.1f);
            list.AddLast(999.1f);

            list.Remove(999.1f);

            list.RemoveElementsSmallerFor(2.6f);

            int num = list.FindTheNumberOfElementsLargerFor(10.5f);
        }
    }
}