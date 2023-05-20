using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{
    TextMeshProUGUI cntDown;
    TextMeshProUGUI timeCnt;
    TextMeshProUGUI bestTime;
    float time;
    void Start()
    {
        cntDown = GameObject.Find("cntDown").GetComponent<TextMeshProUGUI>();
        timeCnt = GameObject.Find("timerCnt").GetComponent<TextMeshProUGUI>();
        bestTime = GameObject.Find("bestTime").GetComponent<TextMeshProUGUI>();

        cntDown.text = "";
        StartCoroutine(startCntDonw());
    }

    void StartTimer()
    {
        StartCoroutine("Timer");
    }

    IEnumerator Timer()
    {
        time += Time.deltaTime;
        int Min, Sec, Msec;

        Min = (int)(time / 60);
        Sec = (int)(time - Min * 60);
        Msec = (int)((time - (Min * 60) - Sec) * 100);

        timeCnt.text = Min.ToString("00") + ":" + Sec.ToString("00") + ":" + Msec.ToString("00");

        yield return null;
        StartCoroutine(Timer());
    }

    IEnumerator startCntDonw()
    {
        yield return new WaitForSeconds(2);
        cntDown.text = "3";
        yield return new WaitForSeconds(1);
        cntDown.text = "2";
        yield return new WaitForSeconds(1);
        cntDown.text = "1";
        yield return new WaitForSeconds(1);
        cntDown.text = "";

        StartTimer();
    }

    
}
