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
        public void TestLeftJoin()
        {
            HashTable left = new HashTable();
            left.Set("sultan", "250");
            left.Set("kanaan", "250");

            HashTable right = new HashTable();
            right.Set("sultan", "400");
            right.Set("salman", "400");

            List<string> expected = new List<string>();
            expected.Add("kanaan, 250, NULL");
            expected.Add("sultan, 250, HashTables.Node");

            List<string> actual = Program.LeftJoin(left, right);

            Assert.Equal(expected, actual);
        }


    }
}
