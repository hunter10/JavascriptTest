using UnityEngine;
using System.Collections;

public class WebCommCSharp : IWebComm
{
    private WebCommDelegate mDelegateObject;

    public WebCommCSharp(WebCommDelegate delegateObject)
    {
        mDelegateObject = delegateObject;
        Debug.Log("WebCommCSharp Construct!");
    }


    //MonoBehaviour eventHandler = null;
    //private WebCommDelegate mDelegateObject = null;
    //public WebCommWebGL(MonoBehaviour handler)
    //{
    //    eventHandler = handler;
    //    mDelegateObject = handler as WebCommDelegate;
    //    Debug.Log("WebCommWegGL Construct!");
    //}

    public void ExeTest()
    {
        Debug.Log("WebCommCSharp ExeTest...");
        //Hello();
    }

    public void ExeTest2()
    {
        Debug.Log("WebCommCSharp ExeTest2...");
        //HelloString("This is a string.");
    }

    public void ExeTest3()
    {
        Debug.Log("WebCommCSharp ExeTest3...");
        float[] myArray = new float[10];
        //PrintFloatArray(myArray, myArray.Length);
    }

    public void ExeTest4()
    {
        Debug.Log("WebCommCSharp ExeTest4...");
        //int result = AddNumbers(5, 7);
        //Debug.Log(result);
    }

    public void ExeTest5()
    {
        Debug.Log("WebCommCSharp ExeTest5...");
        //Debug.Log(StringReturnValueFunction());
    }

    public void ExeTest6()
    {
        Debug.Log("WebCommCSharp ExeTest6...");
        //var texture = new Texture2D(0, 0, TextureFormat.ARGB32, false);
        //BindWebGLTexture(texture.GetNativeTextureID());
    }

}
