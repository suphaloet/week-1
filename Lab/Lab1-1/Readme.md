# Instruction

## Read and understand the code, the logic behind it, the limitation of it
* Answer the question 1 - 4 below (you can edit this file directly)
* Change the code such that it will sort from larger to smaller, put the revision of your code below
* Change the code such that there is no flag variable, put the commit number below and answer question 5 

#Name
Suphaloet Vongkunkij
570611036

## Revision, put your commit number here
* Sort from larger to smaller:3dc8127b
* Without flag:7f63e67e 

## Questions
1. How this code can sort number from smaller to larger
 
Answer:  This code is BubbleSort code. When input[i] > input[i+1] it will swap number.

2. What if two numbers equal, what will happen? 

Answer: No swap number in input[i] and input[i+1].

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: 27 times for smaller to larger and 15 times for larger to smaller.

4. Why we need flag variable ? 

Answer: Because we need flag to check for run out of while loop. When flag is flase it will be out while loop.

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: When we remove the flag variable and don't fix code, this code will be error because we use the flag variable for check while loop. If we remove the flag variable and while loop, this code will run faster but we romove only the flag variable and fix this code it will run same time or slower we use the flag variable.