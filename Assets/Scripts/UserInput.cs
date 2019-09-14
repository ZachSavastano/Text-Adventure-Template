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
    
    public void CheckTextEntry() // This is called by the inputField gameObject
    {  
        //if (InputText.GetComponent<Text>().text.ToLower().Contains(keyWord)) //Old if statement
        
        if ((gameManager.GetComponent<AdventureGame>().state.exitPaths.Length > 0) && (currentRoom.exitPaths[0].exitKeywords.Any(InputText.GetComponent<Text>().text.ToLower().Contains)))
        {
            Debug.Log("Headed In Direction 1");
            gameManager.GetComponent<AdventureGame>().ChooseOptionA();
        }
        
        if ((gameManager.GetComponent<AdventureGame>().state.exitPaths.Length > 1) && (currentRoom.exitPaths[1].exitKeywords.Any(InputText.GetComponent<Text>().text.ToLower().Contains)))
        {
            Debug.Log("Headed In Direction 2");
            gameManager.GetComponent<AdventureGame>().ChooseOptionB();
        }
        
        if ((gameManager.GetComponent<AdventureGame>().state.exitPaths.Length > 2) && (currentRoom.exitPaths[2].exitKeywords.Any(InputText.GetComponent<Text>().text.ToLower().Contains)))
        {
            Debug.Log("Headed In Direction 3");
            gameManager.GetComponent<AdventureGame>().ChooseOptionC();
        }  
        
        else
        {}
        
        //(currentRoom.exitPaths.Length > 2)
        
        inputField.ActivateInputField (); //Re-activates the input field for typing	
        inputField.text = null; //Blanks out the field for the next input
    }
    
}