using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShaker : MonoBehaviour
{

    public float durationPerTurn = 0.2f;
    public float magnitudePerTurn = 1f;
    public void Start()
    {
        Turn.TurnEvent += OnTurn;
    }

    

    private void OnTurn()
    {
        StartCoroutine(Shake(durationPerTurn, magnitudePerTurn));
    }

    public IEnumerator Shake(float duration, float magnitude)
    {
        Vector3 origPos = transform.localPosition;
        float elapsed = 0f;
        while (elapsed<duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = new Vector3(x, y, origPos.z);

            elapsed += Time.deltaTime; 

            yield return null;
        }

        transform.localPosition = origPos;
    }
}
