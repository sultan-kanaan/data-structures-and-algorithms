[To Show BLOG](./BLOGQ.md)

# Challenge Summary

### What is Quick Sort?

**Quick Sort** is a Divide and Conquer algorithm which works by dividing the input into two smaller arrays: one with small items and the other with large items. Then, it recursively sorts both the smaller lists.

### Advantages

* Fast - On average, the quick sort runs in O(n log n) time
* Parallelizable - Quick Sort divides the input into two sections, each of which can be sorted at the same time in parallel

### Disadvantages

* Slow Worst- Case

## Whiteboard Process
![](./img/QSort.png)
## Approach & Efficiency

|  | Worst | Best | Average | Space |
|:-|:-:|:-:|:-:|:-:|
| QuickSort() | O(n^2) | O(n log n) | O(n log n) | O(log n) |
## Solution

### QuickSort

```c#
public static int[] QuickSort(int[] arr, int left, int right)
{
    if (left < right)
    {
        int position = Partition(arr, left, right);

        QuickSort(arr, left, position - 1);
        QuickSort(arr, position + 1, right);
    }

    return arr;
}
```

### Partition

```c#
static int Partition(int[] arr, int left, int right)
{
    int pivot = arr[right];
    int low = left - 1;

    for (int i = left; i < right; i++)
    {
        if (arr[i] <= pivot)
        {
            low++;
            Swap(arr, i, low);
        }
    }

    Swap(arr, right, low + 1);

    return low + 1;
}
```

### Swap

```c#
static void Swap(int[] arr, int i, int low)
{
    int temp = arr[i];
    arr[i] = arr[low];
    arr[low] = temp;
}
```
