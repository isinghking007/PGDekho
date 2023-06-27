using Microsoft.AspNetCore.Mvc;
using PGDekho.com.DataContext;
using PGDekho.com.Models;

namespace PGDekho.com.Logic.Repositories
{
    public class CommonRepository :  ICommon
    {
        private readonly DBContext _context;
      //  private readonly ILogger _logger;

        public CommonRepository(DBContext context)
        {
            _context = context;
//            _logger = logger;
        }

        public void Add(Register entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Register entity)
        {
            throw new NotImplementedException();
        }

        Register ICommon.RegisterUser(Register register)
        {
           
            register.CreatedDate = DateTime.Now;
            _context.Registers.Add(register);
            _context.SaveChanges();
            return register;
        }
        public IEnumerable<Register> GetAllUsers()
        {
            return _context.Registers.ToList();
        }


         Register ICommon.LoginUser(string Email, string Password)
        {
            var result = _context.Registers.Where(x => x.Email == Email && x.Password == Password).FirstOrDefault();
            return result;
        }

        public IEnumerable<Register> ShowAllRecords()
        {
            throw new NotImplementedException();
        }

        public void Update(Register entity)
        {
            throw new NotImplementedException();
        }

    }
}
