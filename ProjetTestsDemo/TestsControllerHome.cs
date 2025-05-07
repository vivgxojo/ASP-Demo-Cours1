using cours1.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace ProjetTestsDemo
{
    public class TestsControllerHome
    {
        [Fact]
        public void TestIndex()
        {
            HomeController homeController = new HomeController();
            var result = homeController.Index();
            Assert.IsType<ViewResult>(result);

        }
        [Fact]
        public void TestHello()
        {
            HomeController homeController = new HomeController();
            var result = homeController.Hello("Philippe");
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Equal("Philippe", viewResult.ViewData["Nom"]);
            var error = homeController.Hello("");
            Assert.IsType<ViewResult>(error);
        }
        [Fact]
        public void TestPrivacy()
        {
            HomeController homeController = new HomeController();
            var result = homeController.Privacy();
            Assert.IsType<ContentResult>(result);
        }
    }
}
