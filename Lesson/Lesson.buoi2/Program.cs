// See https://aka.ms/new-console-template for more information

namespace Lesson.buoi2;
class Program
{
    public class Student
    {
        // Instance Variables - BIEN MA DUNG DE LUU INFO CUA 1 OBJECT
        
        // BACKEND-FIELD, DATA FIELD - BIEN DUNG DE LUU INFO CUA 1 OBJECT (Ten goi cua C#)
        
        // Neu khong ghi public, private (Khong khai bao access modifier) thi mac dinh la Private
        
        private string _id = "123";
        private string _name;
        private int _age;
        // DEFAULT VALUE
        // Khi ma minh khoi tao 1 field ma khong gan gi ca, thi field do se co 1 gia tri mac dinh
        // string: null
        // int = 0
        // bool: false
        // object: null
        // array: null

        // Constructor - HAM KHOI TAO OBJECT
            // Overloading
        // public Student(string id, string name, int age)
        // {
        //     _id = id;
        //     _name = name;
        //     _age = age;
        // }
        // public Student(string id, string name)
        // {
        //     _id = id;
        //     _name = name;
        //     _age = 0;
        // }
        // Empty Constructor
            // La Constructor duoc tao tu dong theo moi~ class
        // public Student()
        // {}
        //
        // GET A DATA FIELD
            // Traditional Style
            // public string GetName()
            // {
            //     // Mac du _name private nhung vi o trong pham vi la class 
            //     // thi chung ta van lay duoc
            //     return _name;
            // }
            //
            // public void SetName(string newName)
            // {
            //     _name = newName;
            // }
            
            // .NET cũng cung cấp 1 cái giúp viê 1 hàm tiện hơn - Expression Body
                // Khi body cua 1 ham, chi co 1 cau lenh duy nhat, thi co the viet
                // public string GetId() => _id;
                // public void setAge(int age) => _age = age; 
        
        public static string Id { set; get; }
        public string Name { set; get; }
        public int Age { set; get; }
        
        
        
        public void ShowInfo() => Console.WriteLine($"{_id} {_name} {_age}");
    }
    static void Main(string[] args)
    {
        
        // 4 tinh chat co ban cua OOP
            // 1. Encapsulation (Dong goi)
                // Dong goi nhung thuoc tinh, method va 1 class hoan chinh, 1 cai khuon
                // Cung cap kha nang modalarity (modun hoa', chia nho ra, de quan ly)
                // Bao ve tinh toan ven cua du lieu
                    // -> Chi co the truy cap thong qua cac Access Modifier
                    // Hoac la cac ham get, set
            // 2. Inheritance (Ke thua)
                // De cap den kha nang ke thua, tai su dung lai code cu
                // Khi class B ke thua lai class A, thi class B se chua code rieng cua no
                    // va chua ca code cua A. Code o day la property va Method
            // 3. Polymorphism (Da hinh)
                // De cap den kha nang the hien cac Class va Action theo nhieu cach khac nhau
                // Vi du: cac interface, Abstract Class, Class thong qua viec Implement cac interface
                    // hoac Inheritance cac method (Override || Overload)
                // Moi class se the hien ban sac rieng cua no thong qua Implement or ke thua
                // Tinh Da Hinh nay la 1 tinh chat CUC KI CUC KI quan trong trong viec hinh thanh,
                    // 1 cong nghe loi~ cua .NET la (Dependency Injection) -> Polymorphism, Abstraction
            // 4. Abstraction (Truu tuong)
                // Bien nhung thu phuc tap thanh nhung thu co ban ma khong mat chat
                // Vi du: 1 Hoc sinh thi co nhung tinh chat mo ho nhu: ten, tuoi, nam sinh, cac loai hanh dong
                    // nhu la hoc. Viec choi nhu the nao, hoc nhu the nao, thi tu tu tinh. Thi nhung thu phuc
                    // tap o day la nhung hanh dong cu the nhu la choi the nao, ro rang cu the hon/
                // => hoc sinh chi co nhung hanh dong don gian hon nhu la Choi va Hoc (Abstract Method)
                
        
        // Dinh nghia them Static
            // "Static giong nhu 1 thang ngoi tren cao coi may thang o duoi danh nhau"
            // thang nao la static thi ra chieu khac ngoi` (vung nho rieng)
            // Cai nao ma an theo Object thi khong nen su dung Static (Da~ demo case s1 va s2)
                // vi du: Ten Nguoi, tuoi, ma so la an theo tung nguoi -> NON-STATIC
                
            // Khi nao ta dung Static vay: 
                // Cac bo do choi (Cac tool, ham tai su dung)
                // Cac hang so,...
                
                
    }
    
    
}
