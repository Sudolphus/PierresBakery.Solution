# _Pierre's Bakery_

#### _An App For Bread, 7.17.20_
#### By _**Micheal Hansen**_

## Description

_This console app will calculate the price of bread in Pierre's Bakery, including taking into account the current sales Pierre has going on._

## Specifications

| Spec | Input | Output |
| :--- | :---: | ---: |
|Program allows user to specify how many loaves of bread and pastries they would like|3 loaves, 5 pastries|Loaves: {3}, Pastries {5}|
|Program calculates the price of bread, taking the sale into account|3 loaves|Loaves price: $10|
|Program calculates the price of pastries, take the offer into account|5 pastries|Pastries price: $9|
|Program sums the price of bread and pastries, and returns the total to the user|3 loaves, 5 pastries|$19|
|Program allows user to alter the amount of loaves they have ordered|Add 2 loaves| Loaves = {5}, Pastries = {5}|
|Program allows user to alter the amount of pastries they have ordered|Add 3 pastries| Loaves = {5}, Pastries = {8}|
|Program reminds user of sales when they make an order|Add 2 Loaves|"Reminder: Bread is buy 2, get 1 free!"|
|Program reminds user of sales when they make an order|Add 2 Pastry|"Reminder: Pastries are 3 for $5!"|

## Setup/Installation Requirements

Software Requirements
1. .NET framework
2. A code editor (Visual Studio Code, Atom, etc.)
3. A terminal (Windows PowerShell, GitBash, etc.)

Acquire The Repo:
1. Click the 'Clone or Download' Button
2. Alternately, Clone via Bash/GitBash: `git clone {repo}`

Editting the Code Base:
1. Open the project in your code editor; with Bash, this is done by navigating to the project directory, then `code .`
2. If you wish to run testing, you'll need the testing packages: navigate into the PierresBakery.Tests folder, and run `dotnet restore`

Running the program:
1. To run the program, you'll need to navigate into the PierresBakery folder
2. In your console terminal, type `dotnet run`. If .NET is installed properly, the UI should print directly to your console.

## Known Bugs

_None currently known_

## Support and contact details

_Please reach out through my GitHub account._

## Technologies Used

_This project was coded in C# for the Microsoft .NET framework. All programming was done in VS Code, and tracked via Git._