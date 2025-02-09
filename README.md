# F# Mutable Variable Bug

This example demonstrates a common pitfall in F# when working with mutable variables and functions.  The `add` function calculates the sum of `x` and `y` initially.  However, subsequent changes to `x` and `y` do not affect the value of `z` because `z` is calculated only once.