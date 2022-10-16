namespace LanguageClasses.Domain
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Program { get; set; }
        public string Description { get; set; }
        public int Intensivity { get; set; }
        public int GroupSize { get; set; }
        public int VacanciesNumber { get; set; }
        public int HoursNumber { get; set; }
        public double Cost { get; set; }
    }
}