using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayGameplay : MonoBehaviour
{

    public float delayTime = 1f;

    void Start()
    {
        Time.timeScale = 0.01f;
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(delayTime);
        Time.timeScale = 1f;
    }
}
