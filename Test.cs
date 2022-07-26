using System;

public class Test
{
    public void TestAlgrothm()
    {
        TestAlgrothm<Solution>(null);
    }

    // public void Print(object text)
    // {
    //     Console.Write(text);
    // }

    private void TestAlgrothm<T>(object data) where T : new()
    {
        try
        {
            ITestable obj = (ITestable)new T();
            obj.Test(data);
        }
        catch (Exception e)
        {
            Console.Write("\n错误:" + e);
        }
    }
}