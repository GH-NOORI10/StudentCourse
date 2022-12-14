using Microsoft.AspNetCore.Mvc.Rendering;

namespace StudentCourse.ViewModels
{
    public class CreateStudentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public DateTime Enrolled { get; set; }

        public List<SelectListItem> Courses{ get; set; }    
    }
}
