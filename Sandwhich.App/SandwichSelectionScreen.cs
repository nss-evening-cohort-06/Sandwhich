namespace Sandwhich.App
{
    public class SandwichSelectionScreen
    {
        readonly Sandwich _sandwich = new Sandwich();

        public void AddTomatoes(int numberOfTomatoes)
        {
            _sandwich.Tomatoes += numberOfTomatoes;
        }

        public Sandwich BuildSandwich()
        {
            return _sandwich;
        }

        public void AddOnions()
        {
            _sandwich.Onions = true;
        }
    }

    public class Sandwich
    {
        public int Tomatoes { get; set; }
        public bool Onions { get; set; }
    }
}
