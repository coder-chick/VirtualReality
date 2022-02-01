# Lab 1 - Vector Motion
#### Author: Semaa Amin


1. To calculate intervening points you can simply calculate the translation vector and divide by 10 and add this to the initial start position and so on. But what if the loop iterates indefinitely and the input is a direction vector (a vector that simply shows the direction the object is moving)? How would you calculate the intermediate positions if you don't know the destination (or how long the object will travel)?
  - You would calculate the velocity of the object in each vector direction (i.e. x,y,z) to determine the position of the object as a function of time.

2. You can use simple arrays to do this problem, but you can also use a vector math library (which was optional), why or why not did you use a library?

  - I did not use a vector math library because for the purposes of this assignment, I felt like it is important to understand how to derive the vector positions of a given object from scratch. In Unity, to my understanding, many of these calculations are easily found in the api such as Vector3.distance() and the use of rigidbody simulations. Knowing how this functionality works is very useful when errors or unexpected collision issues resulting from vectors arise.
