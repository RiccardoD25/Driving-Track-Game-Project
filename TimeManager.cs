using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Text TimeText;
    public Text Speed;
    public Text LapCount;
    public Text BestLapText;

    // Start is called before the first frame update
    void Start()
    {
        ApplicationData.MyTime = 0;
        float Bminutes = Mathf.FloorToInt(ApplicationData.Bestlap / 60);
        float Bseconds = Mathf.FloorToInt(ApplicationData.Bestlap % 60);
        BestLapText.text = string.Format("BEST COMPLETED LAP: {0:00}:{1:00}", Bminutes, Bseconds);
        LapCount.text = "LAPS COMPLETED: " + ApplicationData.LapCount.ToString();
        Speed.text = "SPEED: " + ApplicationData.CurrentZvelocity.ToString("00.00");
    }

    // Update is called once per frame
    void Update()
    {
        ApplicationData.MyTime += Time.deltaTime;//time goes up by 1/72 =0.01388889
        DisplayTime(ApplicationData.MyTime);//call the func DisplayTime, pass the running time as an argument
                                            // print(ApplicationData.CurrentZvelocity);
        Speed.text = "SPEED: " + ApplicationData.CurrentZvelocity.ToString("00.00");
        LapCount.text = "LAPS COMPLETED: " + ApplicationData.LapCount.ToString();
        float Bminutes = Mathf.FloorToInt(ApplicationData.Bestlap / 60);
        float Bseconds = Mathf.FloorToInt(ApplicationData.Bestlap % 60);
        BestLapText.text = string.Format("BEST COMPLETED LAP: {0:00}:{1:00}", Bminutes, Bseconds);
    }//end update

    ///define functions//


    public void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        TimeText.text = string.Format("THIS LAP: {0:00}:{1:00}", minutes, seconds);
    }



}

