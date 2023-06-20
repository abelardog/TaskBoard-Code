using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskBoard.Core.Entities;

namespace TaskBoard.Core.Interfaces.Data
{
    public interface IUnitOfWork
    {
        IRepository<User> UserRepository { get; }
        IRepository<Board> BoardRepository { get; }
        IRepository<List> ListRepository { get; }
        IRepository<Card> CardRepository { get; }
        Task<int> SaveChangesAsync();
    }
}
