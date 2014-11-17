using MongoDB.Bson;
using System;

namespace Shark.Persistence.Entities
{
    public interface IEntity
    {
        ObjectId Id { get; set; }
    }
}