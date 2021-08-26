```
A job of 1000 images is going to be edited by a crew of 3 people:

        · P1: 1 image per 2 minutes

        · P2: 1 image per 3 minutes

        · P3: 1 image per 4 minutes

1. How long will this job take in total?

2. How many images will be edited by every person?
```

I have two solutions for this task:

- construction of the relation to the fixed time

In this case we need to construct a system of equations:

```
P1: x1 minute/img = N1/t (img/min)<br>
. . .<br>
PN: xn minute/img = Nn/t (img/min)
```

Nn- number of processed images by worker for a fixed time t

x1+x2+...+xn= Sum(x1...xn) => σ*x1+x2+...+xn, σ=N/Sum(x1...xn)

Number of images by every worker for N images: σ*xn
Time that every worker spent: (σ*xn)*xn


<details on>
<summary>Answer:</summary><br>
1000 images total

P1: 2 minute/img = 500/1000 (img/min)<br>
P2: 3 minute/img = 333,3/1000 (img/min)<br>
P3: 4 minute/img = 250/1000 (img/min)<br>

500 + 333,3 + 250 = 1083,3 => σ=1000/1083,3=0,923105

σ*500 + σ*333,3 + σ*250 = σ*1000 => 461 + 308 + 231 = 1000

</details><br>


-  solving by the formula

Folowing algorithm works like this:

Find least common multiple for all worker speed

C/x1+C/x2+...+C/xn = σ/C [images/min] - number of images edited at constant minute by all workers together.

N/σ*C/x1+N/σ*C/x2+...+N/σ*C/xn = N

<details on>
<summary>Answer:</summary><br>
1000 images total

P1: 2 minute/img <br>
P2: 3 minute/img <br>
P3: 4 minute/img <br>

least common multiple for 3 workers: 12

12/2 + 12/3 + 12/4 = 13/12 [img/min]

(1000/13)*(12/2) + (1000/13)*(12/3) + (1000/13)*(12/4) = 1000 =>
=> 461 + 308 + 231 = 1000

</details><br>

# P.S

For all of algorithms round to upper only if after integer > 0.6 else round down
