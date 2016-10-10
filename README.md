F# Introduction
===============

Principal characterisitcs
-------------------------
*Higher order functions*: Functions that takes functions as parameters  
*High type infererence* but language is strongly typed  
*Conciseness* : no semi-colon needed, very few curly brackets  
*Convenience* : equals on object is value-based (auto override of Equals)
*Immutable* : everything is immutable.  
- Example: with a dictionnary, a new dictionnary is created for each added key

*``` Everything is an Expression (Whereas in C# we have both Expression and Instruction)```*

As in Python *indentation* defines scope. 
However there is no predefined number of spaces to change scope.
Using 'Tab' will prevent compilation (unless Tab is converted to whitespaces).

Linq with its Expressions and tree creation and browsing is conceptually close to Functional programming.


Syntax
------
```fsharp
let aValue = "this is a string" //this is a comment
```

Symbol `=` is equality comparotor (`==`).
Variables are immutable by default (except arrays): 
```fsharp
let a = 1
a = 2 //false
let mutable b = 1
b = 2 //false
b <- 2 //assigns 2 in b 
```

Tuples
```fsharp
let aTuple = (1,2)
let tuple1stVal,tuple2ndVal = aTuple //easily deconstructing a tuple
let _, onlyLastValue = aTuple //the underscore is a used to ignore values, it's a reserved var name
```

List are simple chained lists
```fsharp
let aList = [1;2;3]
let anotherList = 1 :: 2 :: 3 :: []
let areListEqual = (aList = anotherList) //true
```

Arrays are tge basic .NET arrays => they are mutable
```fsharp
let arraySyntax = [|1;2;3|]
```

Loops 
```fsharp
let products = [|
    for i in array1 do
    yield i
 |]
```

Functions 
```fsharp
let format (contryName, population) = 
    sprintf "%s has a total population of %d" countryName, population

let add x y = x + y
let add2 (x, y) = x + y //those two functions are not exactly the same

//the difference lies in the way the functions are composed
let add' =
    fun x ->
        fun y -> x + y //a function always takes only parameter (currying)
let add2' =
    fun xAndY ->
        let x,y = xAndY //creation of a tuple
        x + y
```
Functions can be **applied 'partially'** (with not all needed parameters).
Functions can also be **piped** with '|>'.  
Both partial application and piping can be combined (and are often used like this).

It's also possible to compose functions with '>>'.  


Typing in F#
------------
**Record type** are simple objects.
These "can't" be null (you can't assign null to a var of a record type type).

```fsharp
type Country = {
    Name : string,
    CapitalCity : string
}

let franceAsRecord = {
    Name = "France",
    Population = 66000000
}

//New instance. 
//Creates a shallow copy. 
//The rest of the object properties are the same (ref) as the first object
let alternateFrance = {franceAsRecord with Name = "AltFrance"}
```

```There are  no anonymous types in F#```  

**Unions** (discriminated union) are like enum but better 
- only the available values of the union are possible
- they can embed values (possibly of different types)

**Options** special type of Unions. They can be used to declare a variable that is null.
```fsharp
type Option<'a> =       // use a generic definition  
    | Some of 'a        // valid value
    | None              // missing
```

