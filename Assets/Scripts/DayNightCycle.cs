using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public Light directionalLight; // Directional Light objesi
    public float dayDuration = 1200f; // Gündüz süresi (20 dakika)
    public float nightDuration = 600f; // Gece süresi (10 dakika)

    private float cycleDuration; // Toplam döngü süresi
    private float rotationSpeed; // Iþýðýn dönme hýzý

    void Start()
    {
        if (directionalLight == null)
        {
            Debug.LogError("Hata");
            return;
        }

        cycleDuration = dayDuration + nightDuration;
        rotationSpeed = 360f / cycleDuration;
    }

    void Update()
    {
        if (directionalLight != null)
        {
            directionalLight.transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
        }
    }
}
