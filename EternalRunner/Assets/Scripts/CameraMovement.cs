using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player; // Ziehe hier dein Spieler-Objekt rein
    public Vector3 offset = new Vector3(0, 5, -10); // Abstand zur Kamera
    public float smoothSpeed = 5f; // Geschwindigkeit der Kamerabewegung

    void LateUpdate()
    {
        // Zielposition berechnen
        Vector3 targetPosition = player.position + offset;

        // Sanfte Bewegung der Kamera zur Zielposition
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.deltaTime);
    }
}
