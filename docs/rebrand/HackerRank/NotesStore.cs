void Main()
{
	var xs = @"AddNote active DrinkTea
AddNote active DrinkCoffee
AddNote completed Study
GetNotes active 
GetNotes completed
GetNotes foo
".Split('\n').Select(x=>x.Split(' '));
foreach(var w in xs)
{
	var a = w[0];
	var state = w[1];
	var name = w.Length < 3 ? string.Empty : w[2];
	var n = new NotesStore();
	if (a == "AddNote"){
		n.AddNote(state, name);
	}
	else if (a == "GetNotes"){
		n.GetNotes(state).Dump();
	}
}
}
// Define other methods and classes here
public class NotesStore
{
	class Note
	{
		public string State { get; set; }
		public string Name { get; set; }
	}
	private string[] states = "completed,active,others".Split(',');
	private List<Note> notes = new List<Note>();
    public NotesStore() {}
    public void AddNote(String state, String name) {
	
		if (string.IsNullOrEmpty(name)){
			throw new Exception("Name cannot be empty");
		}
		
		if (!states.Contains(state)){
			throw new Exception(string.Concat("Invalid state ", state));
		}
	
		var n = new Note();
		n.State = state;
		n.Name = name;
		notes.Add(n);
	}
    public List<String> GetNotes(String state) {
		
		if (!states.Contains(state)){
			throw new Exception(string.Concat("Invalid state ", state));
		}
		
		return
			notes.Where(x=>x.State == state).Select(x=>x.Name).ToList();
	}
} 

