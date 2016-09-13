using UnityEngine;
using System.Collections;

public class WebCommMain : MonoBehaviour, WebCommDelegate
{
    private WebComm mWebComm = null;

    void Start()
    {
        mWebComm = new WebComm(this);
    }

    public void OnExeTest()
    {
        mWebComm.ExeTest();
    }

    public void OnExeTest2()
    {
        mWebComm.ExeTest2();
    }

    public void OnExeTest3()
    {
        mWebComm.ExeTest3();
    }

    public void OnExeTest4()
    {
        mWebComm.ExeTest4();
    }

    public void OnExeTest5()
    {
        mWebComm.ExeTest5();
    }

    public void OnExeTest6()
    {
        mWebComm.ExeTest6();
    }
}
