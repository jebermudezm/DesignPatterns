using Composite;

Composite.Composite root = new Composite.Composite("Root");
root.Add(new Leaf("Leaf 1"));
root.Add(new Leaf("Leaf 2"));

Composite.Composite composite = new Composite.Composite("Composite");
composite.Add(new Leaf("Leaf 3"));
composite.Add(new Leaf("Leaf 4"));

root.Add(composite);

root.Display(1);
