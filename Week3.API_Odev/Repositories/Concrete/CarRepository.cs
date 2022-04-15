using Dapper;
using System.Data;
using Week3.API_Odev.Commands;
using Week3.API_Odev.Commands.CarDelete;
using Week3.API_Odev.Commands.CarUpdate;
using Week3.API_Odev.Models;
using Week3.API_Odev.Repositories.Abstract;

namespace Week3.API_Odev.Repositories.Concrete
{
    public class CarRepository : ICarRepository
    {
        private readonly IDbConnection _connection;
        private readonly IDbTransaction _transaction;
        public CarRepository(IDbConnection connection, IDbTransaction transaction)
        {
            _connection = connection;
            _transaction = transaction;
        }

        public async Task<bool> Delete(CarDeleteCommand carDeleteCommand)
        {
            var command = "delete from cars where id=@id";

            return await _connection.ExecuteAsync(command, carDeleteCommand) > 0;
        }

        public async Task<List<Car>> GetAll()
        {
            var query = "select * from cars";
            var cars = await _connection.QueryAsync<Car>(query);

            return cars.ToList();
        }

        public async Task<List<Car>> GetAllWithPage(int page, int pageSize)
        {
            int offset = (page - 1) * pageSize;
            var query = "select * from cars order by id desc limit @pagesize offset @offset";

            var cars = await _connection.QueryAsync<Car>(query, new { pagesize = pageSize, offset = offset });

            return cars.ToList();
        }

        public async Task<int> Save(CarInsertCommand carInsertCommand)
        {
            var command = "insert into cars(modelyear,price,description,color,serialnumber)values(@modelyear,@price,@description,@color,@serialnumber) returning id";

            var id = await _connection.ExecuteScalarAsync<int>(command, carInsertCommand.CarRequestDto);


            return id;
        }

        public async Task<bool> Update(CarUpdateCommand carUpdateCommand)
        {
            var command = "update cars set modelyear=@modelyear, price=@price,description=@description,color=@color, serialnumber=@serialnumber where id=@id";
            return await _connection.ExecuteAsync(command, carUpdateCommand) > 0;
        }
    }
}
