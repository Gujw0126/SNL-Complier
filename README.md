# SNL-Complier
A compier for SNL implemented with C#, including token analysis, grammar
analysis and semantic analysis.
![image_error](https://github.com/Gujw0126/SNL-Complier/blob/main/image/compiler1.png)
1. token analysis
Input SNL code and click 'start analysis', the result will comeout on the right. 
The program will use a DFA to analise tokens. Token type includes ID, unsigend int(INTC), EOF ...
![image_error](https://github.com/Gujw0126/SNL-Complier/blob/main/image/compiler2.png)


2. grammar analysis
After token analysis, turn to grammar analysis page and click 'start analysis'. 
The program will use Recursive-Descent Parsing to build grammar tree.
output: grammar error information and grammar tree.
![image_error](https://github.com/Gujw0126/SNL-Complier/blob/main/image/compiler3.png)

3. semantic analysis
After grammar analysis, turn to semantic analysis page and click 'start analysis'. 
The program will check semantic error (redefination, array_out_of_range...) and 
build symbol table.
![image_error](https://github.com/Gujw0126/SNL-Complier/blob/main/image/compiler4.png)