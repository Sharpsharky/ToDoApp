namespace ToDoApp.Models
{
    public class ComboBoxItem
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string FullName => $"{Name} - [{ID}]";
    }
}