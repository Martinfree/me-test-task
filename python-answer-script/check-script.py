"""
A simple python script to check the task for the number of pictures taken by each
"""

P = []

N=int(input("How much images need to edit: "))

for i in range(1,int(input("How many workers: "))+1):
    P.append(int(input("P"+str(i)+"=")))
    
    

#print(P)

def func(number=0):
    p1=2;
    p2=3;
    p3=4;
    
    Nt = [0]*len(P)
    
    T = [0]*len(P)
    for time in range(1000000):
        if sum(Nt)!=N:
            for position in range(0, len(P)):
                if number % P[position] is 0:
                    Nt[position]+= 1;
                    T[position]+=P[position];
            number+=1;
        else:
            print("(In previous order\n)Time:\n{}\nedited:\n{}\n".format(T,Nt));
            return;
        
func()