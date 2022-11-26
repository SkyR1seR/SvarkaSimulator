using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cabel : MonoBehaviour
{
    public int stage = 0;

    public GameObject naryzhPart;
    public GameObject kevlarPart;
    public GameObject obolochkaPart;
    public GameObject hydrofobPart;
    public GameObject[] moduleTubePart;
    public GameObject[] optikVoloknoPart;

    public GameObject[] kdzsPart;
    public GameObject skalivatelPart;
    public GameObject svarkaPart;

    public GameObject completeCabel;

    private void OnTriggerEnter(Collider other)
    {


        switch (other.tag)
        {
            case "Kabifix":
                if (stage == 0)
                {
                    stage++;
                    naryzhPart.SetActive(false);
                }
                else
                {
                    Debug.Log("Wrong tool");
                }
                break;
            case "KevlarScissors":
                if (stage == 1)
                {
                    stage++;
                    kevlarPart.SetActive(false);
                }
                else
                {
                    Debug.Log("Wrong tool");
                }
                break;
            case "obolochkaStipper":
                if (stage == 2)
                {
                    stage++;
                    obolochkaPart.SetActive(false);
                }
                else
                {
                    Debug.Log("Wrong tool");
                }
                break;
            case "dgel":
                if (stage == 3)
                {
                    stage++;
                    hydrofobPart.SetActive(false);
                }
                else
                {
                    Debug.Log("Wrong tool");
                }
                break;
            case "buferStripper":
                if (stage == 4)
                {
                    stage++;
                    foreach (var item in moduleTubePart)
                    {
                        item.SetActive(false);
                    }
                }
                else
                {
                    Debug.Log("Wrong tool");
                }
                break;
            case "kdzs":
                if (stage == 5)
                {
                    stage++;
                    foreach (var item in kdzsPart)
                    {
                        item.SetActive(true);
                    }
                }
                else
                {
                    Debug.Log("Wrong tool");
                }
                break;
            case "skalivatel":
                if (stage == 6)
                {
                    stage++;
                    skalivatelPart.SetActive(false);
                }
                else
                {
                    Debug.Log("Wrong tool");
                }
                break;
            case "svarka":
                if (stage == 7)
                {
                    stage++;
                    completeCabel.SetActive(true);
                }
                else
                {
                    Debug.Log("Wrong tool");
                }
                break;
            default:
                break;
        }
    }
}
