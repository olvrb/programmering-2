namespace netflix.Elements.Shows {
    public class Episode {
        public Episode(string name, string description, int length) {
            Length = length;
            Name = name;
            Description = description;
        }

        public int Length { get; }
        public string Name { get; }
        public string Description { get; }
    }
}