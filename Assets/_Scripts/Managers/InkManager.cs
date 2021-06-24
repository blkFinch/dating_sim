using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

public class InkManager : MonoBehaviour
{
    [SerializeField]
    private TextAsset inkJson;
    private Story _inkStory;

    public static InkManager active;

    private string currentStoryText;
    public string GetCurrentStoryText(){
        return currentStoryText;
    }
    private List<Choice> currentChoices;

    public delegate void StoryUpdated();
    public static StoryUpdated onStoryUpdated;
    private void Awake()
    {
        _inkStory = new Story(inkJson.text);

        if (active == null) { active = this; }
        else { Destroy(this.gameObject); }
    }

    //TODO: change currentStoryText to a string array and fill it with seperate lines --- maybe????
    public void ReadStory(){
        currentStoryText = _inkStory.ContinueMaximally();
        currentChoices = _inkStory.currentChoices;
        onStoryUpdated();
    }

    public void ReadScene(string sceneName){
        _inkStory.ChoosePathString(sceneName);
        ReadStory();
    }


}
