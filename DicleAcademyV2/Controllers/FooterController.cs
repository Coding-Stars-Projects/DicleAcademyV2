using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace DicleAcademyV2.Controllers
{
    public class FooterController : Controller
    {
        private readonly IGalleryService _galleryService;
        public FooterController(IGalleryService galleryService)
        {
            _galleryService = galleryService;
        }
        public IActionResult Index()
        {
           var gallery=  _galleryService.GetAllGallery();
            return View(Tuple.Create(gallery));
        }
    }
}
