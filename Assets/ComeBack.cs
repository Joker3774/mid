using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class ComeBack : MonoBehaviour
{
    
    public GameObject ButtonName;

    void Awake()  //執行一次
    {
        //Debug.Log(gameObject.name);
        gameObject.GetComponent<Button>().onClick.AddListener(Comeback);
      
    }
   

    public void Comeback()
    {
        SceneManager.LoadScene("TestScene");
        
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
