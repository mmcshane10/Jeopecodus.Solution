# _Jeopicodus_

#### _Play Jeopardy to learn your epicodus curriculum. {11/6/2019}_

#### By _**Christine Frank, Mike McShane, Chris Burge, and Devin Cooley**_

## Description

_The purpose of this application is to allow two teams to compete at the game of jeopardy, from two different monitors, simultaneously. The game board is populated with questions taken directly from the epicodus curriculum, making learning easy and fun!_  

## Specifications
* #### Authentication
| Spec                      |Input          | Output |
|:---------------------------|:-------------|:------|
|Allows a user to create a profile.| Name: John, email: email@a.com, etc| New user John|
|Allows a user to login| Name: John, PassWord: ******| Welcome John!|
|Only allows user access to game if logged in|`Not Logged In`| `Reroute to Login`| 

* #### Game Initialization
| Spec                      |Input          | Output |
|:---------------------------|:-------------|:------|
|Allows the user to create a new game |`New Game`| _Creates new game and adds user to game._|
|Allows user to Join a Game that has already been created_|`Join Game`|_Adds user to game._
|Initializes the game with all users assigned to it| `Game Start`| _LETS PLAY JEOPARDY!_  

* #### Game Play
| Spec                      |Input          | Output |
|:---------------------------|:-------------|:------|
|Displays the game board for all teams|


## Setup/Installation Requirements
_Simply run this application in your browser. Create a user, log in, and join or create a game to start playing. Communicate with a friend to join in the same game from different clients and play together live._

## Known Bugs

_There are no known bugs at this time._

## Support and contact details

_Send any questions or comments to:
Christine Frank at   
Chris Burge at   
Mike McShane at   
Devin Cooley at dcooley1350@gmail.com._

## Technologies Used

_This is a .NET Core MVC application written primarily in C#. JavaScript, HTML and CSS were implemented alongside C#. Databasing was accomplished with Mysql, assisted by Entity Framework. Authorization was handled using Identity for .NET Core. This app features live data rendering with use of SignalR for .NET. View this application in your browser or another client.

### License

*This software is licensed under the MIT license.*

Copyright (c) 2019 **_Devin Cooley, Christine Frank, Chris Burge, Mike McShane_**