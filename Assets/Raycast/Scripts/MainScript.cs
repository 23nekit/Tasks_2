using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    private void Update()
    {
        Ray RayFromCamera = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(transform.position, RayFromCamera.direction * 10);
        RaycastHit Rayhit;
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(RayFromCamera, out Rayhit))
            {
                Debug.Log("Убит!");
                Rayhit.collider.gameObject.SetActive(false);
            }
        }
    }
}
