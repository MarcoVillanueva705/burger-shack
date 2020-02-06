using System;
using System.Collections.Generic;
using BurgerShack.Models;
using BurgerShack.Repositories;

namespace BurgerShack.Services
{
    public class FriesService
    {
        private readonly FriesRepository _repo;
        public FriesService(FriesRepository br)
        {
            _repo = br;
        }

        internal IEnumerable<Fries> Get()
        {
            return _repo.Get();
        }

        internal Fries GetById(int id)
        {
            var exists = _repo.GetById(id);
            if (exists == null) { throw new Exception("Invalid Id"); }
            return exists;
        }

        internal Fries Create(Fries newData)
        {
            _repo.Create(newData);
            return newData;
        }
        internal Fries Edit(Fries update)
        {
            var exists = _repo.GetById(update.Id);
            if (exists == null) {throw new Exception("Invalid Id"); }
            _repo.Edit(update);
            return update;
        }

        internal string Delete(int id)
        {
            var exists = _repo.GetById(id);
            if (exists == null) { throw new Exception("Invalid Id"); }
            _repo.Delete(id);
            return "Successfully Deleted";
        }
    }
}