using UnityEngine;
using System.Collections;

// 상속구조를 위한 것
public interface IAkozJava
{
    void AK_CommonCall(string str1, string str2, string str3, string str4);
    void AK_OpenURL(string userid);
}


public class AkozJava
{
    private IAkozJava mAkozJava;

    public AkozJava(MonoBehaviour eventHandler)
    {
        if ((eventHandler as AkozJavaDelegate) == null)
        {
            Debug.LogError("AkozJava : your GameObject " + eventHandler.name + " has to extend AkozJavaDelegate !");
            return;
        }

#if UNITY_WEBGL && !UNITY_EDITOR
        mAkozJava = new AkozJavaWebGL(eventHandler);
#elif UNITY_WEBPLAYER && !UNITY_EDITOR
        Debug.Log("1");
        mAkozJava = new AkozJavaWebPlayer(eventHandler);
#else
        mAkozJava = new AkozJavaCSharp(eventHandler as AkozJavaDelegate);
#endif
    }

    public void AK_CommonCall(string str1, string str2, string str3, string str4)
    {
        mAkozJava.AK_CommonCall(str1, str2, str3, str4);
    }

    public void AK_OpenURL(string userid)
    {
        mAkozJava.AK_OpenURL(userid);
    }
}
