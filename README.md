# motivation

I built a simulation of the solar system and animated it in Plotly. 
then I built it in CSharp and animated it in OxyScope

Next i built a galaxy simulation in csharp and animated it with OxyPlot.

Then , i ported the simulation to Unity, and couldn't find my stars.
After much rummaging around and wondering why the locations were off , it occurred to me that Unity uses 32 digit floating point arithmetic, which is fine for day-to-day use, but, when we are streching our 100s of parsecs, it seems that it fall short.

Time to rebuild some simulations using high precision or arbitrary precision libraries. 
Thought I'd make this a journal project and open source it. 

Kind regards, 

Credit to: Adam White for his libraries at:  https://github.com/AdamWhiteHat/BigDecimal
Fascinating stuff Adam.  Nicely done.


