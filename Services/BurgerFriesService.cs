
using System;
using System.Collections.Generic;
using BurgerShack.Models;
using BurgerShack.Repositories;

namespace BurgerShack.Services
{

    public class BurgerFriesService
    {

        private readonly BurgerFriesRepository _repo;

        public BurgerFriesService(BurgerFriesRepository bfr)
        {
            _repo = bfr;

        }

        internal void Create(BurgerFries newData)
        {
            BurgerFries exists = _repo.Find(newData);
            if (exists != null) { throw new Exception("Combo already a thing!"); }
            _repo.Create(newData);
        }

        internal string Delete(BurgerFries bfs)

        {

            BurgerFries exists = _repo.Find(bfs);
            if (exists == null) { throw new Exception("Invalid Id Combo!"); }
            _repo.Delete(exists.Id);
            return "Successfully Deleted";
        }
    }
}