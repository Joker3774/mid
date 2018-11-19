using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManager : MonoBehaviour
{
    public MsgPanelHandler Panel;
     
	void Start () {
        
		Panel.gameObject.SetActive(true);
	    Panel.Title = "系統訊息";
	    Panel.Content = "左轉白天，右轉黑夜。\n";
	    Panel.YesText = "左轉";
	    Panel.NoText = "右轉";
      
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
