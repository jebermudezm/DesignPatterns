namespace Builder
{
    internal class PizzaBuilder : IPizzaBuilder
    {
        private Pizza pizza;

        public PizzaBuilder()
        {
            pizza = new Pizza();
        }

        public void SetSize(string size)
        {
            pizza.Size = size;
        }

        public void SetTypeDough(string typeDough)
        {
            pizza.TypeDough = typeDough;
        }

        public void AddIngredient(string ingredient)
        {
            if (pizza.Ingredients == null)
            {
                pizza.Ingredients = new List<string>();
            }
            pizza.Ingredients.Add(ingredient);
        }

        public Pizza GetPizza()
        {
            return pizza;
        }
    }
}
