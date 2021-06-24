using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventDisplay : MonoBehaviour
{
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        InkManager.onStoryUpdated += DisplayEventText;
    }

    private void DisplayEventText(){
        text.text = InkManager.active.GetCurrentStoryText();
    }

    private void OnDestroy() {
        InkManager.onStoryUpdated -= DisplayEventText;
    }
}
