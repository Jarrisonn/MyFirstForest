using System.Data.Entity;
using Forest.Data.Models.Domain;


namespace Forest.Data.Models.Repository

{
    public class ForestInitialiser : 
        System.Data.Entity.DropCreateDatabaseIfModelChanges<ForestContext>
    {
        protected override void Seed(ForestContext context)
        {
            Genre genre1 = new Genre() { Name = "Rock" };
            Genre genre2 = new Genre() { Name = "Pop" };
            Genre genre3 = new Genre() { Name = "Country" };
            context.Genres.Add(genre1); context.Genres.Add(genre2);
            context.Genres.Add(genre3);

            context.SaveChanges();
        }
    }
}