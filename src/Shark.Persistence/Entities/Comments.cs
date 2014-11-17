using MongoDB.Bson;
using System;

namespace Shark.Persistence.Entities
{
    public class Comments : IEntity
    {
        public ObjectId Id { get; set; }
        public ObjectId PostId { get; set; }
        public string Content { get; set; }

    }
}