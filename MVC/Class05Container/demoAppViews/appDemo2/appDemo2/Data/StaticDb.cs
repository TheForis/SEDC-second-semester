using appDemo2.Models;

namespace appDemo2.Data
{
    public static class StaticDb
    {
        public static List<StudentViewModel> Students = new List<StudentViewModel>()
        {
            new StudentViewModel
            {
                Id=1,
                FirstName="Boris",
                LastName="Krstovski",
                Gender = 'M',
                Group = GroupEnum.G3
            }
        };
    }
}
