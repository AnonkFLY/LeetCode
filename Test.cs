using System;

public class Test
{
    public void TestAlgrothm()
    {
        // [[5,1,9,11],[2,4,8,10],[13,3,6,7],[15,14,12,16]]
        TestAlgrothm<Solution>(new int[][]{
            new int[]{1,2,3},
            new int[]{4,5,6},
            new int[]{7,8,9},
        });
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