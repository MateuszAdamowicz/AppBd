using System.Collections.Generic;

namespace Shop.Domain.Model.Product
{
    public class Photos
    {
        public int Id { get; set; }
        public Photo MainPhoto { get; set; }
        public IEnumerable<Photo> OtherPhotos { get; set; }
    }
}