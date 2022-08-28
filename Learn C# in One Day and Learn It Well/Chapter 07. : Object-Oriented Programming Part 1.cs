* C#의 Main() 메소드
   -->   If we want, we can change the name of the Program class to something else, but the Main()
         method must be called Main(). The Main() method must be present in all C# programs.
         
  🔵 Fields : A field is simply a variable that is declared inside a class.
  
        private string nameOfStaff;
        private const int hourlyRate = 30;
        private int hWorked;                      현재 이렇게 추가했다.
        
        🟠 책에서는 왜 우리가 접근 제어자인 private를 사용한 이유에 대해 설명해준다.

        Notice that there is a word private in front of each declaration statement?
        This is known as an access modifier. Access modifiers are like gate
        keepers, they control who has access to that field (i.e. who can read and 
        modify the value of that field).           
                                                     // i.e. : 다시 말해서
                                                     
        There are two reasons why we do not want the three fields to be accessible outside the class.
        
     1. The first reason is that there is no need for other classes to know about those fields.
        // 첫 번째 이유는 다른 클래스에서 이곳 클래스의 필드를 알 필요가 없다.
        
        * 캡슐화에 대한 간략한 설명
        This is known as encapsulation. Encapsulation enables an object to hide
        data and behaviour from other classes that do not need to know about them.
        This makes it easier for us to make changes to our code in future if
        necessary. We can safely change the value of hourlyRate inside Staff class
        without affecting other classes.
        
        // Encapsulation : 캡슐화    (캡슐화는 은닉성을 포함하고 있음)
        
     2. The second reason for declaring a field as private is that we do not want
        other classes to freely modify them. 
        This helps to prevent the fields from being corrupted.
        // private로 선언한 두 번째 이유는, 다른 클래스에서 이것들을 자유롭게 수정하는 것을 원치 않기 때문이다.
           이것은 필드가 부패되는 것을 방지해준다.
        
        
  🔵 Properties 
      
    --> A property is commonly used to provide access to a private field in cases where the field is needed by other classes.
    
   ✅ 여기서 드는 의문점) private 접근 제한자를 사용했으면서 왜 프로퍼티를 사용해서 접근이 가능하도록 하는 걸까???
     
        This may sound like a contradiction. Earlier, we mentioned that we use private fields so that other
        classes do not have access to them. If that is the case, why are we allowing
        access to them via properties?            
                                               * contradiction 뜻 : 모순
  
        여기에 대한 의문을 살짝 알려준다.
        
        One of the main reasons is that using properties gives us greater control
        over what rights other classes have when assessing these private fields.
        We’ll see how to do that later.  
        // 프로퍼티를 사용하면 우리는 커다란 권한을 얻는다.
           private 필드를 할당할 때 다른 클래스들이 가지는 권한을 말이다.
  
--------------------

   // A property contains two special methods known as accessors. The first accessor is a getter and the second is a setter.
   
using System;

class circle
{
    private int x;
    private int y;
    private double radius;

    public int X   // 프로퍼티 이름 : X
    {
        get { return x; }
        set { x = value; }      // value is a keyword when it used inside a setter.
    }

    public int Y  // 프로퍼티 이름 : Y
    {
        get { return y; }
        set { y = value; }
    }

    public double Radius  // 프로퍼티 이름 : Radius
    {
        get { return radius; }
        set { radius = value; }
    }
}
class C_sharp_book
{
    public static void Main()
    {
        circle c1 = new circle();
        circle c2 = new circle();

        c1.X = 13;
        c1.Y = 50;
        c1.Radius = 10.62;

        c2.X = 10;
        c2.Y = 15;
        c2.Radius = 20.52;

        Console.WriteLine("c1의 중심점: {0}, {1}\nc1의 반지름: {2}", c1.X, c1.Y, c1.Radius);
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("c2의 중심점: {0}, {1}\nc2의 반지름: {2}", c2.X, c2.Y, c2.Radius);
    }
}
--------------------  
                                    이렇게 줄일 수도 있다. 
using System;

class circle
{                             // 따로 private 필드를 선언해주지 않아도 된다.
    public int X 
    {
        get;            // 자동구현 프로퍼티라고 한다. (Auto-implemented Properties)
        set;
    }

    public int Y
    {
        get;
        set;
    }

    public double Radius
    {
        get;
        set;
    }
}
class C_sharp_book
{
    public static void Main()
    {
        circle c1 = new circle();
        circle c2 = new circle();

        c1.X = 13;
        c1.Y = 50;
        c1.Radius = 10.62;

        c2.X = 10;
        c2.Y = 15;
        c2.Radius = 20.52;

        Console.WriteLine("c1의 중심점: {0}, {1}\nc1의 반지름: {2}", c1.X, c1.Y, c1.Radius);
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("c2의 중심점: {0}, {1}\nc2의 반지름: {2}", c2.X, c2.Y, c2.Radius);
    }
}
  
           프로퍼티에 대하여 도움이 되는 블로그 : https://dev-junwoo.tistory.com/93#3.%20Private%20Set%20/%20init
                                                 https://constructionsite.tistory.com/38
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
