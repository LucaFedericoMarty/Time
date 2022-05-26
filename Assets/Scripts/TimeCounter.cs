using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    public Text txtTimeCounter;
    float elapsedTime;
    bool isPaused;

    float timeInstantiate;

    // Start is called before the first frame update
    void Start()
    {
        elapsedTime = 0;
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isPaused = !isPaused;
        }

        if (isPaused == false)
        {
            elapsedTime += Time.deltaTime;

            if (elapsedTime % timeInstantiate)
            {

            }
        }

        txtTimeCounter.text = Mathf.Floor(elapsedTime).ToString();
    }
}
