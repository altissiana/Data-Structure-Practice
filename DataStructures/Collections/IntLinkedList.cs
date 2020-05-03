using DataStructures.Entities;

namespace DataStructures.Collections
{
    public class IntLinkedList
    {
        private IntNode node; 
        public int Count
        {
            get; set;
        }

        
        public void Add(int value)
        {
            Count++;

            if(node == null)
            {
                node = new IntNode(value);
            }
            else 
            {
                var currentnode = node;

                while(currentnode.NextNode != null)
                {
                    currentnode = currentnode.NextNode;
                }

                currentnode.NextNode = new IntNode(value);
            }
        }

        
    }
}