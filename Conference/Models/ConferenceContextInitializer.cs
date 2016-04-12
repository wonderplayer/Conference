using System.Data.Entity;

namespace Conference.Models
{
    public class ConferenceContextInitializer : DropCreateDatabaseAlways<ConferenceContext>
    {
        protected override void Seed(ConferenceContext context)
        {
            context.Sessions.Add(
                new Session()
                {
                    Title = "I want some spaghetti",
                    Abstract = "The lige and times of spaghetti lover",
                    Speaker = context.Speakers.Add(
                        new Speaker() { Name = "Jon Galloway",
                                        EmailAddress = "jon@nowhere.com"
                        })
                });
            context.SaveChanges();
            //base.Seed(context);
        }
    }
}