
namespace SystemTest

open Microsoft.VisualStudio.TestTools.UnitTesting
open System

[<TestClass>]
type ThornTest() =

    [<TestMethod>]
    member x.TestDefault() =
        Assert.IsFalse <| "TH".StartsWith "Þ" // fail

    [<TestMethod>]
    member x.TestCurrentCulture() =
        Assert.IsFalse <| "TH".StartsWith("Þ", StringComparison.CurrentCulture) // fail

    [<TestMethod>]
    member x.TestOrdinal() =
        Assert.IsFalse <| "TH".StartsWith("Þ", StringComparison.Ordinal) // pass