using PhotosMvc.Models;
using PhotosMvc.Views.Photos;

namespace PhotosMvc.Services;

public class DataService
{
    List<Photo> photos =
    [
        new Photo { Id = 1, ThumbnailUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/79/%D0%A1%D0%B2%D1%96%D1%82%D0%BB%D0%BE_%D0%B2_%D0%BA%D0%B0%D0%BF%D0%BB%D0%B8%D1%87%D1%86%D1%96.jpg/500px-%D0%A1%D0%B2%D1%96%D1%82%D0%BB%D0%BE_%D0%B2_%D0%BA%D0%B0%D0%BF%D0%BB%D0%B8%D1%87%D1%86%D1%96.jpg", Description = "A nice photo" },
        new Photo { Id = 2, ThumbnailUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/21/Incense_in_Vietnam.jpg/300px-Incense_in_Vietnam.jpg", Description = "Another nice photo" },
        new Photo { Id = 3, ThumbnailUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/68/White-lined_tanager_%28Tachyphonus_rufus%29_female.jpg/300px-White-lined_tanager_%28Tachyphonus_rufus%29_female.jpg", Description = "Yet another nice photo" },
    ];

    public IndexVM[] GetAll()
    {
        return photos
            .Select(photo => new IndexVM
            {
                Url = photo.ThumbnailUrl,
                Description = photo.Description,
            })
            .ToArray();
    }
}
