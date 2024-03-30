namespace Demo1Polymorphism.Models
{
    public class Team
    {
        public string Name { get; set; }
        public List<string> Form { get; set; }
        public Team(string name, List<string> form)
        {
            Name = name;
            Form = form;

        }

        public void AddWin()
        {
            Form.Add("W");
        }
        public void AddLose() {
            Form.Add("L");
        }
        public void AddDraw()
        {
            Form.Add("D");
        }

        public static int GetTeamPoints(Team team)
        {
            int points = 0;

            foreach (var result in team.Form)
            {
                if (result == "W") points += 3;
                else if (result == "D") points += 1;

            }

            return points;
        }

    }
}
