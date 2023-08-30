using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    [SerializeField]  private Button startButton;
    [SerializeField] private TMP_InputField nameInput;
    public GameObject mainMenu;

    public string name;
    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick()
    {
        if (nameInput.text=="")
    {
        name="Unknown";
        mainMenu.GetComponent<DataFromMenu>().name = name;
    }
    else
    {
        name=nameInput.text;
        Debug.Log("Setting name...");
        mainMenu.GetComponent<DataFromMenu>().name = nameInput.text;
        Debug.Log("Set name " + mainMenu.name);
        DontDestroyOnLoad(mainMenu);
        
    }   
        name = nameInput.text;
        Debug.Log("Should move to a new scene now");
        SceneManager.LoadScene(1, LoadSceneMode.Single);
        
    }


    

}
