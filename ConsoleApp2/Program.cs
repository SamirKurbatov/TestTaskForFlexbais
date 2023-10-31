var repository = new NumbersRepository(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420);


var numbers = new List<Number>()
{
    new Number(replacedWord: "dog",reason: 3),
    new Number(replacedWord: "cat", reason: 5),
    new Number(replacedWord: "muzz", reason: 4),
    new Number(replacedWord: "guzz", reason: 7),
};

var resultNumbers = repository.GetNumbers(numbers);

ICommand printCommand = new PrintCommand<string>(resultNumbers);

printCommand.Execute();

Console.ReadKey();
