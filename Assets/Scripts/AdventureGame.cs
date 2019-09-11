using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{

[SerializeField] Text storyBody; //Attaches your story text Game Object
[SerializeField] Room startingRoom; //Attach your starting room Room Scriptable Object

public InputField inputField;

Room state;
ExitCollapsable states;

    void Start()
    {
        state = startingRoom; //Loads your chosen Room Scriptable Object
        storyBody.text = state.GetRoomStory(); // Originally was - textComponent.text = ("I am added programmatically!");
        Cursor.visible = false;
    }

    void Update()
    {
        inputField.ActivateInputField (); // Activates inputField right away 
    }   

    public void ChooseOptionA()
    {
        var nextRooms = state.GetNextRooms();
        state = nextRooms[0];
        storyBody.text = state.GetRoomStory();
    }
    
    public void ChooseOptionB()
    {
        var nextRooms = state.GetNextRooms();
        if (nextRooms.Length > 1)
        {
            state = nextRooms[1];
            storyBody.text = state.GetRoomStory();
        }
        else
        {}
    }
    
    /*
    public void ChooseOptionA() //Trying to pull the connecting rooms from the exitcollapsable section
    {
        //var nextRooms = state.GetNextRooms();
        var nextRooms2 = states.GetExits();
        if (nextRooms2.Length > 0)
        {
            states = nextRooms2[0];
            storyBody.text = state.GetRoomStory();
        }
        else
        {}
    }
    */
    
    
    /*
    public void ChangeRooms()
    {
    var nextRooms = state.GetNextRooms();
    
    for (int index = 0; index < nextRooms.Length; index++)
        {
            state = nextRooms[index];
        }
        
        storyBody.text = state.GetRoomStory();
    } 
    */
}
