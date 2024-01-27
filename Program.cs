// See https://aka.ms/new-console-template for more information
using Specification_Pattern;
var user = new user
{
    Name = "علی",
    LastName = "salman",
    day = 12
};
Day day = new Day();
name name = new name();
var or = new OrSpecification<user>(day, name);
var result = or.IsSatisfiedBy(user);
if (result == true)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}
