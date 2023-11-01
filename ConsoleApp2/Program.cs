using TestTask;

var repository = new NumbersRepository(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 });

var rules = new List<Number> {
                new Number("dog", 3),
                new Number("cat", 5),
                new Number("muzz", 4),
                new Number("guzz", 7)
            };

var numberReplacer = new NumberReplacer(repository.InputNumberList, rules);

ICommand printCommand = new PrintCommand(numberReplacer);

printCommand.Execute();

Console.ReadKey();
