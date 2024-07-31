using System.Reflection;

namespace UserRegistration.Models
{
    //Класс модели
    public class RegisterModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string ConfirmPassword { get; set; }

        //Метод проверки на соответствие пароля
        public bool IsUserConfirm()
        {
            if (!(UserName == ConfirmPassword))
                return false;
            return true;
        }
    }
}
