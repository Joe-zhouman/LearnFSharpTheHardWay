namespace UnitTest_Num2Expression

open System
open Microsoft.VisualStudio.TestTools.UnitTesting

[<TestClass>]
type TestClass () =

    [<TestMethod>]
    member this.Parse0 () =
        Assert.AreEqual("zero",Parse.parse 0)
    [<TestMethod>]
    member this.Parse9 () =
        Assert.AreEqual("nine",Parse.parse 9)
    [<TestMethod>]
    member this.Parse19 () =
        Assert.AreEqual("nineteen",Parse.parse 19)
    [<TestMethod>]
    member this.Parse29 () =
        Assert.AreEqual("twenty nine",Parse.parse 29)
    [<TestMethod>]
    member this.Parse200 () =
        Assert.AreEqual("two hundred",Parse.parse 200)
    [<TestMethod>]
    member this.Parse209 () =
        Assert.AreEqual("two hundred and nine",Parse.parse 209)
    [<TestMethod>]
    member this.Parse299 () =
        Assert.AreEqual("two hundred and ninety nine",Parse.parse 299)
    [<TestMethod>]
    member this.Parse2000 () =
        Assert.AreEqual("two thousand",Parse.parse 2000)
    [<TestMethod>]
    member this.Parse2009 () =
        Assert.AreEqual("two thousand and nine",Parse.parse 2009)
    [<TestMethod>]
    member this.Parse2099 () =
        Assert.AreEqual("two thousand and ninety nine",Parse.parse 2099)
    [<TestMethod>]
    member this.Parse2999 () =
        Assert.AreEqual("two thousand and nine hundred and ninety nine",Parse.parse 2999)
    [<TestMethod>]
    member this.ParseMinus9 () =
        Assert.AreEqual("minus nine",Parse.parse -9)
    [<TestMethod>]
    member this.ParseMinus2900 () =
        Assert.AreEqual("two thousand and nine hundred",Parse.parse 2900)
    //[<TestMethod>]
    //member this.ParseOutOfRange () =
    //    Assert.Fail(Parse.parse 10000)