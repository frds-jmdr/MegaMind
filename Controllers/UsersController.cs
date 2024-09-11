using MegaMind.Models;
using MegaMind.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MegaMind.Controllers
{

    public class UsersController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult Index()
        {
            var users = _userRepository.GetAllUsers();
            return View(users);
        }

        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new UserModel());
            else
                return View(_userRepository.GetUserById(id));
        }

        [HttpPost]
        public IActionResult AddOrEdit(UserModel user)
        {
            if (ModelState.IsValid)
            {
                if (user.Id == 0)
                    _userRepository.AddUser(user);
                else
                    _userRepository.UpdateUser(user);

                return RedirectToAction("Index");
            }
            return View(user);
        }

        [HttpPost]
        public JsonResult Delete(int id)
        {
            _userRepository.DeleteUser(id);
            return Json(new { success = true });
        }
    }
}
