using UnityEngine;
using UnityEngine.UI;


public class TimeTableToggle : MonoBehaviour
{
    public GameObject TimeTableImage;
    public GameObject infoText;

    void Start()
    {
      TimeTableImage.SetActive(false);
      infoText.SetActive(false);
    }

    public void ToggleTimeTable()
    {
        if (!TimeTableImage.activeSelf)
        {
            // Timetable is hidden: show it and hide the info text
            TimeTableImage.SetActive(true);
            infoText.SetActive(false);
        }
        else
        {
            // Timetable is visible: hide it and show the info text
            TimeTableImage.SetActive(false);
            infoText.SetActive(true);
        }
    }

}
