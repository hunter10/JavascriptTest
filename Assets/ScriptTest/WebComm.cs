using UnityEngine;
using System.Collections;

public interface IWebComm
{
    void ExeTest();
    void ExeTest2();
    void ExeTest3();
    void ExeTest4();

    void ExeTest5();
    void ExeTest6();
}

public class WebComm 
{
    private IWebComm mWebComm;

    public WebComm(MonoBehaviour eventHandler)
    {
        if ((eventHandler as WebCommDelegate) == null)
        {
            Debug.LogError("WebComm : your GameObject " + eventHandler.name + " has to extend WebCommDelegate !");
            return;
        }

#if UNITY_WEBGL && !UNITY_EDITOR
        mWebComm = new WebCommWebGL(eventHandler);
#else
        mWebComm = new WebCommCSharp(eventHandler as WebCommDelegate);
#endif
    }

    public void ExeTest()
    {
        //Debug.Log("ExeTest...");
        mWebComm.ExeTest();
    }

    public void ExeTest2()
    {
        mWebComm.ExeTest2();
    }

    public void ExeTest3()
    {
        mWebComm.ExeTest3();
    }

    public void ExeTest4()
    {
        mWebComm.ExeTest4();
    }

    public void ExeTest5()
    {
        mWebComm.ExeTest5();
    }

    public void ExeTest6()
    {
        mWebComm.ExeTest6();
    }
}
