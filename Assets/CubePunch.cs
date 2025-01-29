using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class CubePunch : MonoBehaviour
{
    [SerializeField] private float punchScale;
    [SerializeField] private float duration;

    private bool isAnimating = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2) && !isAnimating)
        {
            Debug.Log(
                $"Pressed button '<color=yellow>2</color>': <color=orange>Punch scale the object</color>");
            Punch();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("Punch animation is still running");
        }
    }

    void Punch()
    {
        isAnimating = true;
        transform.DOPunchScale(Vector3.one * punchScale, duration, 1, 0)
            .OnComplete(() => isAnimating = false); 
    }
}