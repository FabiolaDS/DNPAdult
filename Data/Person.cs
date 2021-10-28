using System.ComponentModel.DataAnnotations;

namespace Family.Data
{
    public class Person
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string hairColor { get; set; }
        public string eyeColor { get; set; }
        public int age { get; set; }
        public float weight { get; set; }
        public int height { get; set; }
        public string sex { get; set; }
    }
}