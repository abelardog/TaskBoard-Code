using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskBoard.Core.Entities;
using TaskBoard.Core.Interfaces.Data;
using TaskBoard.Infrastructure.Data;

namespace TaskBoard.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TaskDbContext _dbContext;

        public UnitOfWork(TaskDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        private IRepository<User> _userRepository;
        public IRepository<User> UserRepository => _userRepository ??= new Repository<User>(_dbContext);

        private IRepository<Board> _boardRepository;
        public IRepository<Board> BoardRepository => _boardRepository ??= new Repository<Board>(_dbContext);
       
        private IRepository<List> _listRepository;
        public IRepository<List> ListRepository => _listRepository ??= new Repository<List>(_dbContext);

        private IRepository<Card> _cardRepository;
        public IRepository<Card> CardRepository => _cardRepository ??= new Repository<Card>(_dbContext);

        public Task<int> SaveChangesAsync()
        {
            return _dbContext.SaveChangesAsync();
        }
    }
}
