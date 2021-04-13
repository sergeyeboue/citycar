using System;

namespace citycar.Models
{
    public class Commentaire
    {
        public int Id { get; set; }
        public String TextCommentaire { get; set; }
        public String Date { get; set; }
        public int IdVoiture { get; set; }
        public int IdPersonne { get; set; }
    }

}
