using task3;

var user = new User("Aliakei", true, true);
IBook book = new BookProxy(user);

Console.WriteLine(book.GetWriting());

var user2 = new User("Alex", false, false);
IBook book2 = new BookProxy(user2);

Console.WriteLine(book2.GetWriting());

var user3 = new User("Alexandr", true, false);
IBook book3 = new BookProxy(user3);

Console.WriteLine(book3.GetWriting());