
namespace Week3.AOP
{
    public class StudentDal
    {
        public List<Student> Students = new List<Student>
        {
            new Student("Yasin"),
            new Student("Ahmet"),
            new Student("Veli"),
            new Student("Furkan"),
            new Student("Yasin"),
            new Student("Yasin"),
            new Student("Yasin"),
            new Student("Yasin"),
            new Student("Yasin"),
            new Student("Yasin"),
            new Student("Yasin"),
            new Student("Yasin")
        };

        public List<Student> GetList()
        {
            return Students;
        }
    }
}
