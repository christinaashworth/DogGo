using DogGo.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace DogGo.Repositories
{
    public interface IWalkRepository
    {
        List<Walk> GetAllWalks();
        Walk GetWalkById(int id);
        void AddWalk(Walk walk);
        void UpdateWalk(Walk walk);
        void DeleteWalk(int id);
    }
}
