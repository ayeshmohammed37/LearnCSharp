
Manager m1 = new Manager();
m1.Salary = 1000m;
m1.WorkingHours = 5;
m1.Employees = new Employee();
m1.Employees.Id = 1;
m1.Employees.Name = "Test";
m1.Employees.Position = "testPos";

Manager m2 = m1.Clone();

m1.Employees.Name = "new Name";

Console.WriteLine(m2.Employees.Name);