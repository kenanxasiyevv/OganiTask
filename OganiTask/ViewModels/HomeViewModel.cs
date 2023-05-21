
using OganiTask.DataAccessLayer.Entities;

namespace OganiTask.ViewModels
{
    public class HomeViewModel
    {
        public List<Categories>? Categories { get; set; }

        public List<Products>? Products { get; set; }

        public List<Blogs>? Blogs { get; set; }

    }
}
