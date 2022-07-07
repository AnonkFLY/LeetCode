using System;

public class Test
{
    public void TestAlgrothm()
    {
        var defaultData = new int[][]{
            new int[]{1,2,3},
            new int[]{4,5,6},
            new int[]{7,8,9},
        };
        TestAlgrothm<Solution104>(defaultData);
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
            Console.Write("错误:" + e);
        }
    }
}