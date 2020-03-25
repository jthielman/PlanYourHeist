using System;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your heist!");

            var teamMember1 = new TeamMember();

            Console.WriteLine("Please enter the team member's first name.");
            teamMember1.Name = Console.ReadLine();

            Console.WriteLine("Please enter the team member's skill level as an integer from 0 to 10.");
            teamMember1.SkillLevel = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the team member's courage factor as a decimal 0.0-2.0.");
            teamMember1.CourageFactor = decimal.Parse(Console.ReadLine());
        }
    }
}
