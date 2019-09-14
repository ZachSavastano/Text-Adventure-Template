using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{

[SerializeField] public Text storyBody; //Attaches your story text Game Object
[SerializeField] public Room startingRoom; //Attach your starting room Room Scriptable Object

public InputField inputField;

public Room state; //Think of state as the current room

    void Start()
    {
        state = startingRoom; //Loads your chosen Room Scriptable Object
        storyBody.text = state.GetRoomStory(); // Originally was - textComponent.text = ("I am added programmatically!");
        Cursor.visible = false;
        inputField.ActivateInputField (); // Activates inputField right away 
    }

    void Update()
    {
    }   

    public void ChooseOptionA()
    {
        //var nextRooms = state.GetNextRooms(); //Old method
        //state = nextRooms[0]; //Old method
        state = state.exitPaths[0].connectingRoom;
        storyBody.text = state.GetRoomStory();
    }
    
    public void ChooseOptionB()
    {
            state = state.exitPaths[1].connectingRoom;
            storyBody.text = state.GetRoomStory();
    }
    
    public void ChooseOptionC()
    {
            state = state.exitPaths[2].connectingRoom;
            storyBody.text = state.GetRoomStory();
    }
    
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
