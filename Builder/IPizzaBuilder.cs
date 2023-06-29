namespace Builder
{
    internal interface IPizzaBuilder
    {
        void SetSize(string size);
        void SetTypeDough(string typeDough);
        void AddIngredient(string ingredient);
        Pizza GetPizza();
    }
}
