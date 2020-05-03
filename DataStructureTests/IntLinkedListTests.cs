using System;
using DataStructures.Collections;
using Xunit;

namespace DataStructureTests
{
    public class IntLinkedListTests
    {
        public class CountShould
        {
            [Fact]
            public void ReturnZeroWhenListIsEmpty()
            {
                IntLinkedList list = new IntLinkedList();
                Assert.Equal(0, list.Count);
            }

            [Fact]
            public void ReturnCountWhenListHasItems()
            {
                IntLinkedList list = new IntLinkedList();
                list.Add(8);
                list.Add(13);
                list.Add(21);

                Assert.Equal(3, list.Count);
            }
        }
        
    }
}
