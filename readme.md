# Geometry

This is a library of geometric primitives, created for the purpose of demonstrating unit testing.

## Introduction

Imagine the code presented here is a library you've written for use at your company, GeoPerfect. It's meant to describe geometric primitives. It's going to be used
by products your company builds to apply geometric principles to stuff. There's a high priority on correctness. So, for the first time, you're going
to implement unit tests.

And not a moment too soon. You check in a very early version of your code and, during a PR review, another developer says, "I don't think your 
formula for the distance between two points is correct. I'm getting some weird results."

To see the code in question, clone this repo and checkout the v1.0.0_untested tag.

## Basic testing

To prove the correctness of your code, you decide to write some unit tests. And, since all the other unit tests you've seen at GeoPerfect are written
using XUnit.net, you've decided to use that framework. Additionally, to have cleaner, more intuitive assertions, you've decided to use the Fluild 
Assertions library.


