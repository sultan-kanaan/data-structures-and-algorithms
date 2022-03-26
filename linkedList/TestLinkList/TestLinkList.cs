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
        public void Test7()
        {
            List MyList = new List();
            MyList.Insert(5);
            MyList.Insert(7);
            MyList.Insert(10);
            Assert.Equal("[ 10 ] -> [ 7 ] -> [ 5 ] -> NULL", MyList.Tostring());
        }
    }
}
