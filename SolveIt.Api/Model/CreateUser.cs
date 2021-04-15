using DataAnnotationsExtensions;

namespace SolveIt.Model
{
    public class CreateUser
    {
        public string Name { get; set; }

        public string Password { get; set; }

        [Email]
        public string EmailId { get; set; }

        public string MobileNumber { get; set; }

        public string Class { get; set; }
    }
}
