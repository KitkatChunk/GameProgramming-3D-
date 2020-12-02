using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStable : MonoBehaviour
{
    public GameObject vehicle;
    public float carX;
    public float carY;
    public float carZ;
    // Update is called once per frame
    void Update()
    {
        carX = vehicle.transform.eulerAngles.x;
        carY = vehicle.transform.eulerAngles.y;
        carZ = vehicle.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(carX - carX, carY, carZ - carZ);
    }
}
