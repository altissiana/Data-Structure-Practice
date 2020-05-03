namespace DataStructures.Entities
{
    public class IntNode
    {
        private int value;

        public IntNode NextNode
        {
            get; set;
        }

        public IntNode(int value, IntNode nextNode)
        {
            this.value =  value;
            this.NextNode = nextNode;
        }

        public IntNode(int value) : this(value, null)
        {
            
        }

    }
}