namespace PhoneBook.Entities
{
    public class Note : IEntity
    {
        public Guid Id { get; }
        public string Name { get; }
        public string Number { get; }
        public Note(Guid id, string name, string number)
        {
            Id = id;
            Name = name;
            Number = number;
        }
    }
}
