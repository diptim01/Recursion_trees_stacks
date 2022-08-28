# What is Recursion? 
It is a function that calls itself.

# When do we use Recursion?
To break down bigger problem into smaller problems. Never about the input.<br />
> 5 -> 4 -> 3 -> 2 -> 1


###Key points
> - smaller problems

> - Visualisation through a recursive tree.

![Single Recursion tree](images/Recursion_tree.jpeg)

> - Memory usage when we call a function (Recursion stack)
<p> For every recursive function call, there is a stack generated for it!</p>

![Memory stacks](images/Memory.jpeg)

We deallocate only when the function call has been successfully done!

> Base Condtion
<p> Without this, this stack will get FULL and we get *STACKOVERFLOW*</p>

> Recurrence Relation
<p> Mathematical representation of the recursion </p>