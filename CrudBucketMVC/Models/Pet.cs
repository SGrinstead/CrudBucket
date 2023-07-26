namespace CrudBucketMVC.Models
{
	public class Pet
	{
		public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }
        public Owner Owner { get; set; }
    }
}
