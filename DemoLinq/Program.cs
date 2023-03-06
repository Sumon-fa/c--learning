namespace DemoLinq;
class Program
{
 static void Main(string[] args)
 {
  var lst = new List<string> { "item1", "item2", "item3", "y3" };
  var result = lst.Where(item => item.Contains("3"));
  foreach (var item in result)
  {
   Console.WriteLine(item);
  }
  result = lst.MyWhere(item => item.Contains("2"));
  foreach (var item in result)
  {
   Console.WriteLine(item);
  }

  var players = new[]{

        new {
        Name="Ronaldo",
        Clubs=new List<string>{"real","juve"},
        Goals=800,
        Assist=400
        },
        new {
        Name="Messi",
        Clubs=new List<string>{"barca","psg"},
        Goals=700,
        Assist=600
        },
        new {
        Name="Neymar",
        Clubs=new List<string>{"psg","barca"},
        Goals=500,
        Assist=300
        }

      };
  players.
        OrderBy(player => player.Goals).
        Select(player => new { Name = player.Name, Goals = player.Goals })
        .ToList().ForEach(
      Console.WriteLine
        );
  // get players whose club is barca

  var barcaPlayers = players.Where(player => player.Clubs.Contains("barca"));

  foreach (var player in barcaPlayers)
  {
   Console.WriteLine(player.Name);

  }


  players.
  Where(player => player.Clubs.Contains("barca")).
  Where(player => player.Goals > 600).
  ToList().ForEach(player => Console.WriteLine(player.Name));

  var strList = new List<string> { "hiiii", "he", "moi" };
  strList.Take(2).ToList().ForEach(Console.WriteLine);
  strList.TakeWhile(item => item.Length > 2).ToList().ForEach(Console.WriteLine);//when cond meets it will go further else stop

  var numList = new List<int> { 1, 2, 2, 3, 3, 4, 4, 7 };
  (from n in numList where n % 2 == 0 select n * 2).ToList().ForEach(Console.WriteLine);



  var pets = new[]{

   new {Name="dog",Breed="chaiwawa",Age=1},
   new {Name="cat",Breed="shiba",Age=2},
   new {Name="dog",Breed="labrador",Age=3},
   new {Name="dog",Breed="chaiwawa",Age=5},
};

  pets.
  Where(pet => pet.Name == "dog")
  .Select(pet => new { Type = pet.Name, Description = $"{pet.Breed} is of {pet.Age} years old" })
  .ToList()
  .ForEach(pet => Console.WriteLine(pet.Description));


  (from pet in pets where pet.Name == "dog" select new { Type = pet.Name, Description = $"{pet.Breed} is of {pet.Age} years old" })
  .ToList().ForEach(pet => Console.WriteLine(pet.Description));

  //selectMany
  players
  .SelectMany(player => player.Clubs)
  .ToList().ForEach(Console.WriteLine);

  var students = new[]{
     new{Id=1,Name="jere",ProductId=1},
     new{Id=2,Name="kim",ProductId=1},
     new{Id=3,Name="daniel",ProductId=2},
     };
  var books = new[]{
     new{Id=1,Name="learn c#"},
     new{Id=2,Name=".net"},
     new{Id=3,Name="javascript"},
     };

  students.Join(books, student => student.ProductId, book => book.Id, (student, book) =>
 $"{student.Name} has bought {book.Name}"
  ).ToList().ForEach(Console.WriteLine);

  (from s in students join b in books on s.ProductId equals b.Id select $"{s.Name} has bought {b.Name}")
  .ToList().ForEach(Console.WriteLine);








 }


}
