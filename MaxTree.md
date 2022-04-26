# MaX Tree 


## Challenge Summary
Find the maximum value stored in the tree. You can assume that the values stored in the Binary Tree will be numeric.


## Whiteboard Process
![](./img/MaxTree.png)


## Approach & Efficiency
Time Complexity :
O(n)

## Solution
```
public int Getmax()
        {
            Node current = Root;
            while (current.Right != null)
            {
                current = current.Right;
            }
            return current.Value;
        }
```