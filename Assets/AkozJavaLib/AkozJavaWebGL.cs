using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

#if UNITY_WEBGL && !UNITY_EDITOR
public class AkozJavaWebGL : IAkozJava
{
    [DllImport("__Internal")]
    private static extern void CommonCall_AK(string str1, string str2, string str3, string str4);

    [DllImport("__Internal")]
    private static extern void OpenURL_AK(string userid);

    MonoBehaviour eventHandler = null;
    private AkozJavaDelegate mDelegateObject = null;
    public AkozJavaWebGL(MonoBehaviour handler)
    {
        eventHandler = handler;
        mDelegateObject = handler as AkozJavaDelegate;
        Debug.Log("AkozJavaWebGL Construct!!");
    }

    public void AK_CommonCall(string str1, string str2, string str3, string str4)
    {
        Debug.Log("AkozJavaWebGL AK_CommonCall()!!");
                
        string msg = string.Format("{0}, {1}, {2}. {3}", str1, str2, str3, str4);
        DebugMain._Inst.m_lstDebugMsg.Add(msg);

        CommonCall_AK(str1, str2, str3, str4);
    }

    public void AK_OpenURL(string userid)
    {
        Debug.Log("AkozJavaWebGL AK_OpenURL()!!");
        OpenURL_AK(userid);
    }
}
#else
public class AkozJavaWebGL { }
#endif