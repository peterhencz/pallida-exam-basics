'use strict';
// Create a function called `uniqueCharacters` that takes a string as parameter
// and returns a list with the unique letters of the given string
// Create basic unit tests for it with at least 3 different test cases
//System.out.println(uniqueCharacters("anagram"));
// Should print out:
// ["n", "g", "r", "m"]

function uniqueCharacters (text: string): string[] {
  text.toLowerCase;
  let textArray: string[] = [];
  textArray = text.split('');
  return textArray;

}

console.log(uniqueCharacters('kiskacsa'));
