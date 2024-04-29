namespace modul9_1302220067
{
    public class Mahasiswa
    {
        public String Name { get; set; }
        public String Nim { get; set; }
        public List<String> Course { get; set; }
        public int Year { get; set; }
        public Mahasiswa(String name, String nim, List<String> course, int year)
        {
            this.Name = name;
            this.Nim = nim;
            this.Course = course;   
            this.Year = year;   
        }
    }
}
