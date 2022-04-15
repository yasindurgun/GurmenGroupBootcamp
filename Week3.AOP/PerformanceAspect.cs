using Castle.DynamicProxy;
using System.Diagnostics;

namespace Week3.AOP
{
    //Metodların çalışma sürelerini bulmak maksadıyla yazdığımız aspect

    //(Seperation of Cross Cutting Concerns) yapısını uygulamak maksadıyla projenin her yerinde kullanılabilecek herhangi bir
    //katmana bağlı olmayan iş parçalarını kod tekrarını ve efektifliği de önleyebilmesi adına bu şekilde aspect haline getiriyoruz.

    //Interceptor ihtiyacımıza göre metoda girmeden önce, işlem bittikten sonra, hata durumlarında araya girerek
    //istediğimiz şekilde davranmamız yönünde bize imkan verir.
    public class PerformanceAspect : MethodInterceptionBaseAttribute
    {
        private Stopwatch _stopWatch;
        public PerformanceAspect()
        {
            _stopWatch = new Stopwatch();
        }

        public override void Intercept(IInvocation invocation)
        {
            try
            {
                _stopWatch.Start();
                invocation.Proceed();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            Console.WriteLine("deneme");
            Console.WriteLine($"Performance : {invocation.Method.DeclaringType.FullName}.{invocation.Method.Name} = {_stopWatch.Elapsed.TotalSeconds}");

            _stopWatch.Reset();
        }
    }
}
