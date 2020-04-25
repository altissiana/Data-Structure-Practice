using DataStructures.Entities;

namespace DataStructures.Collections
{
    public class IntLinkedList
    {
        private IntNode node; 
        
        public void Add(int value)
        {
            if(node == null)
            {
                node = new IntNode(value, null);
            }
            else 
            {
                var currentnode = node;

                while(currentnode.NextNode != null)
                {
                    currentnode = currentnode.NextNode;
                }

                currentnode.NextNode = new IntNode(value, null);
            }
        }

        
    }
}