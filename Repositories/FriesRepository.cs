using System;
using System.Collections.Generic;
using System.Data;
using BurgerShack.Models;
using Dapper;

namespace BurgerShack.Repositories
{
    public class FriesRepository
    {
        private readonly IDbConnection _db;
        public FriesRepository(IDbConnection db)
        {
            _db = db;
        }
        internal IEnumerable<Fries> Get()
        {
            string sql = "SELECT * FROM fries";
            return _db.Query<Fries>(sql);
        }
        internal Fries GetById(int Id)
        {
            string sql = "SELECT * FROM fries WHERE id = @Id";
            return _db.QueryFirstOrDefault<Fries>(sql, new{ Id }) ;
        }
        internal Fries Create(Fries newData)
        {
            string sql = @"
            INSERT INTO fries
            (name, description, price)
            VALUES
            (@Name, @Description, @Price);
            SELECT LAST_INSERT_id();
            ";
            int id = _db.ExecuteScalar<int>(sql, newData);
            newData.Id = id;
            return newData;
        }
        internal void Edit(Fries update)
        {
            string sql = @"
            UPDATE fries
            SET
            name = @Name,
            description = @Description,
            price = @Price
            WHERE id = @Id;
            ";
            _db.Execute(sql, update);
        }
        internal void Delete(int id)
        {
            string sql = "DELETE FROM fries WHERE id = @id";
            _db.Execute(sql, new {id});
        }
    }
}