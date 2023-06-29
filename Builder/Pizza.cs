namespace Builder
{
    internal class Pizza
    {
        public string Size { get; set; }
        public string TypeDough { get; set; }
        public List<string> Ingredients { get; set; }

        public void Show()
        {
            Console.WriteLine("Size: " + Size);
            Console.WriteLine("Type Dough: " + TypeDough);
            Console.WriteLine("Ingredients: ");
            foreach (string ingredient in Ingredients)
            {
                Console.WriteLine(" - " + ingredient);
            }
        }
    }
}
