void Main()
{
	var table = new HashTableDSA(10);
	table.Put(105, "Tim");
	table.Put(21, "Sana");
	table.Put(21, "Harry");
	
	table.Get(21).Dump();
	
	table.Remove(21);
	
	table.Dump();
}

class HashTableDSA {

	public class HashNode {
		public int Key { get; set; }
		public string Value { get; set; }
		public HashNode Next { get; set; }
		
		public HashNode(int key, string value) {
			this.Key = key;
			this.Value = value;
		}
	}
	
	public HashNode[] buckets;
	int numberOfBuckets;
	int size;
	
	public HashTableDSA(int capacity) {
		numberOfBuckets = capacity;
		buckets = new HashNode[numberOfBuckets];
		size = 0;
	}
	
	public int Size {
		get{
			return size;
		}
	}
	
	public bool IsEmpty {
		get{
			return size == 0;
		}
	}
	
	int GetBucketIndex(int key) {
		return key % numberOfBuckets;
	}
	
	public void Put(int key, string value) {
		int bucketIndex = GetBucketIndex(key);
		var head = buckets[bucketIndex];
		while(head != null){
			if (head.Key.Equals(key)) {
				head.Value = value;
				return;
			}
			head = head.Next;
		}
		size++;
		head = buckets[bucketIndex];
		var node = new HashNode(key, value);
		node.Next = head;
		buckets[bucketIndex] = node;
	}
	
	public string Get(int key) {
		int bucketIndex = GetBucketIndex(key);
		var head = buckets[bucketIndex];
		
		while(head != null){
			if (head.Key.Equals(key)) {
				return head.Value;
			}
			head = head.Next;
		}	
	
		return null;
	}
	
	public string Remove(int key) {
		int bucketIndex = GetBucketIndex(key);
		var head = buckets[bucketIndex];
		HashNode prev = null;
		while(head != null){
			if (head.Key.Equals(key)) {
				break;
			}
			prev = head;
			head = head.Next;
		}
		if (head == null) return null;
		size--;
		if (prev == null) {
			buckets[bucketIndex] = head.Next;
		}
		else {
			prev.Next = head.Next;
		}
		return head.Value;
	}
}