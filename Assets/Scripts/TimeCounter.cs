using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    public Text txtTimeCounter;
    float elapsedTime;
    bool isPaused;

    public int freqInSeconds;
    float nextSpawnTime;

    public GameObject sphereSpwan;

    // Start is called before the first frame update
    void Start()
    {
        elapsedTime = 0;
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject clon;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isPaused = !isPaused;
        }

        if (isPaused == false)
        {
            elapsedTime += Time.deltaTime;

            if (nextSpawnTime < Time.time)
            {
                clon = Instantiate(sphereSpwan);
                Destroy(clon, 2);
                nextSpawnTime += freqInSeconds;
            }
        }

        txtTimeCounter.text = Mathf.Floor(elapsedTime).ToString();
    }
}
