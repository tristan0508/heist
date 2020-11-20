using System;

namespace hiest
{
    public class Member
    {
        public string Name { get; set; }
        private int SkillLevel { get; set; }
        private double CourageFactor { get; set; }

        public Member(string name, int skill, double courage)
        {
            Name = name;
            SkillLevel = skill;
            CourageFactor = courage;
        }
    }
}