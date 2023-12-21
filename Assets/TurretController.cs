using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{
    public Transform turretTransform; // 터렛의 Transform 컴포넌트
    public float rotationSpeed = 10.0f; // 터렛의 회전 속도

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            Vector3 targetPoint = hit.point;
            targetPoint.y = turretTransform.position.y; // 터렛의 높이를 유지
            Vector3 direction = targetPoint - turretTransform.position;

            Quaternion targetRotation = Quaternion.LookRotation(direction);
            turretTransform.rotation = Quaternion.Lerp(turretTransform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
