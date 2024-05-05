// See https://aka.ms/new-console-template for more information
//using SOLID.OCP.Bad;
//using SOLID.OCP.Good;
//using SOLID.OCP.Good2;
//using SOLID.SRP.Good;
//using SOLID.LSPBad;
//using SOLID.LSPGood;

using SOLID.DIPGoodAndBad;

Console.WriteLine("Hello, World!");


//ProductRepository productRepository = new ProductRepository();

//productRepository.GetProducts.ForEach(x =>
//{
//    Console.WriteLine(x.Name);
//});


//ProductPresenter productPresenter = new ProductPresenter();

//productPresenter.WriteToCosole(productRepository.GetProducts);


//SalaryCalculator salaryCalculator = new SalaryCalculator();

//Bad Way
//Console.WriteLine($"Low Salary: {salaryCalculator.Calculate(1000,SalaryType.Low)}");
//Console.WriteLine($"Middle Salary: {salaryCalculator.Calculate(1000,SalaryType.Middle)}");
//Console.WriteLine($"High Salary: {salaryCalculator.Calculate(1000,SalaryType.High)}");

//Good Way
//Console.WriteLine($"Low Salary: {salaryCalculator.Calculate(1000, new LowSalaryCalculate())}");
//Console.WriteLine($"Middle Salary: {salaryCalculator.Calculate(1000, new MiddleSalaryCalculate())}");
//Console.WriteLine($"High Salary: {salaryCalculator.Calculate(1000, new HighSalaryCalculate())}");
//Console.WriteLine($"Manager Salary: {salaryCalculator.Calculate(1000, new ManagerSalaryCalculate())}");

//Good2 Way
//Console.WriteLine($"Low Salary: {salaryCalculator.Calculate(1000, new LowSalaryCalculate().Calculate)}");
//Console.WriteLine($"Middle Salary: {salaryCalculator.Calculate(1000, new MiddleSalaryCalculate().Calculate)}");
//Console.WriteLine($"High Salary: {salaryCalculator.Calculate(1000, new HighSalaryCalculate().Calculate)}");
//Console.WriteLine($"Manager Salary: {salaryCalculator.Calculate(1000, new ManagerSalaryCalculate().Calculate)}");


//Console.WriteLine($"Manager Salary: {salaryCalculator.Calculate(1000, x => { return x * 10; })}");

//BasePhone phone = new IPhone();

//Bad Way
//phone.Call();
//phone.TakePhoto();

//phone = new Nokia3310();
//phone.Call();
//phone.TakePhoto();

////Good Way
//phone.Call();
//((ITakePhoto)phone).TakePhoto();

//phone = new Nokia3310();
//phone.Call();

var ProductService = new ProductService(new ProductRepositoryFromSqlServer());

ProductService.GetAll().ForEach(x => Console.WriteLine(x));
