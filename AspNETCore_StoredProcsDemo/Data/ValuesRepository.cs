using AspNETCore_StoredProcsDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNETCore_StoredProcsDemo.Data
{
    public class ValuesRepository
    {
        public Task<List<Value>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<Value>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(Value value)
        {   
            throw new NotImplementedException();
        }

        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
