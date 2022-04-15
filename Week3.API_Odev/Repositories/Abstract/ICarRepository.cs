using Week3.API_Odev.Commands;
using Week3.API_Odev.Commands.CarDelete;
using Week3.API_Odev.Commands.CarUpdate;
using Week3.API_Odev.Models;

namespace Week3.API_Odev.Repositories.Abstract
{
    public interface ICarRepository
    {
        Task<List<Car>> GetAll();

        Task<List<Car>> GetAllWithPage(int page, int pageSize);
        Task<int> Save(CarInsertCommand carInsertCommand);

        Task<bool> Update(CarUpdateCommand carUpdateCommand);

        Task<bool> Delete(CarDeleteCommand carDeleteCommand);
    }
}
