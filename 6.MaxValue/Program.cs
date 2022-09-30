int v1 = 25;
int v2 = 60;
int v3 = 72;
int v4 = 27;
int v5 = 11;

int max = v1;

if(max < v2) max = v2;
if(max < v3) max = v3;
if(max < v4) max = v4;
if(max < v5) max = v5;

Console.WriteLine(string.Format("Maximum value is {0}", max));