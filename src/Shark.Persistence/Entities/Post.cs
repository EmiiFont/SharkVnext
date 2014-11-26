using System;
using MongoDB.Bson;

namespace Shark.Persistence.Entities
{
    public class Post : IEntity
    {
        public ObjectId Id  { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string MediaUrl { get; set; }

        public int TotalComments { get; set; }
        public int TotalLikes { get; set; }
    }
}