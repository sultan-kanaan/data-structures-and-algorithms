# Hashmap LEFT JOIN
This app demonstrates a Left Join operation on two hashmaps. In our example, two hashmaps of string key/values are joined in a new collection of all the first hashmap's keys and values, plus any values from the second hashmap that have the same key as the first.

## Challenge
* Write a function that LEFT JOINs two hashmaps into a single data structure.
* The first parameter is a hashmap that has word strings as keys, and a synonym of the key as values.
* The second parameter is a hashmap that has word strings as keys, and antonyms of the key as values.
* Combine the key and corresponding values (if they exist) into a new data structure according to LEFT JOIN logic.
* LEFT JOIN means all the values in the first hashmap are returned, and if values exist in the “right” hashmap, they are appended to the result row. If no values exist in the right hashmap, then some flavor of NULL should be appended to the result row.
* The returned data structure that holds the results is up to you. It doesn’t need to exactly match the output below, so long as it achieves the LEFT JOIN logic.
* Avoid utilizing any of the library methods available to your language.

## Whiteboard Process
![](./img/JoinT.png)


## Approach & Efficiency
* Big O Space = O(n)
* Big O Time = O(n)

## Solution
```c#
public static List<string> LeftJoin(HashTable left, HashTable right)
        {
            List<string> joinTable = new List<string>();

            for (int i = 0; i < left.Table.Length; i++)
            {
                if (left.Table[i] != null)
                {
                    Node currentNode = left.Table[i];

                    while (currentNode != null)
                    {
                        string concat = null;
                        concat = concat + $"{currentNode.Key}, {currentNode.Value}, ";
                        if (right.Contains(currentNode.Key))
                        {
                            concat = concat + right.Get(currentNode.Key);
                        }
                        else
                        {
                            concat += "NULL";
                        }
                        joinTable.Add(concat);
                        currentNode = currentNode.Next;
                    }
                }
            }

            return joinTable;
        }
```
