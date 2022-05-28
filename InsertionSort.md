# Challenge Summary
 tested implementation of Insertion Sort based on the pseudocode provided.
 ```
  InsertionSort(int[] arr)

    FOR i = 1 to arr.length

      int j <-- i - 1
      int temp <-- arr[i]

      WHILE j >= 0 AND temp < arr[j]
        arr[j + 1] <-- arr[j]
        j <-- j - 1

      arr[j + 1] <-- temp

 ```

 ## Inputs and Expected Outputs
| Input | Expected Output |
| :----------- |:----------- |
| [8,4,23,42,16,15] | [4,8,15,16,23,42] |
| [20,18,12,8,5,-2] | [-2,5,8,12,18,20] |
| [5,12,7,5,5,7] | [5,5,5,7,7,12] |
| [2,3,5,7,13,11] | [2,3,5,7,11,13] |


## Whiteboard Process
![](./img/InsertionSort.png)

## Trace
Pass 1 :
arr  => [8,4,23,42,16,15]

![](./img/face1.png)

In the first pass 8>4 => 8 is greater than 4 so swap 4 and 8 let 4 in the temp, then let the value of the second element in the first index, and finally let the second index = temp.


Pass 2 :

![](./img/face2.png)

In the second pass 23>8 => 23 is greater than 8 so Don't swap , we do not move the element 23 and the array stays in the same order.


Pass 3 :

![](./img/face3.png)

In the third pass 42>23 => 42 is greater than 23 so Don't swap , we do not move the element 42 and the array stays in the same order.

Pass 4 :

![](./img/face4.png)

In the fourth pass 16<42&23 => 16 is smaller than 42,23 so insert the element 16 into the previous position until 16>8


Pass 5 :

![](./img/face5.png)


In the fifth pass 15<42&23&16 => 15 is smaller than 42,23,16 so insert the element 15 into the previous position until 15>8


## Approach & Efficiency
| | Time | Space |
|:-- | :----------- | :----------- |
| InsertionSort(int[] arr) | O(n^2) | O(1) |


## Solution
```
public static int[] InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i - 1;
                int temp = arr[i];

                while (j >= 0 && temp < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j -= 1;
                }

                arr[j + 1] = temp;
            }

            return arr;
        }
```