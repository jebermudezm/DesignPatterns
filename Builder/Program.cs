using Builder;

IPizzaBuilder pizzaBuilder = new PizzaBuilder();

Chef chef = new Chef(pizzaBuilder);
chef.ConstruirPizza();
Pizza pizza = pizzaBuilder.GetPizza();

pizza.Show();
