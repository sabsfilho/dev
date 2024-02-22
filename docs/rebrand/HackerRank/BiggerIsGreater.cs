void Main()
{
	var xs = @"ab
bb
hefg
dhck
dkhc".Split('\n');
xs = @"imllmmcslslkyoegymoa
fvincndjrurfh
rtglgzzqxnuflitnlyit
mhtvaqofxtyrz
zalqxykemvzzgaka
wjjulziszbqqdcpdnhdo
japjbvjlxzkgietkm
jqczvgqywydkunmjw
ehdegnmorgafrjxvksc
tydwixlwghlmqo
wddnwjneaxbwhwamr
pnimbesirfbivxl
mijamkzpiiniveik
qxtwpdpwexuej
qtcshorwyck
xoojiggdcyjrupr
vcjmvngcdyabcmjz
xildrrhpca
rrcntnbqchsfhvijh
kmotatmrabtcomu
bnfcejmyotvw
dnppdkpywiaxddoqx
tmowsxkrodmkkra
jfkaehlegohwggf
ttylsiegnttymtyx
kyetllczuyibdkwyihrq
xdhqbvlbtmmtshefjf
kpdpzzohihzwgdfzgb
kuywptftapaa
qfqpegznnyludrv
ufwogufbzaboaepslikq
jfejqapjvbdcxtkry
sypjbvatgidyxodd
wdpfyqjcpcn
baabpjckkytudr
uvwurzjyzbhcqmrypraq
kvtwtmqygksbim
ivsjycnooeodwpt
zqyxjnnitzawipqsm
blmrzavodtfzyepz
bmqlhqndacv
phvauobwkrcfwdecsd
vpygyqubqywkndhpzw
yikanhdrjxw
vnpblfxmvwkflqobrk
pserilwzxwyorldsxksl
qymbqaehnyzhfqpqprpl
fcakwzuqlzglnibqmkd
jkscckttaeifiksgkmxx
dkbllravwnhhfjjrce
imzsyrykfvjt
tvogoocldlukwfcajvix
cvnagtypozljpragvlj
hwcmacxvmus
rhrzcpprqccf
clppxvwtaktchqrdif
qwusnlldnolhq
yitveovrja
arciyxaxtvmfgquwb
pzbxvxdjuuvuv
nxfowilpdxwlpt
swzsaynxbytytqtq
qyrogefleeyt
iotjgthvslvmjpcchhuf
knfpyjtzfq
tmtbfayantmwk
asxwzygngwn
rmwiwrurubt
bhmpfwhgqfcqfldlhs
yhbidtewpgp
jwwbeuiklpodvzii
anjhprmkwibe
lpwhqaebmr
dunecynelymcpyonjq
hblfldireuivzekegit
uryygzpwifrricwvge
kzuhaysegaxtwqtvx
kvarmrbpoxxujhvgpw
hanhaggqzdpunkugzmhq
gnwqwsylqeuqr
qzkjbnyvclrkmdtc
argsnaqbquv
obbnlkoaklcx
ojiilqieycsasvqosycu
qhlgiwsmtxbffjsxt
vvrvnmndeogyp
ibeqzyeuvfzb
sajpyegttujxyx
zmdjphzogfldlkgbchnt
tbanvjmwirxx
gmdhdlmopzyvddeqyjja
yxvmvedubzcpd
soygdzhbckfuk
gkbekyrhcwc
wevzqpnqwtpfu
rbobquotbysufwqjeo
bpgqfwoyntuhkvwo
schtabphairewhfmp
rlmrahlisggguykeu
fjtfrmlqvsekq".Split('\n');


	foreach(var x in xs)
	{
		//FindNext(x.Trim()).Dump();
		biggerIsGreater(x.Trim()).Dump();
	}

//biggerIsGreater("dkhc").Dump();
//hcdk
}
    public static string biggerIsGreater(string w)
    {
        var xs = w.ToCharArray();
        int l = xs.Length - 1;
        int i = l;
        while(i > 0 && xs[i-1] >= xs[i]) //pivot char
        {
            i--;
        }
		if (i > 0)
		{
			i--;
			int j = l;
			while(j >= 0 && xs[j] <= xs[i]) //next char
			{
				j--;
			}			
			char v = xs[j];
			xs[j] = xs[i];
			xs[i] = v; //swap
			int d = l - i;
			if (d > 1) //reverse next chars
			{
				Array.Reverse(xs, i+1, l - i);
			}
	        return new string(xs);
        }
		return "no answer";
    }

static string FindNext(string w)
{
	var r = FindNext(w.ToCharArray(), w.Length, w);
	return r ?? "no answer";
}

static string FindNext(char[] a, int len, string w)
{
	string r = null;
	if (len == 1)
	{
		r = new string(a);
		if (IsGreaterThan(r, w))
		{
			return r;
		}
	}
	else
	{
		
	
		int lasti = len - 1;
		string min = null;
		for(int i=0;i<len;i++)
		{
			r = FindNext(a, lasti, w);
			if (r != null)
			{
				if (
					min == null || 
					IsGreaterThan(min, r)
				)
				{
					min = r;
				}
			}
			if (len % 2 == 0)
			{
				Swap(a, i, lasti);
			}
			else
			{
				Swap(a, 0, lasti);
			}
		}
		return min;
	}
	return null;
}

static bool IsGreaterThan(string r, string w)
{
	if (r == w)
	{
		return false;
	}
	var rs = new string[]{ r, w };
	Array.Sort(rs);
	return rs[1] == r;
}

static void Swap(char[] a, int i, int j)
{
	var t = a[i];
	a[i] = a[j];
	a[j] = t;
}

