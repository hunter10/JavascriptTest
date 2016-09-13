using UnityEngine;
using System.Collections;

public class AkozJavaMng : MonoBehaviour, AkozJavaDelegate
{
    private AkozJava mAkozJava = null;

    void Start()
    {
        mAkozJava = new AkozJava(this);
    }

    public void OnCommonCall(string str1, string str2, string str3, string str4)
    {
        mAkozJava.AK_CommonCall(str1, str2, str3, str4);
    }

    public void OnOpenURL(string userid)
    {
        mAkozJava.AK_OpenURL(userid);
    }
}
