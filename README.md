# Reports-Creator
A simple software written in C# to generate reports for start and stop times

# Purpose

This software's purpose is to generate a missing reports file (xlsx) to have a report of participants, of an online lesson (eg. University )
The software is replicating the zoom's reporting system.

The first line is used for "professor" or "tutor" and it auto-adds a "@email.gr" to replicate a email of login.
The other GUESTS is not meant to have an email , and the value GUEST is 'YES'
 

# Usage
Firstly type in the left textbox all the participants you want to be participate. 

Afer that in the right you can select the start and stop date, and time

About time selection you have to keep in mind that the software auto-generates random times from the start time +15 minutes and finish time +15 minutes

After all have fields been filled then you should select "OUTPUT" folder.

Finally you can click on "Generate"


![Reports-Creator1](https://github.com/vagvalas/Reports-Creator/assets/19560574/acba4797-a08b-4630-b03c-94b72b626042)
(First one goes for "TUTOR")

those are generated excels.

![Reports-Creator2](https://github.com/vagvalas/Reports-Creator/assets/19560574/01bc2d5b-c80c-499a-8a0b-886948f7f64e)


and these are the actual reports 

![Reports-Creator3](https://github.com/vagvalas/Reports-Creator/assets/19560574/fb8e7c7b-b2ec-4e16-99d3-d8fd65f1e18e)


# To be added
1. A way to change the @email for tutor instead of hard-coded inside
2. A progress bar for big duration dates so to know when the generation is done
3. Later in future to add a way so it generate diffent names for different durations (maybe with an input file)

Feel free to make any pull requests.
