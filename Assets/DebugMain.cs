using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DebugMain : MonoBehaviour {

    static private DebugMain m_Instance;
    static public DebugMain _Inst { get { return m_Instance; } }
    public List<string> m_lstDebugMsg = new List<string>();

    string ver = "ver 1.1";

    void Awake()
    {
        m_Instance = this;
    }

	// Use this for initialization
    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 100), ver);

        int yHeight = 20;
        for (int i = 0; i < m_lstDebugMsg.Count; i++)
        {
            GUI.Label(new Rect(10, 50+(i * yHeight), 1500, 300), m_lstDebugMsg[i]);
        }
    }
}
