using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Win32;
using PGDekho.com.DataContext;
using PGDekho.com.Logic;
using PGDekho.com.Models;
using PGDekho.com.ServiceFolder;

namespace PGDekho.com.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly DBContext _context;
        private readonly IUnitOfWork unitOfWork;
        private readonly IPhotoService photoService;
        private readonly IConfiguration _config;
        public MainController(DBContext context,IUnitOfWork unitOfWork,IPhotoService photoService,IConfiguration config)
        {
            _context = context;
            this.unitOfWork = unitOfWork;
            this.photoService = photoService;
            _config = config;
        }

        #region Get Methods

        [HttpGet("ShowAllUsers")]
        public IEnumerable<Register> ShowAllUsers()
        {
           return  unitOfWork.Common.GetAllUsers();
        }

       
        [HttpGet("allproperty")]
        public IActionResult AllListedProperty()
        {
            var result = unitOfWork.PropertyOwner.AllListedProperty();
            if(result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }

        #endregion Get Methods

        #region Post Methods

        [HttpPost("register")]
        public IActionResult RegisterUser(Register register)
        {
            if ((register.Email == null || register.Email == string.Empty) || (register.FirstName == null || register.FirstName == string.Empty) ||
                (register.LastName == null || register.LastName == string.Empty) || (register.City == null || register.City == string.Empty)
                || (register.Password == null || register.Password == string.Empty) || (register.PropertyOwner == null || register.PropertyOwner == string.Empty))
            {
                return Ok("Please Enter all the required details");
            }
            else
            {
                var checkResult = unitOfWork.Common.GetAllUsers().Where(x => x.Email == register.Email).FirstOrDefault();
                if (checkResult == null)
                {
                    var result = unitOfWork.Common.RegisterUser(register);
                }
                else
                {
                    return Ok("Already Registered");
                }
            }
           
           
            return Ok("Successfully registered");
        }
        [HttpPost("propertyDetails")]
        public IActionResult AddPropertyDetails(PropertyDetails property)
        {
           
            var result = unitOfWork.PropertyOwner.AddPropertyDetails(property);
            if(result == null)
            {
                return Ok("Please enter details");
            }
            return Ok("Details Added successfully");
        }



        [HttpPost("addPhoto")]
        public async Task<IActionResult> AddPhoto(IFormFile file)
        {
            var result = await photoService.UploadPhotoAsync(file);
            if(result.Error !=null)
            {
                return Ok(result.Error.Message);
            }
            return Ok(result);
        }

        [HttpPost("LoginUser")]
        public IActionResult LoginUser(Login login)
        {

            var checkResult = unitOfWork.Common.GetAllUsers().Where(x => x.Email == login.Email).FirstOrDefault();
            if (checkResult == null)
            {
                return Ok("Not registered,Please register");
            }
            var result = unitOfWork.Common.LoginUser(login.Email, login.Password);
            if (result == null)
            {
                return Ok("Incorrect Credentials");
            }
            return Ok(new JWTServices(_config).GenerateToken(
                result.UserId.ToString(),
                result.FirstName,
                result.LastName,
                result.Email,
                result.City,
                result.PropertyOwner
                ));
        }


        #endregion Post Methods
    }
}
