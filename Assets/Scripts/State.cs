using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(10,14)] 
    [SerializeField] 
    string storyText;

    [SerializeField]
    State currentState;

    [SerializeField] 
    State[] nextStates;


    public string GetStateStory()
    {
        return storyText;
    }

    public State GetCurrentState()
    {
        return currentState;
    }
    public State[] GetNextStates()
    {
        return nextStates;
    }
}
