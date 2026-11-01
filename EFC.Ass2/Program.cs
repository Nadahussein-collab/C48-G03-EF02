using Microsoft.EntityFrameworkCore;

namespace EFC.Ass2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ass2
            //using var context = new EventHubDbContext();

            //context.Database.EnsureCreated();
            //Console.WriteLine("Database created successfully!");

            //if (!context.Organizers.Any())
            //{
            //    var organizer = new Organizer
            //    {
            //        Name = "Tech Pioneers",
            //        CompanyName = "Pioneers LLC",
            //        IsVerified = true,
            //        OrganizerProfile = new OrganizerProfile
            //        {
            //            Biography = "We organize top-tier technology and software conferences.",
            //            WebsiteUrl = "https://techpioneers.org",
            //            LogoUrl = "https://techpioneers.org/logo.png"
            //        }
            //    };

            //    organizer.Events.Add(new Event
            //    {
            //        Title = "Global .NET Conference 2026",
            //        Description = "A deep dive into EF Core and modern architecture.",
            //        StartDate = DateTime.Now.AddDays(30),
            //        MaxAttendees = 300
            //    });

            //    var attendee = new Attendee
            //    {
            //        FullName = "Mohamed Ali",
            //        Email = "mohamed.ali@example.com",
            //        Street = "45 Tahrir Street",
            //        City = "Cairo",
            //        Country = "Egypt",
            //        PostalCode = "11511",
            //        Badge = new Badge
            //        {
            //            CredentialNumber = "BADGE-554433",
            //            IssuedDate = DateTime.Now,
            //            Tier = BadgeTier.VIP
            //        }
            //    };

            //    context.Organizers.Add(organizer);
            //    context.Attendees.Add(attendee);
            //    context.SaveChanges();
            //    Console.WriteLine("Data seeded successfully!");
            //}

            //Console.WriteLine("\n--- Organizers List ---");
            //var organizers = context.Organizers
            //    .Include(o => o.OrganizerProfile)
            //    .Include(o => o.Events)
            //    .ToList();

            //foreach (var org in organizers)
            //{
            //    Console.WriteLine($"Organizer: {org.Name} | Company: {org.CompanyName} | Bio: {org.OrganizerProfile?.Biography}");
            //    foreach (var ev in org.Events)
            //    {
            //        Console.WriteLine($"   -> Event: {ev.Title} (Max: {ev.MaxAttendees})");
            //    }
            //}

            //Console.WriteLine("\n--- Attendees List ---");
            //var attendees = context.Attendees
            //    .Include(a => a.Badge)
            //    .ToList();

            //foreach (var att in attendees)
            //{
            //    Console.WriteLine($"Attendee: {att.FullName} | Full Address: {att.FullAddress} | Badge Tier: {att.Badge?.Tier}");
            //}

            #endregion
        }
    }
}
