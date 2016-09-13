using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

#if UNITY_WEBGL && !UNITY_EDITOR
public class WebCommWebGL : IWebComm
{
    [DllImport("__Internal")]
    private static extern void Hello(string str);

    [DllImport("__Internal")]
    private static extern void HelloString(string str1, string str2, string str3, string str4);

    [DllImport("__Internal")]
    private static extern void PrintFloatArray(float[] array, int size);

    [DllImport("__Internal")]
    private static extern int AddNumbers(int x, int y);

    [DllImport("__Internal")]
    private static extern string StringReturnValueFunction();

    [DllImport("__Internal")]
    private static extern void BindWebGLTexture(int texture);




    MonoBehaviour eventHandler = null;
    private WebCommDelegate mDelegateObject = null;
    public WebCommWebGL(MonoBehaviour handler)
    {
        eventHandler = handler;
        mDelegateObject = handler as WebCommDelegate;
        Debug.Log("WebCommWegGL Construct!");
    }

    public void ExeTest()
    {
        Debug.Log("WebCommWebGL ExeTest...");
        Hello("abc");
    }

    public void ExeTest2()
    {
        Debug.Log("WebCommWebGL ExeTest2...");
        HelloString("hi", "my", "name", "is jung");
    }

    public void ExeTest3()
    {
        Debug.Log("WebCommWebGL ExeTest3...");
        float[] myArray = new float[10];
        PrintFloatArray(myArray, myArray.Length);
    }

    public void ExeTest4()
    {
        Debug.Log("WebCommWebGL ExeTest4...");
        int result = AddNumbers(5, 7);
        Debug.Log(result);
    }

    public void ExeTest5()
    {
        Debug.Log("WebCommWebGL ExeTest5...");
        Debug.Log(StringReturnValueFunction());
    }

    public void ExeTest6()
    {
        Debug.Log("WebCommWebGL ExeTest6...");
        var texture = new Texture2D(0, 0, TextureFormat.ARGB32, false);
        BindWebGLTexture(texture.GetNativeTextureID());
    }
}
#else
public class WebCommWebGL { }
#endif
