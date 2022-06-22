# Hashtables
Hashtables are a data structure that utilize key value pairs. This means every Node or Bucket has both a key, and a value.
The basic idea of a hashtable is the ability to store the key into this data structure, and quickly retrieve the value. This is done through what we call a hash. A hash is the ability to encode the key that will eventually map to a specific location in the data structure that we can look at directly to retrieve the value.

Since we are able to hash our key and determine the exact location where our value is stored, we can do a lookup in an O(1) time complexity. This is ideal when quick lookups are required.

`Hash` - A hash is the result of some algorithm taking an incoming string and converting it into a value that could be used for either security or some other purpose. In the case of a hashtable, it is used to determine the index of the array.

`Buckets` - A bucket is what is contained in each index of the array of the hashtable. Each index is a bucket. An index could potentially contain multiple key/value pairs if a collision occurs.

`Collisions` - A collision is what happens when more than one key gets hashed to the same location of the hashtable.


## Challenge

Implement a Hashtable Class with the following methods:

`set`

Arguments: key, value
Returns: nothing
This method should hash the key, and set the key and value pair in the table, handling collisions as needed.
Should a given key already exist, replace its value from the value argument given to this method.

`get`

Arguments: key
Returns: Value associated with that key in the table

`contains`
Arguments: key
Returns: Boolean, indicating if the key exists in the table already.

`keys`

Returns: Collection of keys

`hash`

Arguments: key
Returns: Index in the collection for that key

## Approach & Efficiency

| | Time | Space |
|:-- | :----------- | :----------- |
| Add | O(n) | O(1) |
| Get | O(n) | O(1) |
| Contains | O(n) | O(1) |
| Hash | O(n) | O(1) |

## API
Implement a Hashtable with the following methods:
1. `add`: takes in both the key and value. This method should hash the key, and add the key and value pair to the table, handling collisions as needed.
2. `get`: takes in the key and returns the value from the table.
3. `contains`: takes in the key and returns a boolean, indicating if the key exists in the table already.
4. `hash`: takes in an arbitrary key and returns an index in the collection.

## Structure and Testing

- [x] Setting a key/value to your hashtable results in the value being in the data structure
- [x] Retrieving based on a key returns the value stored
- [x] Successfully returns null for a key that does not exist in the hashtable
- [x] Successfully returns a list of all unique keys that exist in the hashtable
- [x] Successfully handle a collision within the hashtable
- [x] Successfully retrieve a value from a bucket within the hashtable that has a collision
- [x] Successfully hash a key to an in-range value