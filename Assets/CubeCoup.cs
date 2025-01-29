using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class CubeCoup : MonoBehaviour
{
    [SerializeField] private float rotationAngle;
    [SerializeField] private float rotationDuration;

    private bool isAnimating = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) && !isAnimating)
        {
            Debug.Log(
                $"Pressed button '<color=yellow>1</color>': <color=orange>Rotating the object</color>");
            Rotate();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("Rotating not completed");
        }
    }

    void Rotate()
    {
        isAnimating = true;
        transform.DORotate(new Vector3(0, rotationAngle, 0), rotationDuration, RotateMode.FastBeyond360)
            .SetEase(Ease.Linear)
            .OnComplete(() => isAnimating = false); 
    }
}