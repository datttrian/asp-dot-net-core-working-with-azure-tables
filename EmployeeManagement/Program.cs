using EmployeeManagement.Data.Common;

Common.CreateTableAsync("test").GetAwaiter().GetResult();
Console.ReadKey();
