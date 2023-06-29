namespace Builder
{
    internal class Chef
    {
        private IPizzaBuilder pizzaBuilder;

        public Chef(IPizzaBuilder pizzaBuilder)
        {
            this.pizzaBuilder = pizzaBuilder;
        }

        public void ConstruirPizza()
        {
            pizzaBuilder.SetSize("Big");
            pizzaBuilder.SetTypeDough("Crunchy");
            pizzaBuilder.AddIngredient("Cheese");
            pizzaBuilder.AddIngredient("Jamon");
            pizzaBuilder.AddIngredient("Mushrooms");
        }

        public Pizza GetPizza()
        {
            return pizzaBuilder.GetPizza();
        }

    }
}
