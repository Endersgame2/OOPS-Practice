class student
{
    public int age;
    public int marks;

}
 class programm
{

    //static void main(string[] args)
    {
        student std = new student();
        std.age = 10;
        std.marks = 20;


        student std2 = std;
        student std3 = std;
        
        std.age = 12;

        Console.WriteLine(std2.age);

    }
}
