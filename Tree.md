# Trees
Binary Tree is a subset of Graph data structure used for data storage purposes. A binary tree has a special condition that each node can have at most two children, usually called Left and Right.

```text
               ROOT
              (100)
              /    \ EDGE
LEFT CHILD (50)    (200) RIGHT CHILD
           /  \    /
        (25) (75) (155)
       <-----LEAVES----->     
```

## Challenge

* Create a `Node` class that has properties for the value stored in the node, the left child node, and the right child node.

* Create a `Binary Tree` class And Define a method for each of the depth first traversals :

   - pre order
   - in order
   - post order 

* Create Add and Contains methods :

   - `Add` Adds a new node with that value in the correct location in the binary search tree.
   - `Contains` Returns boolean indicating whether or not the value is in the tree at least once

## Approach & Efficiency
|| Worst Case |
|:-|:-:|
| Search | O(n) |
| Insertion | O(n)|
| Deletion | O(n) |

## API

* `pre order` which returns an array of the values, ordered root >> left >> right.
* `in order` which returns an array of the values, ordered left >> root >> right.
* `post order ` which returns an array of the values, ordered left >> right >> root.
* `Add` Adds a new node with that value in the correct location in the binary search tree.
*  `Contains` Returns boolean indicating whether or not the value is in the tree at least once
