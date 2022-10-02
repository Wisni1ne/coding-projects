using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rhythm : MonoBehaviour
{

    public GameObject GameCanvas;
    public GameObject CenterImage;
    public GameObject LeftGoodImage;
    public GameObject RightGoodImage;
    public GameObject LeftBadImage;
    public GameObject RightBadImage;
    public GameObject LeftStandardImage01;
    public GameObject RightStandardImage01;
    public GameObject LeftStandardImage02;
    public GameObject RightStandardImage02;
    public GameObject LeftStandardImage03;
    public GameObject RightStandardImage03;
    public GameObject LeftStandardImage04;
    public GameObject RightStandardImage04;
    public int counting;

    public bool goodHit;
    public GameObject psystem;

    void Start()
    {
        //StartCoroutine(RhythmSystem());
    }

    void Update()
    {
        StartCoroutine(RhythmSystem());
    }

    IEnumerator RhythmSystem()
    {
        if ((counting % 4) == 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if ((-40 < LeftStandardImage01.GetComponent<RectTransform>().anchoredPosition.x && LeftStandardImage01.GetComponent<RectTransform>().anchoredPosition.x < -15)
                    || (40 > RightStandardImage01.GetComponent<RectTransform>().anchoredPosition.x && RightStandardImage01.GetComponent<RectTransform>().anchoredPosition.x > 15))
                {
                    Debug.Log("Good Detect1");
                    goodHit = true;
                    psystem.GetComponent<PointsSystem>().points += 10;

                    LeftGoodImage.SetActive(true);
                    RightGoodImage.SetActive(true);
                    LeftGoodImage.GetComponent<RectTransform>().anchoredPosition = LeftStandardImage01.GetComponent<RectTransform>().anchoredPosition;
                    RightGoodImage.GetComponent<RectTransform>().anchoredPosition = RightStandardImage01.GetComponent<RectTransform>().anchoredPosition;
                    LeftStandardImage01.SetActive(false);
                    RightStandardImage01.SetActive(false);
                    yield return new WaitForSeconds(0.25f);
                    LeftGoodImage.SetActive(false);
                    RightGoodImage.SetActive(false);
                }
                else
                {
                    Debug.Log("Bad Detect1");
                    goodHit = false;
                    LeftBadImage.SetActive(true);
                    RightBadImage.SetActive(true);
                    LeftBadImage.GetComponent<RectTransform>().anchoredPosition = LeftStandardImage01.GetComponent<RectTransform>().anchoredPosition;
                    RightBadImage.GetComponent<RectTransform>().anchoredPosition = RightStandardImage01.GetComponent<RectTransform>().anchoredPosition;
                    LeftStandardImage01.SetActive(false);
                    RightStandardImage01.SetActive(false);
                    yield return new WaitForSeconds(0.25f);
                    LeftBadImage.SetActive(false);
                    RightBadImage.SetActive(false);
                }
                counting++;
                //yield return new WaitForSeconds(0.5f);
            }
            else if ((-1 < LeftStandardImage01.GetComponent<RectTransform>().anchoredPosition.x && LeftStandardImage01.GetComponent<RectTransform>().anchoredPosition.x < 0)
                    || (1 > RightStandardImage01.GetComponent<RectTransform>().anchoredPosition.x && RightStandardImage01.GetComponent<RectTransform>().anchoredPosition.x > 0))
            {
                Debug.Log("None Detect1");
                //LeftStandardImage01.SetActive(false);
                //RightStandardImage01.SetActive(false);
                counting++;
            }
        }

        else if ((counting % 4) == 1)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if ((-40 < LeftStandardImage02.GetComponent<RectTransform>().anchoredPosition.x && LeftStandardImage02.GetComponent<RectTransform>().anchoredPosition.x < -15)
                    || (40 > RightStandardImage02.GetComponent<RectTransform>().anchoredPosition.x && RightStandardImage02.GetComponent<RectTransform>().anchoredPosition.x > 15))
                {
                    Debug.Log("Good Detect2");
                    goodHit = true;
                    psystem.GetComponent<PointsSystem>().points += 10;

                    LeftGoodImage.SetActive(true);
                    RightGoodImage.SetActive(true);
                    LeftGoodImage.GetComponent<RectTransform>().anchoredPosition = LeftStandardImage02.GetComponent<RectTransform>().anchoredPosition;
                    RightGoodImage.GetComponent<RectTransform>().anchoredPosition = RightStandardImage02.GetComponent<RectTransform>().anchoredPosition;
                    LeftStandardImage02.SetActive(false);
                    RightStandardImage02.SetActive(false);
                    yield return new WaitForSeconds(0.25f);
                    LeftGoodImage.SetActive(false);
                    RightGoodImage.SetActive(false);
                    
                }
                else
                {
                    Debug.Log("Bad Detect2");
                    goodHit = false;
                    LeftBadImage.SetActive(true);
                    RightBadImage.SetActive(true);
                    LeftBadImage.GetComponent<RectTransform>().anchoredPosition = LeftStandardImage02.GetComponent<RectTransform>().anchoredPosition;
                    RightBadImage.GetComponent<RectTransform>().anchoredPosition = RightStandardImage02.GetComponent<RectTransform>().anchoredPosition;
                    LeftStandardImage02.SetActive(false);
                    RightStandardImage02.SetActive(false);
                    yield return new WaitForSeconds(0.25f);
                    LeftBadImage.SetActive(false);
                    RightBadImage.SetActive(false);
                }
                counting++;
                //yield return new WaitForSeconds(0.5f);
            }
            else if ((-1 < LeftStandardImage02.GetComponent<RectTransform>().anchoredPosition.x && LeftStandardImage02.GetComponent<RectTransform>().anchoredPosition.x < 0)
                    || (1 > RightStandardImage02.GetComponent<RectTransform>().anchoredPosition.x && RightStandardImage02.GetComponent<RectTransform>().anchoredPosition.x > 0))
            {
                Debug.Log("None Detect2");
                //LeftStandardImage02.SetActive(false);
                //RightStandardImage02.SetActive(false);
                counting++;
            }
        }

        else if ((counting % 4) == 2)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if ((-40 < LeftStandardImage03.GetComponent<RectTransform>().anchoredPosition.x && LeftStandardImage03.GetComponent<RectTransform>().anchoredPosition.x < -15)
                    || (40 > RightStandardImage03.GetComponent<RectTransform>().anchoredPosition.x && RightStandardImage03.GetComponent<RectTransform>().anchoredPosition.x > 15))
                {
                    Debug.Log("Good Detect3");
                    goodHit = true;
                    psystem.GetComponent<PointsSystem>().points += 10;

                    LeftGoodImage.SetActive(true);
                    RightGoodImage.SetActive(true);
                    LeftGoodImage.GetComponent<RectTransform>().anchoredPosition = LeftStandardImage03.GetComponent<RectTransform>().anchoredPosition;
                    RightGoodImage.GetComponent<RectTransform>().anchoredPosition = RightStandardImage03.GetComponent<RectTransform>().anchoredPosition;
                    LeftStandardImage03.SetActive(false);
                    RightStandardImage03.SetActive(false);
                    yield return new WaitForSeconds(0.25f);
                    LeftGoodImage.SetActive(false);
                    RightGoodImage.SetActive(false);
                }
                else
                {
                    Debug.Log("Bad Detect3");
                    goodHit = false;
                    LeftBadImage.SetActive(true);
                    RightBadImage.SetActive(true);
                    LeftBadImage.GetComponent<RectTransform>().anchoredPosition = LeftStandardImage03.GetComponent<RectTransform>().anchoredPosition;
                    RightBadImage.GetComponent<RectTransform>().anchoredPosition = RightStandardImage03.GetComponent<RectTransform>().anchoredPosition;
                    LeftStandardImage03.SetActive(false);
                    RightStandardImage03.SetActive(false);
                    yield return new WaitForSeconds(0.25f);
                    LeftBadImage.SetActive(false);
                    RightBadImage.SetActive(false);
                }
                counting++;
                //yield return new WaitForSeconds(0.5f);
            }
            else if ((-1 < LeftStandardImage03.GetComponent<RectTransform>().anchoredPosition.x && LeftStandardImage03.GetComponent<RectTransform>().anchoredPosition.x < 0)
                    || (1 > RightStandardImage03.GetComponent<RectTransform>().anchoredPosition.x && RightStandardImage03.GetComponent<RectTransform>().anchoredPosition.x > 0))
            {
                Debug.Log("None Detect3");
                //LeftStandardImage03.SetActive(false);
                //RightStandardImage03.SetActive(false);
                counting++;
            }
        }

        else if ((counting % 4) == 3)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if ((-40 < LeftStandardImage04.GetComponent<RectTransform>().anchoredPosition.x && LeftStandardImage04.GetComponent<RectTransform>().anchoredPosition.x < -15)
                    || (40 > RightStandardImage04.GetComponent<RectTransform>().anchoredPosition.x && RightStandardImage04.GetComponent<RectTransform>().anchoredPosition.x > 15))
                {
                    Debug.Log("Good Detect4");
                    goodHit = true;
                    psystem.GetComponent<PointsSystem>().points += 10;

                    LeftGoodImage.SetActive(true);
                    RightGoodImage.SetActive(true);
                    LeftGoodImage.GetComponent<RectTransform>().anchoredPosition = LeftStandardImage04.GetComponent<RectTransform>().anchoredPosition;
                    RightGoodImage.GetComponent<RectTransform>().anchoredPosition = RightStandardImage04.GetComponent<RectTransform>().anchoredPosition;
                    LeftStandardImage04.SetActive(false);
                    RightStandardImage04.SetActive(false);
                    yield return new WaitForSeconds(0.25f);
                    LeftGoodImage.SetActive(false);
                    RightGoodImage.SetActive(false);
                }
                else
                {
                    Debug.Log("Bad Detect4");
                    goodHit = false;
                    LeftBadImage.SetActive(true);
                    RightBadImage.SetActive(true);
                    LeftBadImage.GetComponent<RectTransform>().anchoredPosition = LeftStandardImage04.GetComponent<RectTransform>().anchoredPosition;
                    RightBadImage.GetComponent<RectTransform>().anchoredPosition = RightStandardImage04.GetComponent<RectTransform>().anchoredPosition;
                    LeftStandardImage04.SetActive(false);
                    RightStandardImage04.SetActive(false);
                    yield return new WaitForSeconds(0.25f);
                    LeftBadImage.SetActive(false);
                    RightBadImage.SetActive(false);
                }
                counting++;
                //yield return new WaitForSeconds(0.5f);
            }
            else if ((-1 < LeftStandardImage04.GetComponent<RectTransform>().anchoredPosition.x && LeftStandardImage04.GetComponent<RectTransform>().anchoredPosition.x < 0)
                    || (1 > RightStandardImage04.GetComponent<RectTransform>().anchoredPosition.x && RightStandardImage04.GetComponent<RectTransform>().anchoredPosition.x > 0))
            {
                Debug.Log("None Detect4");
                //LeftStandardImage04.SetActive(false);
                //RightStandardImage04.SetActive(false);
                counting++;
            }
        }
        //yield return new WaitForSeconds(0.5f);
    }

}
