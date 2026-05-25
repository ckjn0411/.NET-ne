namespace lesson2.repository;

public class Class1
{
}

// CODE FIRST | DATABASE FIRST
// ORM

// Thông thường để code làm việc được với DB.
    // Thì mình cần phải ánh xạ (mapping) từ các table lên code 
    // để dễ dàng thao tác với dữ liệu
    
// Databse first:
    // Minh lam viec voi 1 DB da co san (Create DB bang SQL)
    // Vo tao DB ne, setup cac field, cac mqh, rang buoc trong DB
    // Sau do o tren code su dung cac driver hoac thu vien ORM de ket noi xuong DB
    // O tren code se tao cac class tuong ung voi cac table trong DB
    // => Su dung khi minh da co san DB va dang duoc su dung a long time ago

// Code first:
    // Minh se khong setup DB thu cong bang cac cau lenh Query
        // Create Database, Create Constraint
    // Minh se Design DB bang cac class tren Code, tren code setup nhu the nao
        // Thi DB se duoc tao ra y chang
        // Minh setup tren code cac field, cac relationship
        // Sau do minh anh xa cac doan code do de tao ra cac table trong DB
    // Vay thi lam the nao de anh xa duoc tu code xuong cac table trong DB?
        // => ORM - Object Relational Mapping - Entity Framework
        // No se la thang trung gian dung giua lam nhieu thu
            // No se doc cac class tren code, doc cac attribute, doc cac cau hinh
            // Sau do tao ra cac cau lenh SQL de tao cac bang
        // No cung la thang ket hop voi LINQ
            // Khi su dung cac ham Where...., Translate sang SQL
            // .WHERE() => Select * sdfasfasdf
            
    // Thang nay duoc su dung khi: 
        // Minh moi bat dau du an, chua co DB nao ca
        // Thiet ke bang Code thi de~ maintain hon (de nhin, de doc, de sua) so voi cau lenh SQL