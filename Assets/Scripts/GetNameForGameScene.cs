using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GetNameForGameScene : MonoBehaviour
{
    public Text headerWithName;
    public Text headerWithHighScore;
    public GameObject menuData;
    // Start is called before the first frame update
    void Start()
    {
           menuData = GameObject.Find("MenuData");
           headerWithName.text = menuData.GetComponent<DataFromMenu>().name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
