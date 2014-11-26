using MongoDB.Bson;
using Shark.Persistence.Enumerations;
using System;

namespace Shark.Persistence.Entities
{
    public class Activity : IEntity
    {
        public ObjectId Id { get; set; }
        public ActivityType ActivityType { get; set; }
        public ObjectId UserId { get; set; }
        public ObjectId ActivityTypeId { get; set; }
    }

}