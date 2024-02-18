using Entities.ModelsDto;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using Services.EFCore;
using System.Diagnostics;

namespace DicleAcademy.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBestCoursesService _bestcoursesService;
        private readonly ICoursesService _coursesService;
        private readonly IWelcomeInformationsService _welcomeInformationsService;
        private readonly ISkillsService _skillsService;
        private readonly IInstructorsService _instructorsService;
        private readonly IStudentsSayService _studentsSayService;

        public HomeController(IBestCoursesService bestcoursesService, ICoursesService coursesService, IWelcomeInformationsService welcomeInformationsService, ISkillsService skillsService, IInstructorsService instructorsService, IStudentsSayService studentsSayService)
        {
            _bestcoursesService = bestcoursesService;
            _coursesService = coursesService;
            _welcomeInformationsService = welcomeInformationsService;
            _skillsService = skillsService;
            _instructorsService = instructorsService;
            _studentsSayService = studentsSayService;
        }

        public IActionResult Index()
        {
            var bestCourses = _bestcoursesService.GetAllBestCourses();
            var courses = new List<CoursesDto>();
            foreach (var course in bestCourses) 
            {
              courses.Add(_coursesService.GetByIdCourses(course.CourseId));
            }
            var welcome = _welcomeInformationsService.GetAllWelcomeInformations();
            var skills = _skillsService.GetAllSkills();
            var instruct = _instructorsService.GetAllInstructors();
            var studentSay=_studentsSayService.GetAllStudentsSay();
            //welcome abaout skills courses  InstructorsDto Testimonial
            return View(Tuple.Create(courses, welcome , skills , instruct , studentSay));
        }

    
    }
}
