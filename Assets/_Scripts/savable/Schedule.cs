using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Schedule 
{
    // Savable List of event ids
  public List<int> scheduledEvents;

  public Schedule(){
      scheduledEvents = new List<int>();
  }
}
