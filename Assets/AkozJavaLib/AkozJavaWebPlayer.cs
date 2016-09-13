using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

#if UNITY_WEBPLAYER && !UNITY_EDITOR

public class AkozJavaWebPlayer : IAkozJava
{

    [DllImport("__Internal")]
    private static extern void CommonCall_AK(string str1, string str2, string str3, string str4);


    MonoBehaviour eventHandler = null;
    private AkozJavaDelegate mDelegateObject = null;
    public AkozJavaWebPlayer(MonoBehaviour handler)
    {
        eventHandler = handler;
        mDelegateObject = handler as AkozJavaDelegate;
        Debug.Log("AkozJavaWebPlayer Construct!!");
    }

    public void AK_CommonCall(string str1, string str2, string str3, string str4)
    {

        Debug.Log("AkozJavaWebPlayer CommonCall_AK()!!");
    }

    public void AK_OpenURL(string userid)
    {
        Debug.Log("AkozJavaWebPlayer AK_OpenURL()!!");
    }
}
#else
public class AkozJavaWebPlayer { }
#endif
