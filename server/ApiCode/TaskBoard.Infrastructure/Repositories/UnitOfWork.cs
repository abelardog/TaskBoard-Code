using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskBoard.Core.Entities;
using TaskBoard.Core.Interfaces.Data;

namespace TaskBoard.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IRepository<User> UserRepository { get; }
        public IRepository<Board> BoardRepository { get; }
        public IRepository<List> ListRepository { get; }
        public IRepository<Card> CardRepository { get; }
        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
