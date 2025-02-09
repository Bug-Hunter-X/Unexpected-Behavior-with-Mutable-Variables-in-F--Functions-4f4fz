let mutable x = 10
let mutable y = 20

let add x y = x + y

let mutable z = add x y

printf "%d\n" z //This will print 30

x <- 15
y <- 25
z <- add x y // Update z explicitly

printf "%d\n" z //This will now print 40