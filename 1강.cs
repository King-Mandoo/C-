2022. 07. 04. 월

1.1 닷넷 프레임워크 (.NET Framework)

3.1 기본 자료형
  
 3.1.1 정수형 기본 타입
 
     --> 컴퓨터는 태상 자체가 0과 1이라는 비트(bit)로 구성돼 있기 때문에 오직 '숫자'만이 의미가 있다.
         즉, 컴퓨터 세상에서는 모든 것이 숫자인데, 사실은 알파벳조차도 'A'는 65, 'B'는 66, ... 과 같은 식으로 각각 대응되는 숫자로
         약속돼 있다.
         
         sbyte :  -128 ~ 127                                            부호 있는 8비트 정수
          byte :  0 ~ 255                                               부호 없는 8비트 정수
         short :  -32,768 ~ 32,767                                      부호 있는 16비트 정수
         ushort : 0 ~ 65,535                                            부호 없는 16비트 정수
         int : -2,147,483,648 ~ 2,147,483,647                           부호 있는 32비트 정수
         uint : 0 ~ 4,294,967,295                                       부호 없는 32비트 정수
         long : -9,223,372,036,854,775,808 ~ 9223,372,036,854,775,807   부호 있는 64비트 정수
         ulong : 0 ~ 18,446,744,073,709,551,615                         부호 없는 64비트 정수
         
         왜 이렇게 나눠야만 했을까?
         그 이유는 저장 공간의 효율을 높이기 위해서다.
         

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        { 
            int n1 = 50;  // 32비트 정수형
            int n2;
            n2 = 100;

            long sum = n1 + n2;   // 64비트 정수형

            Console.WriteLine(sum);   // 출력 결과: 200
        }
    }
}

  
  3.1.2 실수형 기본 타입
   
     --> float    4바이트
         double   8바이트
         decimal  16바이트

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            float f = 5.2f;
            double d = 10.5;
            decimal money = 200.099m;   // decimal의 경우네는 소수점을 포함하는 경우 m을 붙여야 한다.

            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(money);
        }
    }
}
