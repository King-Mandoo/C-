
🔵 GetType() and typeof()
   
    --> The GetType() method returns the runtime type of an object.
    
        The typeof() method takes the name of a data type (e.g. int, float, or the
        name of a class) and returns the type of that name, which we can then
        compare with the result of the GetType() method on the left.
        
        정리하자면 GetType()는 인스턴스의 형식을 호출하고, 
        typeof()는 클래스의 형식을 호출한다.
        
---------------------------------------     
                                    * 위의 클래스들은 생략.
class C_sharp_book
{
    public static void Main()
    {

        Member[] clubMembers = new Member[5];    // We declare an array of Member type and add 5 members.

        clubMembers[0] = new NormalMember("Special Rate", "James", 1, 2010);
        clubMembers[1] = new NormalMember("Normal Rate", "Andy", 2, 2011);
        clubMembers[2] = new NormalMember("Normal Rate", "Bill", 3, 2011);
        clubMembers[3] = new VIPMember("Carol", 4, 2012);
        clubMembers[4] = new VIPMember("Evelyn", 5, 2012);

        foreach (Member m in clubMembers)
        {
            m.CalculateAnnualFee();
            Console.WriteLine(m.ToString());
        }

        if (clubMembers[0].GetType() == typeof(VIPMember))    // NO 출력
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
            
        Console.WriteLine(clubMembers[0].GetType());      // NormalMember 출력
        Console.WriteLine(clubMembers[4].GetType());      // VIPMember 출력
        Console.WriteLine(typeof(NormalMember));          // NormalMember 출력
        Console.WriteLine(typeof(VIPMember));             // VIPMember 출력
    }
}
