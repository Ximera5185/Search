namespace Search
{
    internal class Сriminal
    {
        public Сriminal(string fullName, int height, int weight,string nationality, bool isDetained)
        {
            FullName = fullName;
            Height = height;
            Weight = weight;
            this.isDetained = isDetained;
            Nationality = nationality;
        }

        public string Nationality { get; private set; }
        public string FullName { get; private set; }

        public int Height { get; private set; } 
        public int Weight { get; private set; } 

        public bool isDetained { get; private set; }
    }
}
