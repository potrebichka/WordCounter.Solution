# _Word Counter Console App_

#### _Version 12/20/2019_

#### By _**Nina Potrebich**_

## Description

_A console app that checks how frequently the word appears in the sentence._

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

* .NET

### Installing

1. Clone this repository:
```
$ git clone url-of-this-repo
```
2. Using console of your choice build and run program in Project directory:
```
dotnet build 
dotnet run
```
3. For Unit testing restore and run tests in Project.Tests repository:
```
dotnet restore
dotnet test
``` 

## Specifications:
* User gets welcome message.
* User prompt to enter a sentence. 
* User prompt to enter a word.
* User gets how many times the word appears in the sentence.
* User is able to repeat process.
* User is able to quit the program.

*Valid input types* : letters, digits, {nothing}, punctuation.

| User Input / sentence | User Input / word | Output |
|---|---|---|
| Just a plain sentence | cat | 0 |
| A cat sentence with a cat | cat | 2 |
| Cat hates dog | cat | 1 |
| A sentence with a cathedral | cat | 0 |
| A cat sentence with a cathedral | cat | 1 |
| {nothing} | {nothing} | 0 |
| Some sentence | {nothing} | 0 |
| {nothing} | word | 0 |


## Technologies Used

_C#, .NET_

### License

*_Copyright (c) 2019 **Nina Potrebich**_*