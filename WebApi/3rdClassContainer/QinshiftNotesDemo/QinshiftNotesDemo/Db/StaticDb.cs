using QinshiftNotesDemoAppAndTags.Models;

namespace QinshiftNotesDemoAppAndTags.Db
{
    public static class StaticDb
    {
        public static List<string> Users = new List<string>()
        {
            "Slave",
            "Martin",
            "Bob",
            "Jill",
            "Jayne",
            "July"
        };
        public static List<Note> Notes = new List<Note>()
        {
            new Note()
            {
                Text = "DO Homework!", Priority= Priority.Low, Tags = new List<Tag>()
                {
                    new Tag() {Name="School homework", Color= "red"},
                    new Tag() {Name="Academy homework", Color= "green"}

                }
            },
            new Note()
            {
                Text = "Exercise", Priority= Priority.Medium, Tags = new List<Tag>()
                {
                    new Tag() {Name="Go running", Color= "yellow"},
                    new Tag() {Name="outside", Color= "green"}

                }
            },
            new Note()
            {
                Text = "Feed the baby", Priority= Priority.High, Tags = new List<Tag>()
                {
                    new Tag() {Name="milk", Color= "red"},
                    new Tag() {Name="cuddle", Color= "green"}

                }
            }

        };

    }
}
