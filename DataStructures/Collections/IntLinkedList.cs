using DataStructures.Entities;

namespace DataStructures.Collections
{
    public class IntLinkedList
    {
        private IntNode node;
        
        public void Add(int value)
        {
            var node = new IntNode(value, null);
            this.node = node;
        }

        
    }
}