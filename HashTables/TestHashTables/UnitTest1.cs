using System;
using Xunit;
using HashTables;
using System.Collections.Generic;

namespace TestHashTables
{
    public class UnitTest1

    {
        [Fact]
        public void CanSetAKeyValueToHashTableResultsInTheValueBeingInTheDataStructure()
        {
            HashTable testHashTable = new HashTable();

            testHashTable.Set("Test", "Value");

            Assert.True(testHashTable.Contains("Test"));
        }

        [Fact]
        public void CanRetrieveBasedOnAKeyReturnsTheValueStored()
        {
            HashTable testHashTable = new HashTable();

            testHashTable.Set("Test", "Value");

            Assert.Equal("Value", testHashTable.Get("Test").Value);
        }
        [Fact]
        public void ReturnsNullForAKeyThatDoesNotExistInTheHashTable()
        {
            HashTable testHashTable = new HashTable();

            testHashTable.Set("Test", "Value");

            Assert.Null(testHashTable.Get("Hello"));
        }
        [Fact]
        public void CanHandleACollisionWithinTheHashTable()
        {
            HashTable testHashTable = new HashTable();

            testHashTable.Set("Test", "ValueOne");
            testHashTable.Set("eTst", "ValueTwo");

            Assert.Equal(testHashTable.Hash("eTst"), testHashTable.Hash("Test"));
        }
        [Fact]
        public void CanrRetrieveAValueFromABucketWithinTheHashTableThatHasACollision()
        {
            HashTable testHashTable = new HashTable();

            testHashTable.Set("Test", "ValueOne");
            testHashTable.Set("eTst", "ValueTwo");

            Assert.Equal(testHashTable.Hash("eTst"), testHashTable.Hash("Test"));
            Assert.Equal("ValueOne", testHashTable.Get("Test").Value);
            Assert.Equal("ValueTwo", testHashTable.Get("eTst").Value);
        }
        [Fact]
        public void CanrHashAKeyToAnInRangeValue()
        {
            HashTable testHashTable = new HashTable();

            testHashTable.Set("Test", "ValueOne");

            Assert.InRange(testHashTable.Hash("Test"), 0, 1024);
        }

        [Fact]
        public void RepeatedWorTestOne()
        {
            string testPhrase = "Once upon a time, there was a brave princess who...";

            Assert.Equal("a", Program.RepeatedWord(testPhrase));
        }
        [Fact]
        public void RepeatedWorTestTwo()
        {
            string testPhrase = "Hello, World! World! World!";

            Assert.NotEqual("hello", Program.RepeatedWord(testPhrase));
        }
        [Fact]
        public void RepeatedWorTestThree()
        {
            string testPhrase = "Hello, World!";

            Assert.Equal("No Repeated Word", Program.RepeatedWord(testPhrase));
        }
        [Fact]
        public void TestingWithNoRightData()
        {
            HashTable left = new HashTable();
            left.Set("sultan", "First");
            left.Set("kanaan", "First");
            left.Set("salman", "World");
            left.Set("aws", "Hello");

            HashTable right = new HashTable();

            List<string> expected = new List<string>();
            expected.Add("kanaan, First, NULL");
            expected.Add("aws, Hello, NULL");
            expected.Add("sultan, First, NULL");
            expected.Add("salman, World, NULL");




            List<string> actual = Program.LeftJoin(left, right);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestTreeIntersection()
        {
            BinaryTree testTreeOne = new BinaryTree();
            testTreeOne.Root = new Node(1);
            testTreeOne.Root.Left = new Node(2);
            testTreeOne.Root.Right = new Node(3);

            BinaryTree testTreeTwo = new BinaryTree();
            testTreeTwo.Root = new Node(4);
            testTreeTwo.Root.Left = new Node(1);
            testTreeTwo.Root.Right = new Node(2);

            List<int> expected = new List<int> { 1, 2 };
            List<int> actual = Program.TreeIntersection(testTreeOne, testTreeTwo);

            Assert.Equal(expected, actual);
        }


    }
}
