using Entities.ModelsDto;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace DicleAcademy.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICoursesCategoriesService _coursesCategoriesService;
        private readonly ICourseDetailsService _courseDetailsService;
        private readonly ICoursesService _coursesService;

        public CoursesController(ICoursesCategoriesService coursesCategoriesService, ICourseDetailsService courseDetailsService, ICoursesService coursesService)
        {
            _coursesCategoriesService = coursesCategoriesService;
            _courseDetailsService = courseDetailsService;
            _coursesService = coursesService;
        }

        public IActionResult Index()
        {
           List<GetCategoryWithCoursesDto> getCategoryWithCoursesDto = new List<GetCategoryWithCoursesDto>();
           GetCategoryWithCoursesDto getCategoryWithCourses = new GetCategoryWithCoursesDto();

            var data =  _coursesCategoriesService.GetAllCoursesCategories();

           foreach (var item in data) 
            {
                var dto =  _coursesService.GetCoursesByCategoryId(item.CategoryID);
                getCategoryWithCourses.CategoryName = item.CategoryName;
                getCategoryWithCourses.Courses = dto;
                getCategoryWithCourses.CoursesCategory = item;
                getCategoryWithCoursesDto.Add(getCategoryWithCourses);
            }
            return View("CoursesIndex" , Tuple.Create(getCategoryWithCoursesDto , data));
        }
        public IActionResult CoursesDetails(int id)
        {
          var courses= _courseDetailsService.GetByIdCourseDetails(id);
            return View("CoursesDetails" , courses);
        }
    }
}
