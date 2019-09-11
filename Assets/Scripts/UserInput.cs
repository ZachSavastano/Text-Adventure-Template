using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq; //Need to use LINQ to do keyWords.Any

public class UserInput : MonoBehaviour
{
    public GameObject InputText;
    public InputField inputField;
    
    public GameObject gameManager;
    
    public Room currentRoom;

    string[] keyWords  = {"forward","continue"};
    string[] keyWords2 = {"back","go back"};
    
    void start()
    {
        if (currentRoom.numImportant == 1) 
            {
                Debug.Log("Success");
            } 
            
        keyWords = currentRoom.exitWords;
        //keyWords = Resources.Load<Script>(Room);
    }
    
    public void CheckTextEntry() // This is called by the inputField gameObject
    {  
        if(keyWords.Any(InputText.GetComponent<Text>().text.ToLower().Contains)) //ToLower() makes input case-insensitive
        //if (InputText.GetComponent<Text>().text.ToLower().Contains(keyWord)) //ToLower() makes input case-insensitive
        {
            Debug.Log("Headed In Direction 1");
            gameManager.GetComponent<AdventureGame>().ChooseOptionA();
        }
        
        else if(keyWords2.Any(InputText.GetComponent<Text>().text.ToLower().Contains))
        {
            Debug.Log("Headed In Direction 2");
            gameManager.GetComponent<AdventureGame>().ChooseOptionB();
        }
        
    /*
        if(keyWords.Any(InputText.GetComponent<Text>().text.ToLower().Contains)) //ToLower() makes input case-insensitive
        //if (InputText.GetComponent<Text>().text.ToLower().Contains(keyWord)) //ToLower() makes input case-insensitive
        {
            Debug.Log("Success!");
            gameManager.GetComponent<AdventureGame>().ChangeRooms();
        }
    */ 
        

        inputField.ActivateInputField (); //Re-activates the input field for typing	
        inputField.text = null; //Blanks out the field for the next input
    }
    
}