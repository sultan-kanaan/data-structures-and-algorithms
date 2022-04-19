# Challenge Summary
Write a function called public static bool MultiBracketValidation(string input). This function should take a string as its only argument, and should return a boolean representing whether or not the brackets in the string are balanced. There are 3 types of brackets:
* Round Brackets : ()
* Square Brackets : []
* Curly Brackets : {}

## Whiteboard Process
| Input | Expected Output |
| :----------- | :----------- |
| \{\} | True |
| \{\}()\{\}| True|
| ()[[]] | True |
| ()\{\}[[]] | True |
| \{\}\{\}\[\](()) | True |
| [(\{\}] | False |
| (]( | False|
| {(}) | False|

## Approach & Efficiency
Big O : O(n) 

## Solution
```
public static bool BracketValidation(string input)
        {

            Stack<char> Brackets = new Stack<char>();
            foreach (char item in input.ToCharArray())
            {
            switch (item)
                {
                    case '(':
                    case '{':
                    case '[':
                        Brackets.Push(item);
                        break;
                    case ')':
                        if (Brackets.Pop() != '(')
                        {
                            return false;
                        }
                        break;
                    case '}':
                        if (Brackets.Pop() != '{')
                        {
                            return false;
                        }
                        break;
                    case ']':
                        if (Brackets.Pop() != '[')
                        {
                            return false;
                        }
                        break;
                }
            
            }
            if (Brackets.Count == 0)
            {
                return true;
            }
            else
                return false;
        }
```
