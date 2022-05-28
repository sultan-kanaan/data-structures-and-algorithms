using System;
using Xunit;
using InsertionSort;

namespace InsertionSortTest
{
    public class InsertionSort
    {
        [Fact]
        public void TestInsertionRandom()
        {
            int[] random = { 8, 4, 23, 42, 16, 15 };

            Assert.Equal(new int[] { 4, 8, 15, 16, 23, 42 }, Program.InsertionSort(random));
        }
        [Fact]
        public void TestInsertionReverseSorted()
        {
            int[] reverseSorted = { 20, 18, 12, 8, 5, -2 };

            Assert.Equal(new int[] { -2, 5, 8, 12, 18, 20 }, Program.InsertionSort(reverseSorted));
        }

        [Fact]
        public void TestInsertionFewUniques()
        {
            int[] fewUniques = { 5, 12, 7, 5, 5, 7 };

            Assert.Equal(new int[] { 5, 5, 5, 7, 7, 12 }, Program.InsertionSort(fewUniques));
        }

        [Fact]
        public void TestInsertionNearlySorted()
        {
            int[] nearlySorted = { 2, 3, 5, 7, 13, 11 };

            Assert.Equal(new int[] { 2, 3, 5, 7, 11, 13 }, Program.InsertionSort(nearlySorted));
        }
        [Fact]
        public void TestMergeRandom()
        {
            int[] random = { 8, 4, 23, 42, 16, 15 };

            Assert.Equal(new int[] { 4, 8, 15, 16, 23, 42 }, Program.MergeSort(random));
        }

        [Fact]
        public void TestMergeReverseSorted()
        {
            int[] reverseSorted = { 20, 18, 12, 8, 5, -2 };

            Assert.Equal(new int[] { -2, 5, 8, 12, 18, 20 }, Program.MergeSort(reverseSorted));
        }

        [Fact]
        public void TestMergeFewUniques()
        {
            int[] fewUniques = { 5, 12, 7, 5, 5, 7 };

            Assert.Equal(new int[] { 5, 5, 5, 7, 7, 12 }, Program.MergeSort(fewUniques));
        }

        [Fact]
        public void TestMergeNearlySorted()
        {
            int[] nearlySorted = { 2, 3, 5, 7, 13, 11 };

            Assert.Equal(new int[] { 2, 3, 5, 7, 11, 13 }, Program.MergeSort(nearlySorted));
        }



    }
}
