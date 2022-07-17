표준 출력 
            Console.Write()  /  Console.WriteLine()            static(정적 메서드) 이기 때문에 바로바로 사용 가능.

-----------------------------------------
public class MyClass
{
   private int val = 1;
   
   // 인스턴스 메서드
   public int InstRun()
   {
      return val;
   }
   
   // 정적(Static) 메서드
   public static int Run() 
   {
      return 1;
   }
}

public class Client
{
   public void Test()
   {
      // 인스턴스 메서드 호출
      MyClass myClass = new MyClass();
      int i = myClass.InstRun();

      // 정적 메서드 호출
      int j = MyClass.Run();
   }
}
-------------------------------------

            Console.WriteLine("Hello, World!");

            Console.WriteLine("{0} {1}", 3.14f, 12);     // 이런 식으로 표현도 가능하구나 .

            Console.WriteLine("{0} + {1} = {2}", 2, 4, 2 + 4);

            Console.WriteLine("{0:C} {1:P} {2:X}", 123, 123.45, 125); 
