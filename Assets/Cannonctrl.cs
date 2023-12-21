using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonctrl : MonoBehaviour
{
    public Transform barrelTransform; // 포신의 Transform 컴포넌트
    public float rotationSpeed = 10.0f; // 포신 회전 속도
    public float maxAngle = 30.0f; // 최대 각도
    public float minAngle = -5.0f; // 최소 각도

    void Update()
    {
        float mouseWheel = Input.GetAxis("Mouse ScrollWheel");
        float angle = barrelTransform.localEulerAngles.x - mouseWheel * rotationSpeed;

        // 각도를 360도 범위로 변환
        if (angle > 180f) angle -= 360f;

        // 각도 제한
        angle = Mathf.Clamp(angle, minAngle, maxAngle);

        barrelTransform.localEulerAngles = new Vector3(angle, barrelTransform.localEulerAngles.y, barrelTransform.localEulerAngles.z);
    }
}