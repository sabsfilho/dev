void Main()
{
/*
	var xs = @"2000000000
4
9
16
25
36
49
64
81
100
121
144
169
196
225
256
289
324
361
400
441
484
529
576
625
676
729
784
841
907".Split('\n');

var rs = @"Not prime
Not prime
Not prime
Not prime
Not prime
Not prime
Not prime
Not prime
Not prime
Not prime
Not prime
Not prime
Not prime
Not prime
Not prime
Not prime
Not prime
Not prime
Not prime
Not prime
Not prime
Not prime
Not prime
Not prime
Not prime
Not prime
Not prime
Not prime
Not prime
Prime".Split('\n');
*/

var xs = @"1000000000
1000000001
1000000002
1000000003
1000000004
1000000005
1000000006
1000000007
1000000008
1000000009".Split('\n');

var rs = @"Not prime
Not prime
Not prime
Not prime
Not prime
Not prime
Not prime
Prime
Not prime
Prime".Split('\n');

for(int i = 0; i < xs.Length; i++){
	var r = IsPrime(int.Parse(xs[i])) ? "Prime" : "Not prime";
	if (r != rs[i].Trim()){
	string.Concat(xs[i],"=",rs[i]).Dump();
		return;
	}
}

}


static bool IsPrime2(int n){
    if (n == 1){
        return false;
    }
	for(int i=2;i <= Math.Sqrt(n);i++){
		if (n % i == 0) {
			return false;
		}
	}
	return true;
}
