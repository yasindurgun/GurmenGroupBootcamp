
namespace Week3.AOP
{
    public class GetListWithAspectService
    {
        StudentDal _studentDal;
        public GetListWithAspectService()
        {
            _studentDal = new StudentDal();
        }
        [PerformanceAspect]
        public List<Student> GetList()
        {
            return _studentDal.GetList();
        }
    }
}
