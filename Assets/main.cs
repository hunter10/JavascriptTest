using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class main : MonoBehaviour 
{
    AkozJavaMng mAkozJavaMng = null;

    float startTime;
    float deltaTime;
    string nowtime;


	// Use this for initialization
	void Start () 
    {
        mAkozJavaMng = gameObject.AddComponent<AkozJavaMng>();

        string msg = string.Format(" {0}\n {1}\n {2}\n", "A key TimeStart!", "B Key CommonCall", "C Key OpenURL");
        DebugMain._Inst.m_lstDebugMsg.Add(msg);
	}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("a");

            nowtime = DateTime.Now.ToString("yyyyMMddhhmmss");
            Debug.Log(nowtime);

            startTime = Time.time;
            deltaTime = Time.time;

            string msg = string.Format("{0}, {1}", "start", nowtime);
            DebugMain._Inst.m_lstDebugMsg.Add(msg);
        }

        if(Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("b");

            deltaTime = Time.time - deltaTime;
            string lasttime = DateTime.Now.ToString("yyyyMMddhhmmss");
                        
            mAkozJavaMng.OnCommonCall("123", "test", nowtime, lasttime);
        }


        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("c");

            mAkozJavaMng.OnOpenURL("abc");
        }
    }



}
