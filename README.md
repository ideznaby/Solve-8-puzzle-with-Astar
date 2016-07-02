# Solve-8-puzzle-with-Astar
The 8-puzzle is a sliding puzzle that consists of a frame of numbered square tiles in random order with one tile missing and player tries to get the tile numbers in some order to finish the puzzle.

This program is solving 8-puzzle with A* algorithm that uses manhattan distances heuristic and shows the answer in a nice graphical way and it's very good for educational purposes.

The code is very simple to develop in C# language.

First I want to share some details about source code of the program and how its written, then I will speak about how the program works.

To download source code and see the details about the program click read more.

 

1 - Source Code:

The source code is written in C# and using Visual Studio 2010. You can see that the solution contains two projects:

1 . Astar :
Astar is a console application that can solve n-puzzle programs and serves as the mind of the program. Here actually I wrote it first and then added the visual part to it later.
Ok now lets go into some details about it. It has 6 classes :
Heap : A min heap that sorts the states with their f score ( the root has always lowest f score ) and it's used for our A* fring (open set) to always get the best node efficiently.
State : A state is the condition of a system in a moment in time. Actually the system goes from an state to another one with its actions. In A* algorithm we set an f score for every state.
f=g+h where h is approximate distance from current state to goal and g is the exact distance we traveled from first state to current state, you can see it as an int attribute in class.
In our program, state is a two dimension array that shows where every tile is. There is also an attribute called lastaction ( shows which action done last to reach this state ) - Kseted ( shows that is this state a valid state or not ) - g ( that shows the manhattan distance between this state to goal ) - parent ( that stores the parent state of current state )
Actions : the actions we can do to an state like moving it to right-left-down-up ( if possible )
Problem : represents currently solving problem its first state its goal and some functions to help solving problem.
Astar : this is where all of the computations done actually its the class that implement A* algorithm and solve the given problem.

2 . Astarvisual : its the graphical interface of the program.

2 -Using The Program:
Using the program is very easy. You only set the first state and goal with drag and drop. Drag the tiles and drop them in the place you want them, "-" represents the empty cell. Then click solve. 
After program solves the problem it will show you the best solution.
Here is some screenshots of the program. Click to see the actual size :
![ScreenShot](/AstarVisual/screenshots/solving.JPG)
![ScreenShot](/AstarVisual/screenshots/solving.JPG)

And it's a video that shows how the program can be used:
https://www.youtube.com/watch?v=eZWOQNPL5L4
