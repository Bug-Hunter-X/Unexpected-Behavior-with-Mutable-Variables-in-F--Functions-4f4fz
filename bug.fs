let mutable x = 10
let mutable y = 20

let add x y = x + y

let z = add x y

printf "%d\n" z //This will print 30

x <- 15
y <- 25

printf "%d\n" z //This will still print 30, not 40 because z is not updated when x and y change.