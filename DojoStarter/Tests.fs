module Tests

open NUnit.Framework
open FsUnit

open Dojo

let [<Test>] ``convert s to f`` () =
    encodeChar 's' |> shouldEqual 'f'

let [<Test>] ``from ascii to alphabet number for letter a`` () =
    alphabetBasedNumber 97 |> shouldEqual 0

let [<Test>] ``from ascii to alphabet number for letter z`` () =
    alphabetBasedNumber 123 |> shouldEqual 26

let [<Test>] ``convert sample string`` () =
    encodeStr "sample" |> shouldEqual "fnzcyr"