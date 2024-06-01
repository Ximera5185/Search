namespace Search
{
    internal class Сriminal
    {
        public Сriminal(string fullName, int height, int weight,string nationality, bool detained)
        {
            FullName = fullName;
            Height = height;
            Weight = weight;
            Detained = detained;
            Nationality = nationality;
        }

        public string Nationality { get; private set; }
        public string FullName { get; private set; }

        public int Height { get; private set; } 
        public int Weight { get; private set; } 

        public bool Detained { get; private set; }
    }
}
