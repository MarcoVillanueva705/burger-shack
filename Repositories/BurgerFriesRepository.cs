using System.Collections.Generic;
using System.Data;
using Dapper;
using BurgerShack.Models;

namespace BurgerShack.Repositories
{
    public class BurgerFriesRepository

    {

        private readonly IDbConnection _db;

        public BurgerFriesRepository(IDbConnection db)
        {
            _db = db;
        }

        internal BurgerFries Find(BurgerFries bfs)
        {
            string sql = "SELECT * FROM burgerfries WHERE (burgerId = @BurgerId AND friesId = @FriesId)";
            return _db.QueryFirstOrDefault(sql, bfs);
        }

        internal BurgerFries Create(BurgerFries newData)
        {
            string sql = @"
            INSERT INTO burgerfries
            (burgerId, friesId) 
            VALUES 
            (@BurgerId, @FriesId);
            SELECT LAST_INSERT_ID();
            ";
            int id = _db.ExecuteScalar<int>(sql, newData);
            newData.Id = id;
            return newData;
        }

        internal void Delete(int id)
        {
            string sql = "DELETE FROM burgerfries WHERE id = @id";
            _db.Execute(sql, new { id });
        }
    }
}