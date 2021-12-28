using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace demo.Models
{
    public class ChiTietTB
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement]

        public int MATB { get; set; }
        [BsonElement]
       
        public string HINHCT { get; set; }
        [BsonElement]
      
        public string THONGSO { get; set; }
        
    }
}