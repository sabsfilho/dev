void Main()
{
string.Join(System.Environment.NewLine,
	Directory.GetDirectories(@"C:\Users\Owner\Projects\sam\dev\docs\rebrand\FreeCodeCamp\Certification\ResponsiveWebDesign")
	.Select(x=>x.Split('\\').Last())
	.Select(x=>string.Concat(
	"{k:'",
		x,
	"',n:'",
	x,
	"',tags:'HTML5,CSS,SCSS,Flexbox,CSS Grid",
	"',d:'",
	"'},")		
		)).Dump();
	
}
