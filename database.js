db = db.getSiblingDB("DBMuaBanDienTu");
db.getCollection("THIETBI").find({});
// Requires official MongoShell 3.6+


db.THIETBI.insert([
  {
    MATB:0,
    TENTB: "Điện thoại iphone 12 64gb",
    GIATHANH:24000000,
    HINHANH:"ip12.jpg",
    SOLUONG:100
  },
  {
   MATB:1,
    TENTB: "Điện thoại iphone 13 pro max",
    GIATHANH:32000000,
    HINHANH:"ip13.jpg",
    SOLUONG:100
  }
  ,
  {
   MATB:2,
    TENTB: "Laptop MacBook Pro 14 M1",
    GIATHANH:52000000,
    HINHANH:"macm1.jpg",
    SOLUONG:100
  }
  ,
  {
   MATB:3,
    TENTB: "Laptop Apple MacBook Air M1",
    GIATHANH:37000000,
    HINHANH:"macam1.jpg",
    SOLUONG:100
  }
])