using eTickets.Models;
using System.Collections.Generic;

namespace eTickets.Data.Services
{
    public interface IActorsService
    {
        IEnumerable<Actor> GetAll(); //all actors from db
        Actor GetById(int id); // one actor from db
        void Add(Actor actor); // add data to db
        Actor Update(int id, Actor newActor); // update data in db
        void Delete(int id); // delete data
    }
}
