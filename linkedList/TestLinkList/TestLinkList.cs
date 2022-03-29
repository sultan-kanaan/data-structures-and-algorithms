using System;
using Xunit;
using linkedList;

namespace TestLinkList
{
    public class TestLinkList
    {
        // Can successfully instantiate an empty linked list
        [Fact]
        public void TestInstantiate()
        {
            List MyList = new List();
            Assert.Null(MyList.Head);

        }

        // Can properly insert into the linked list
        [Fact]
        public void TestInsert()
        {
            List MyList = new List();
            MyList.Insert(5);
            Assert.True(MyList.Include(5));
        }

        // The head property will properly point to the first node in the linked list
        [Fact]
        public void Testpoint()
        {
            List MyList = new List();
            MyList.Insert(5);
            MyList.Insert(7);
            MyList.Insert(10);
            Assert.Equal(10, MyList.Head.Date);
        }


        // Can properly insert multiple nodes into the linked list
        [Fact]
        public void TestMultiple()
        {
            List MyList = new List();
            MyList.Insert(5);
            MyList.Insert(7);
            MyList.Insert(10);
            Assert.True(MyList.Include(5));
          
        }


        // Will return true when finding a value within the linked list that exists
        [Fact]
        public void TestTrue()
        {
            List MyList = new List();
            MyList.Insert(5);
            Assert.True(MyList.Include(5));
        }


        // Will return false when searching for a value in the linked list that does not exist
        [Fact]
        public void TestFalse()
        {
            List MyList = new List();
            MyList.Insert(5);
            Assert.False(MyList.Include(4));
        }

        // Can properly return a collection of all the values that exist in the linked list
        [Fact]
        public void TestAll()
        {
            List MyList = new List();
            MyList.Insert(5);
            MyList.Insert(7);
            MyList.Insert(10);
            Assert.Equal("[ 10 ] -> [ 7 ] -> [ 5 ] -> NULL", MyList.Tostring());
        }

        // Can successfully add a node to the end of the linked list
        [Fact]
        public void AddEnd()
        {
            List MyList = new List();
            MyList.Append(5);
            //Assert.Equal(5, MyList.Tail.Date);
            Assert.True(MyList.Head.Date == 5);

        }

        // Can successfully add multiple nodes to the end of a linked list
        [Fact]
        public void AddmultipleEnd()
        {
            List MyList = new List();
            MyList.Insert(3);
            MyList.Insert(4);
            MyList.Append(5);
            while (MyList.Head.Next != null)
            {
                MyList.Head = MyList.Head.Next;
            }

            Assert.Equal(5, MyList.Head.Date);

        }

        // Can successfully insert a node before a node located i the middle of a linked list
        [Fact]
        public void insertBefore()
        {
            List MyList = new List();
            MyList.Append(2);
            MyList.InsertBefore(2,3);
            Assert.Equal(3, MyList.Head.Date);
        }

        // Can successfully insert a node before the first node of a linked list
        [Fact]
        public void insertBeforeFirstNode()
        {
            List MyList = new List();
            MyList.Append(1);
            MyList.InsertBefore(1, 0);
            Assert.Equal(0, MyList.Head.Date);
        }

        // Can successfully insert after a node in the middle of the linked list
        [Fact]
        public void insertAfter()
        {
            List MyList = new List();
            MyList.Insert(1);
            MyList.Insert(3);
            MyList.InsertAfter(3, 2);
            Assert.Equal(2, MyList.Head.Next.Date);
        }

        // Can successfully insert a node after the last node of the linked list
        [Fact]
        public void insertAfterLastNode()
        {
            List MyList = new List();
            MyList.Insert(1);
            MyList.InsertAfter(1, 2);
            Assert.Equal(2, MyList.Head.Next.Date);
        }

    }

}
