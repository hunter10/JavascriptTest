using UnityEngine;
using System.Collections;

public class AkozJavaCSharp : IAkozJava
{
    private AkozJavaDelegate mDelegateObject;

    public AkozJavaCSharp(AkozJavaDelegate delegateObject)
    {
        mDelegateObject = delegateObject;
        Debug.Log("AkozJavaCSharp Construct!!");
    }

    public void AK_CommonCall(string str1, string str2, string str3, string str4)
    {

        Debug.Log("AkozJavaCSharp CommonCall_AK()!!");
        
        //string msg = string.Format("{0}, {1}, {2}. {3}", str1, str2, str3, str4);
        //DebugMain._Inst.m_lstDebugMsg.Add(msg);

        //CommonCall_AK(str1, str2, str3, str4);

    }

    public void AK_OpenURL(string userid)
    {
        Debug.Log("AkozJavaCSharp AK_OpenURL()!!");
    }
}
