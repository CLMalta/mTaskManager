using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Domain.Models;
using Persistence.Context;

namespace Persistence.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IDapperContext _context;

        public UserRepository(IDapperContext context)
        {
            _context = context;
        }

        public IUser Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IUser> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Create(IUser model)
        {
            throw new NotImplementedException();
        }

        public bool Update(IUser model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<User?> Authenticate(string userName, string password)
        {
            using (var connection = _context.CreateConnection())
            {
                var sql = "SELECT UserId, UserName, Email, Role FROM Users WHERE UserName = @UserName AND PasswordHash = @Password";
                var user = await connection.QuerySingleOrDefaultAsync<User>(sql, new { userName, password });
                return user;
            }
        }
    }
}
