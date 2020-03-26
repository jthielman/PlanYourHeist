using System;
using System.Collections.Generic;
using System.Linq;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your heist!");

            var teamMembers = new List<TeamMember>();

            while (true)
            {
                Console.WriteLine("Please enter the team member's first name.");
                var teamMemberName = Console.ReadLine();
                if (teamMemberName == "") break;

                Console.WriteLine("Please enter the team member's skill level as an integer from 0 to 50.");
                var teamMemberSkillLevel = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the team member's courage factor as a decimal 0.0-2.0.");
                var teamMemberCourageFactor = decimal.Parse(Console.ReadLine());

                var teamMember = new TeamMember
                {
                    Name = teamMemberName,
                    SkillLevel = teamMemberSkillLevel,
                    CourageFactor = teamMemberCourageFactor
                };

                teamMembers.Add(teamMember);

            }
            var numOfMembers = teamMembers.Count();
            Console.WriteLine($"There are {numOfMembers} members");

            /*foreach(var teamMember in teamMembers)
            {
                Console.WriteLine($"{teamMember.Name} has a skill level of {teamMember.SkillLevel} and courage factor of {teamMember.CourageFactor}.");
            }*/

            var sumOfMembersSkill = 0;

            foreach(var teamMember in teamMembers)
            {
                sumOfMembersSkill += teamMember.SkillLevel;
            }

            var newBank = new Bank();

            if (sumOfMembersSkill >= newBank.BankDifficulty)
            {
                Console.WriteLine("You rob the bank and get away scot free!");
            }
            else
            {
                Console.WriteLine("Your team kind of sucks so you go to jail.");
            }
        }
    }
}
