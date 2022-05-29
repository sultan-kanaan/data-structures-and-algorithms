using QuickSort;
using System;
using Xunit;

namespace TestQuickSort
{
    public class UnitTest1
    {
        [Fact]
        public void TestQuickSortrandom()
        {
            int[] random = { 8, 4, 23, 42, 16, 15 };

            Assert.Equal(new int[] { 4, 8, 15, 16, 23, 42 }, Program.QuickSort(random, 0, random.Length - 1));
        }

        [Fact]
        public void TestQuickSortreverseSorted()
        {
            int[] reverseSorted = { 20, 18, 12, 8, 5, -2 };

            Assert.Equal(new int[] { -2, 5, 8, 12, 18, 20 }, Program.QuickSort(reverseSorted, 0, reverseSorted.Length - 1));
        }

        [Fact]
        public void TestQuickSortfewUniques()
        {
            int[] fewUniques = { 5, 12, 7, 5, 5, 7 };

            Assert.Equal(new int[] { 5, 5, 5, 7, 7, 12 }, Program.QuickSort(fewUniques, 0, fewUniques.Length - 1));
        }

        [Fact]
        public void TestQuickSortnearlySorted()
        {
            int[] nearlySorted = { 2, 3, 5, 7, 13, 11 };

            Assert.Equal(new int[] { 2, 3, 5, 7, 11, 13 }, Program.QuickSort(nearlySorted, 0, nearlySorted.Length - 1));
        }

    }
}
