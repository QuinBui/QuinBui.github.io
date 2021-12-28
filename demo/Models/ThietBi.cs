using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace demo.Models
{
    public class ThietBi
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement]
        public double MATB { get; set; }

        [BsonElement]
        public string TENTB { get; set; }
        [BsonElement]
        public double GIATHANH { get; set; }
        [BsonElement]
        public string HINHANH { get; set; }
        [BsonElement]
        public int SOLUONG { get; set; }
    }
}