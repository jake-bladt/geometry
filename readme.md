# Geometry

This is a library of geometric primitives, created for the purpose of demonstrating unit testing.

## Introduction

Imagine the code presented here is a library you've written for use at your company, GeoPerfect. It's meant to describe geometric primitives. It's going to be used
by products your company builds to apply geometric principles to stuff. There's a high priority on correctness. So, for the first time, you're going
to implement unit tests.

And not a moment too soon. You check in a very early version of your code and, during a PR review, another developer says, "I don't think your 
formula for the distance between two points is correct. I'm getting some weird results. Plus, it doesn't dispay right."

To see the code in question, clone this repo and checkout the v1.0.0_untested tag.

## Basic testing

To prove the correctness of your code, you decide to write some unit tests. And, since all the other unit tests you've seen at GeoPerfect are written
using XUnit.net, you've decided to use that framework. Additionally, to have cleaner, more intuitive assertions, you've decided to use the Fluild 
Assertions library.

Because you are using a modern version of Visual Studio, you already have XUnit.net and its runners installed. If you
were using an older version of Visual Studio, you might have to follow the instructions on [Getting Started with with
XUnit.net and Visual Studio](https://xunit.github.io/docs/getting-started/netfx/visual-studio).

To add tests, create a separate project. Because this library is written in .net core, you choose an "XUnit.net test project"
under the "dotnet core" subgroup, but similar projects exist for other platforms. Once it's created, you add the 
FluentAssertions library to your test project via nuget.

Tackling the display issue first, you review the code in question and realize that the other developers on the team
are passing Cartesian points into interppolated strings, a process which converts them to strings by calling ToString().
You hadn't planned on them being used that way, but it makes sense. To fix this, you will need to override ToString() 
in your class.

You decide to write the test of this functionality and then the functionality. You could do this the other way around,
but you like the sanity check of a failing test before fixing a bug. To do this, you add the following test class to
your test project:

``` c#
using FluentAssertions;
using Xunit;

using Geometry;

namespace Geometry.Tests
{
    public class CartesianPointTests
    {
        [Fact]
        public void ConvertsToString()
        {
            var origin = new CartesianPoint { x = 0, y = 0 };
            var str = origin.ToString();
            str.Should().Be("(0, 0)");
        }
    }
}
```

As expected, this test fails when you run it. Now, you override the function and try again. This time, the test fails
because you forgot to put a space in between the comma and the y coordinate. Fortunately, nobody saw this mistake and,
even more fortunately, the feature didn't go out to QA like that. Had it done so, it might be days before you finally
got the fix right. This is one of the most immediate benefits of unit testing. If you can catch silly mistakes in
development, you save everyone's time.
