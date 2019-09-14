using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//[CreateAssetMenu(menuName = "TextAdventure/Room")]
[CreateAssetMenu(menuName = "Room")]
public class Room : ScriptableObject
{
    public Sprite roomImage;
    public bool roomImageFadeIn;

    [TextArea(1,10)] public string storyText; //Room description
    [TextArea(1,10)] [SerializeField] public string devNotes; //Developer notes on room
    
    //[SerializeField] Room[] exits;
    
    public ExitCollapsable[] exitPaths;
    
    //public Room[] exitPaths;
        
    //public string[] exitWords = {"go","onward"};
    

    public void Update() //Trying to get roomImage to appear on room change
    {
         GameObject go = new GameObject("Test");
         SpriteRenderer renderer = go.AddComponent<SpriteRenderer>();
         renderer.sprite = roomImage;
    }
    
    
    public string GetRoomStory()
    {
        return storyText;
    }
    
    
    //public Room[] GetNextRooms()
    //{
    //    return exits;
    //}
    
    
    /*
    public ExitCollapsable[] GetNextRooms()
    {
        return exitPaths;
    }
    */
}

[System.Serializable]
public class ExitCollapsable : System.Object
{
    public Room connectingRoom;
    public string[] exitKeywords;
	[TextArea(1,10)] public string exitDescription;
    
    /*
    public ExitCollapsable[] GetNextRooms()
    {
        return exitPaths;
    }    
    */
    
}

