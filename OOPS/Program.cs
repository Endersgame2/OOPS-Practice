student std = new student();
std.marks = 10;
std.name = "Sushant";
std.age = 21;

std.details();



 class student { 
  public  string name;
    public int age;
    public int marks;


    // function
    public void details()
{
        Console.WriteLine("Name= {0} Age = {1} Marks ={2}",name,age,marks);
}

}

