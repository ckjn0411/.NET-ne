// See https://aka.ms/new-console-template for more information

namespace Lesson.buoi1;

class Program
{
    static void Main(string[] args)
    {
        // co bao nhiêu kiểu dữ liệu khi chúng ta học lập trình? 
        // Primitive & Reference
        
        // Value type (Primitive) & Reference type
        /*
         * 
         *
         *
         * 
         */

        // int a = 3;
        // int b = 5;
        // Console.WriteLine(a + b);
        //
        // Khi 1 bien duoc khoi tao thi no de cap den 2 vung nho
            // STACK vs HEAP
            
        // Reference Type
            // string
            // array
            // class: Student, Person.....
            // interface
        
            
        // Class vs Object khac nhau the nao?
            // Object la 1 the hien (instance) cua 1 class
                // Vi du: Khi nhac toi class hoc sinh, thi chung ta se co cac instance
                // nhu la: Hoc Sinh Trinh,...
            // Class co the coi nhu la 1 cai khuon, cai khuon nay ben trong co thuoc tinh, method,...
        
        // Khi luu ValueType thi co may vung nho duoc su dung?
        // int d = 3; // Bien d la 1 bien cuc bo, no duoc luu o STACK
        
        // 1 bien co kieu la ValueType thi co duoc ton tai trong HEAP khong?
            // ==> CO', khi khai bao 1 field co kieu la Value Type nam trong Class
            
        // Class Student
        // {
        //     Name 
        //     Age // 2
        // }
        
        // Student p1 = new Student()
        // Student p2 = p1
            // p1 va p2 se nam trong Stack va cung tro toi vung object nam tren HEAP
        
        // The nao la Static?
            // Static la 1 vung nho dac biet, nam rieng biet so voi STACK va HEAP
            // la 1 vung nho dung chung, duoc cap phat va ton tai suot vong doi cua app

            int a = 10;
            int b = 20;
            
        // Traditional Style
        Console.WriteLine("Number a = " + a);
        Console.WriteLine("Number b = " + b);
        
        // Modern Style - Placeholder
        Console.WriteLine("Number a = {0}", a);
        Console.WriteLine("Number b = {0}", b);
        
        
        // FUNCTION - METHOD
        // Co 4 kieu ham
        // Pass by value
        static void PasByValue(int a)
        {
            // Thang a nay chi muon gia tri cua x, a chi 
            // ton tai trong cai ham nay thoi
            a = 100; // --> Bien cuc bo
            Console.WriteLine(a);
        }

        int x = 1;
        PasByValue(x);
        Console.WriteLine(x);
        
        // Pass by Reference (out, ref)
        // C# no cung cap them 2 mon la lien quan den tham so cua ham
        // Tham so truyen vao la 1 con tro
        // out: tra ra gia tri thong quan den out
        // ref: truyen vao 1 bien co san, ham co the thay doi gia tri cua bien do
        // 2 thang nay giup mo rong viec tra ve cua 1 cai ham
        
        // Ref la gi??
            // No giong nhu la con trong C
            // Thay doi o ngoai thi ben trong cung thay doi 
            // va nguoc lai
            // Khi choi voi bien ref thi bat buoc phai bien do truoc khi truyen vao
                // (Phai khai bao gia tri)

                static void PassByRef(ref int a)
                {
                    a = 100;
                }

                int m = 10;
                Console.WriteLine("Before PassByValue, m = " + m);
                PassByRef(ref m);
                Console.WriteLine("After PassByValue, m = " + m);
                
        // Out la gi???
        // Khi choi voi out la bat buoc ben trong phai sua lai tham so
            // sua lai gia tri cua bien out
        // tui hua' se tra cho ban 1 con so
        static void PassByOut(out int a)
        {
            a = 100;
        }

        int n = 10;
        PassByOut(out n);
        Console.WriteLine(n);
        
        
        // Viet ham tinh tong cua cac so tu 1 -> n
        // Khong dung return nhung van duoc gia tri
        // sau khi tinh tong
        static void Sum(int n, ref int sum)
        {
            sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += i;
            }
        }

        int sum = 0;
        Sum(10, ref sum);
        Console.WriteLine(sum);
    }
}