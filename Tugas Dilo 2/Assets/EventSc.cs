using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSc : MonoBehaviour
{
    private static GameManager _instance = null;

    public static GameManager Instance

    {

        get

        {

            if (_instance == null)

            {

                _instance = FindObjectOfType<GameManager>();

            }



            return _instance;

        }

    }
    public double prize;
    public void okay()
    {
        GameManager.Instance.AddGold(prize);
        gameObject.SetActive(false);
    }
}
