using Castle.DynamicProxy;

namespace Week3.AOP
{
    //Bu attribute ile beraber aop modüllerinin method ve classların üzerine yazılarak attribute gibi kullanılması sağlanır.
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor
    {
        public virtual void Intercept(IInvocation invocation)
        {

        }
    }
}
