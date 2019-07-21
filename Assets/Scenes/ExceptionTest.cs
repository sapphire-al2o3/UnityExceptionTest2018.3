using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExceptionTest : MonoBehaviour
{
    [SerializeField]
    Text text = null;

    string a = null;
	string b = "aaa";
    Dictionary<string, int> dict = new Dictionary<string, int>();

    int Test()
    {
        try
        {
            return a.Length;
        }
        catch
        {
            return 0;
        }
    }

    int TestNullCheck()
    {
        if (a != null)
        {
            return a.Length;
        }
        return 0;
    }

	int Test1()
	{
		try
		{
			return b.Length;
		}
		catch
		{
			return 0;
		}
	}

	int TestNoTryCatch()
	{
		return b.Length;
	}

    int Test2(string key)
    {
        try
        {
            return dict[key];
        }
        catch
        {
            return 0;
        }
    }

    int Test3(string key)
    {
        return dict[key];
    }

    void Test4()
    {
        try
        {
            throw new System.Exception();
        }
        catch { }
    }

    public void RunTest()
    {
        float start = Time.realtimeSinceStartup;
        for (int i = 0; i < 100; i++)
        {
            Test2("a");
        }
        float elapsed = Time.realtimeSinceStartup - start;
        text.text = elapsed.ToString();
    }

    public void RunTest2()
    {
        float start = Time.realtimeSinceStartup;
        for (int i = 0; i < 100; i++)
        {
            Test2("b");
        }
        float elapsed = Time.realtimeSinceStartup - start;
        text.text = elapsed.ToString();
    }

    public void RunTest3()
    {
        float start = Time.realtimeSinceStartup;
        for (int i = 0; i < 100; i++)
        {
            Test3("b");
        }
        float elapsed = Time.realtimeSinceStartup - start;
        text.text = elapsed.ToString();
    }

    public void RunTest4()
    {
        float start = Time.realtimeSinceStartup;
        for (int i = 0; i < 100; i++)
        {
            Test2(null);
        }
        float elapsed = Time.realtimeSinceStartup - start;
        text.text = elapsed.ToString();
    }

    public void RunTest5()
    {
        float start = Time.realtimeSinceStartup;
        for (int i = 0; i < 100; i++)
        {
            Test();
        }
        float elapsed = Time.realtimeSinceStartup - start;
        text.text = elapsed.ToString();
    }

    public void RunTest6()
    {
        float start = Time.realtimeSinceStartup;
        for (int i = 0; i < 100; i++)
        {
            Test1();
        }
        float elapsed = Time.realtimeSinceStartup - start;
        text.text = elapsed.ToString();
    }

    public void RunTest7()
    {
        float start = Time.realtimeSinceStartup;
        for (int i = 0; i < 100; i++)
        {
            Test4();
        }
        float elapsed = Time.realtimeSinceStartup - start;
        text.text = elapsed.ToString();
    }

    void Start()
    {
        dict.Add("b", 0);
    }

    //void Update()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        float start = Time.realtimeSinceStartup;
    //        for (int i = 0; i < 100; i++)
    //        {
    //            Test2("a");
    //        }
    //        float elapsed = Time.realtimeSinceStartup - start;
    //        text.text = elapsed.ToString();
    //    }
    //}
}
