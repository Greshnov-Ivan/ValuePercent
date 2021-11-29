using test;

BudgetLogic budgetYear = new BudgetLogic();
budgetYear.Paid.Value = 23.2;
budgetYear.Cost.Value = 100;
budgetYear.RunRate.Value = 20;

Console.WriteLine($"Бюджет: {budgetYear.Total}руб.");
Console.WriteLine($"Затраты: {budgetYear.Paid.Value}руб. - {budgetYear.Paid.Percent}%");
Console.WriteLine($"Остаток: {budgetYear.Cost.Value}руб. - {budgetYear.Cost.Percent}%");
Console.WriteLine($"RanRate: {budgetYear.RunRate.Value}руб. - {budgetYear.RunRate.Percent}%\n");

budgetYear.Paid.Value = 18;
budgetYear.Cost.Value += 2.2;
budgetYear.RunRate.Value += 39.9;

Console.WriteLine($"Бюджет: {budgetYear.Total}руб.");
Console.WriteLine($"Затраты: {budgetYear.Paid.Value}руб. - {budgetYear.Paid.Percent}%");
Console.WriteLine($"Остаток: {budgetYear.Cost.Value}руб. - {budgetYear.Cost.Percent}%");
Console.WriteLine($"RanRate: {budgetYear.RunRate.Value}руб. - {budgetYear.RunRate.Percent}%");

Console.ReadKey();
