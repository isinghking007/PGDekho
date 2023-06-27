using Microsoft.AspNetCore.Mvc;
using PGDekho.com.Models;

namespace PGDekho.com.Logic
{
    public interface ICommon : IGenericRepository<Register>
    {
       Register RegisterUser(Register register);

       IEnumerable<Register> GetAllUsers();

        Register LoginUser(string Email,string Password);

    }
}
