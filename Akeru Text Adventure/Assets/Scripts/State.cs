using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "State")]
public class State : ScriptableObject {

    
    private string storyText;

    public string getStoryText() {
        return storyText;
    }
}
