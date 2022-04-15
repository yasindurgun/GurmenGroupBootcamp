using Autofac;
using Autofac.Extras.DynamicProxy;

namespace Week3.AOP
{
    //Interfacelerin karşılığı olan somut class ları configüre edebileceğimiz merkezi yapıya ulaşabilmek adına autofac modulu
    //aşağıdaki gibi yazılır.
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors().SingleInstance();
        }
    }
}
