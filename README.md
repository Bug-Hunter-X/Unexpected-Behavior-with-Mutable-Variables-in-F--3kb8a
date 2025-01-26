# F# Mutability Bug

This example demonstrates a common misconception when working with mutable variables in F#.  The seemingly simple calculation using mutable variables does not update when the mutable values are changed after their initial use.

## How to Reproduce

1. Compile and run `bug.fs`.
2. Observe that the value of `z` remains unchanged, even after `x` is modified.

## Solution

The solution is to re-calculate `z` whenever the dependent mutable variables change.  See `bugSolution.fs` for an example.