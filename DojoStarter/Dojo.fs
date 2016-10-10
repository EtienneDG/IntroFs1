module Dojo

// Here you should write your dojo/exercise logic

let isThisReallyTrue x = x

let alphabetBasedNumber x = x - int 'a'
let asciiBasedNumber y = y + int 'a'
let mod26 z = z % 26
let isPositive (x, y) = abs(x-y) > 0 
let turnAround x y  = if isPositive (x,y) then x - y else (25 - x - y)

let encode (c:char) = 
    int c + 13 
    |> alphabetBasedNumber 
    |> mod26

let decode (c:char) = 
    int c - 13 
    |> alphabetBasedNumber 
    |> mod26

let encodeChar mychar = 
    encode mychar
    |> asciiBasedNumber 
    |> char

let decodeChar mychar = 
    int mychar - 13 
    |> alphabetBasedNumber 
    |> mod26
    |> asciiBasedNumber 
    |> char

let encodeStr (s:string) = 
    s.ToCharArray()
    |> Array.map encodeChar
    |> System.String

