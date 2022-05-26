using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContarSegundos : MonoBehaviour
{
    public float timeElapsed;
    // Start is called before the first frame update
    void Start()
    {
        timeElapsed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            timeElapsed += Time.deltaTime;
        }

        Debug.Log(Mathf.Floor(timeElapsed));

        //float segundos = Mathf.Floor(Time.time);
        //Debug.Log(segundos);

    }
}
