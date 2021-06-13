using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DateDisplay : MonoBehaviour
{
    private Text displayText;
    // Start is called before the first frame update

    private void Awake() {
        displayText = this.GetComponent<Text>();
    }
    void Start()
    {
        Calender.onNewDayCalled += DisplayDate;
        DisplayDate();
    }

    private void DisplayDate(){
        displayText.text = Calender.active.CurrentDateString();
    }

    private void OnDestroy() {
        Calender.onNewDayCalled -= DisplayDate;
    }
}
