In this project I learned about Extension Methods in C#:
https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods

Here I tried to figure out best practices and get the general idea of how they work.

Extension methods extend the list type to do syntactic transformations on lists of cards for a made-up card game. 
This is why the project is called EventAlgebra, as its supposed to mathematically map out the space of functions with an algebraic nature. 
Any operation in the space of sets of cards should remain inside the space of sets of cards (mathematical closure). 
Other properties include "shuffling the deck results in the same cards being in the deck" and such. 
If every operation is coded correctly, applying any operation in any order (if its a legal move) should result in the state always being correct (thats the goal atleast). 


Find the extension methods in the MyExtensions.cs class. 
