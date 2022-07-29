

using CleanArchitecture.Data;
using CleanArchitecture.Domain;
using Microsoft.EntityFrameworkCore;

StreamerDbContext dbContext = new();
await QueryFilter();

// Streamer streamer = new()
// {
//     Nombre = "Amazon",
//     Url = "http://amazon"
// };

// dbContext!.Streamers!.Add(streamer);

// await dbContext.SaveChangesAsync();


// List<Video> videos = new(){
//     new Video{
//         Nombre = "Mad Max",
//         StreamerId = streamer.Id
//     },
//       new Video{
//         Nombre = "Rapidos",
//         StreamerId = streamer.Id
//     },
//       new Video{
//         Nombre = "Olivia",
//         StreamerId = streamer.Id
//     }
// };

// await dbContext!.Videos!.AddRangeAsync(videos);



async Task QueryFilter()
{
    var streamers = await dbContext!.Streamers!.Where(x => x.Nombre == "pepe").ToListAsync();
    // var streamers = await dbContext!.Streamers!.Where(x => EF.Functions.Like(x.Nombre, $"pepe")) .ToListAsync();
    foreach (var streamer in streamers)
    {
        Console.WriteLine($"{streamer.Id} - {streamer.Nombre}");
    }
}
