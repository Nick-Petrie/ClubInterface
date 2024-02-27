class Program
{
    static void Main(string[] args)
    {
        ClubMember member1 = new ClubMember();
        member1.Id = 1;
        member1.FirstName = "Nick";
        member1.LastName = "Petrie";
        member1.Email = "nickolaspetrie@google.com";
        member1.PhoneNumber = "989-745-4595";
        member1.Age = 26;

        member1.DisplayMemberInfo();
        Console.WriteLine();

        ClubMember member2 = new ClubMember(2, "McKenzie", "Petrie", "petriemck26@gmail.com", "012-345-6789", 28);
        
        member2.DisplayMemberInfo();
    }
}
interface IClub
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Fullname();
}

public class ClubMember : IClub
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public int Age { get; set; }


    public ClubMember()
    {

    }

    public ClubMember(int id, string firstName, string lastName, string email, string phonenumber, int age)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PhoneNumber = phonenumber;
        Age = age;
    }
    public void DisplayMemberInfo()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Name: {FirstName} {LastName}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Phone Number: {PhoneNumber}");
        Console.WriteLine($"Age: {Age}");

    }
    public string Fullname()
    {
        return $"{FirstName} {LastName}";
    }
}
