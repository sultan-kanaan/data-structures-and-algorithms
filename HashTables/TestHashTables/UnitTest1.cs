using System;
using Xunit;
using HashTables;

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
    }
}
