namespace DataStructures.Entities
{
    public class IntNode
    {
        private int value;

        private IntNode nextNode;

        public IntNode(int value, IntNode nextNode)
        {
            this.value =  value;
            this.nextNode = nextNode;
        }
    }
}