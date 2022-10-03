namespace ChefApp.Models
{
    public class ChefDetails
    {
        
        
            public int Id { get; set; }
            public string Name { get; set; }

            public string Dishes { get; set; } 




            public static List<ChefDetails> ChefInformation()
            {
                List<ChefDetails> chefs = new() {
                  new ChefDetails { Id = 1, Name = "Priya" , Dishes = " Pav Bhaji"},
                  new ChefDetails { Id = 2, Name = "Deepika", Dishes = "  Paneer Butter Masala"},
                  new ChefDetails { Id = 3, Name = "Divya Bharathi", Dishes = "  Malai Kofta"}
        };
                return chefs;
            }
       
    }
}


