let mutable x = 1
let mutable y = 2
let z = x + y
printf "%d" z
x <- 3
y <- 4
let z2 = x + y
printf "%d" z2 // z2 will be 7 because it recalculates the sum