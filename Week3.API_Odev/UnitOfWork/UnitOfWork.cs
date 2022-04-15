using System.Data;

namespace Week3.API_Odev.UnitOfWork
{
    //Global transaction bütünlüğünün sağlanması açısından kullanılır.
    public class UnitOfWork
    {
        private readonly IDbTransaction _transaction;

        public UnitOfWork(IDbTransaction transaction)
        {
            _transaction = transaction;
        }

        public void Commit()
        {

            _transaction.Commit();
        }
        public void Rollback()
        {


        }
    }
}
