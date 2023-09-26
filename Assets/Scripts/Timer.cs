using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    float timeAllowed = 300f;

    [SerializeField]
    TMP_Text timeRemainingUI;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeAllowed -= Time.deltaTime;

        timeRemainingUI.text = Mathf.Round(timeAllowed).ToString();

        if (timeAllowed <= 0f)
        {
            
        }
        
    }
}
