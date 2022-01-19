using System.ComponentModel.DataAnnotations;

namespace apiREST.Model
{
    public class Element
    {
        public Element() 
        {
            
        }


        [Key]
        public string? name { get; set; }
        public string? image { get; set; }


    }
}
