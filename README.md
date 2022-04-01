# Investing Graphs Project

## Project Summary

### Goal

The overall goal of this project was to build the web application that would allow its users to calculate the investments after certain period of time, given the fixed annual % return of their portfolio. For me, a person who utilizes investment calculators, it is important to also have a visual representation of how the funds are accumulated in a user-friendly way. This way, users be more aware how the [Compound Effect](https://www.amgfunds.com/research_and_insights/investment_essentials/practical/the-effect-of-compounding.html) actually works, which can help build them good financial habits. My main source of inspiration was [Smart Asset Calculator](https://smartasset.com/investing/investment-calculator), which you will see why in this project. 

### Languages

1. JavaScript. Used to act as a client for an API calls to send user input and receive the data that was calculated at the server. The received data is being used to update the Bar, Pie charts and Table. 

2. C# (.NET core). The main logic of the application and acts as the server in REST API calls that sends the responses back to a client. Does the calculations in conjuction with Python (see below).   

3. Python. Mainly, being used to do the calculations in the scripts. Python is being called from C# using IronPython that is implementation of Python programming language which is tightly integrated with .NET. 

3.1 I planned to make all calculations on Python to acheive abstraction + use its libraries, so that .NET would be only responsible to act a server.

P.S. Overall, I used the ASP .NET core developer platform, that turned to be really convenient. It was simple to set up and run everything in one environment, in addition to that it allows to integrate foreign functional interfaces, which I used to connect C# and Python. Moreover, Visual Studio had an automatic Docker files support, which saved me time and nerves to quickly run the system inside the docker. 


### Methods of communication

1. REST API calls. Used to connect the the web front-end (JavaScript) and the server(.NET). Handled all the data passed between two nodes.

2. IronPython, language programming intrepreter. Allows to call Python code and functions within the C# files, mostly being used to take advantage of python scripting power. 


### Running the project
Important note: I have only running it on the mac OS. I do not have windows, and CSIL linux were unavalaible. So, I think the mac should works

- download the project and navigate to a suitable location. or simply do:
```sh
$ git clone https://github.com/arsenkhy/investing-calculator.git
```
and then
```sh
$ cd investing-calculator
```
- start the application using docker-compose like this
```sh
$ docker-compose build && docker-compose up
```
- Open your favorite browser and type 
```sh
https://localhost:9000/
```
- Check it out and close whenever you want

### Interesting features

- Inputs different values, Eg. monthly, annualy
- Bar chart and Pie chart, move your mouse
- Input the value, and just press enter, no need to refresh
- Table of years,
- Tap rectangles on the right from the pie chart 






