using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;
public class DayTime : MonoBehaviour
{
    public float timeNow
    {get;private set;}
    public int timeDayNow { get; private set; }
    [SerializeField]
    public float timeDaySet = 120;
    public Text dayText;
    public Image Sky;

    public Color day;
    public Color night;
    [Range(0.01f, 0.2f)]
    public float transitionTime;

    bool isSwap = false;
    private void Start()
    {
        timeNow = 0;
        timeDayNow = 1;
        Sky.color = day;
    }
    // Update is called once per frame
    void Update()
    {
        if (timeDayNow == 10)
        {
            GameManager.instance.EndGame();
            return;
        }
        timeNow += Time.deltaTime;
        if (timeNow >= timeDaySet) {
            timeDayNow++;
            timeNow = timeNow % timeDaySet;
        }
        dayText.text = "day " + timeDayNow.ToString();
        if (!isSwap)
        {
            if (Mathf.FloorToInt(timeNow) == Mathf.FloorToInt(timeDaySet * 0.5f))
            {
                isSwap = true;
                StartCoroutine(SwapColor(Sky.color, night));
            }
            else if (Mathf.FloorToInt(timeNow) == Mathf.FloorToInt(timeDaySet * 0.95f))
            {
                StartCoroutine(SwapColor(Sky.color, day));
            }

            
        }
        

    }
    IEnumerator SwapColor(Color start, Color end)
    {
        float t = 0;
        while (t<1) {
            t += Time.deltaTime* (1/(transitionTime*timeDaySet));
            Sky.color = Color.Lerp(start, end, t);
            yield return null;
        }
        isSwap =false;
    }
}
