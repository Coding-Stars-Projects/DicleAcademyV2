using AutoMapper;
using Entities.Models;
using Entities.ModelsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<AboutUsDto, AboutUs>();
            CreateMap<BestCoursesDto, BestCourses>();
            CreateMap<ContactDto, Contact>();
            CreateMap<CourseDetailsDto, CourseDetails>();
            CreateMap<CoursesDto, Courses>();
            CreateMap<CoursesCategoriesDto, CoursesCategories>();
            CreateMap<FAQDto, FAQ>();
            CreateMap<GalleryDto, Gallery>();
            CreateMap<GetInTouchDto, GetInTouch>();
            CreateMap<HeaderDto, Header>();
            CreateMap<InstructorsDto, Instructors>();
            CreateMap<SkillsDto, Skills>();
            CreateMap<StudentsSayDto, StudentsSay>();
            CreateMap<WelcomeInformationsDto, WelcomeInformations>();
            CreateMap<UserForAuthenticationDto, User>();
        }
    }
}
