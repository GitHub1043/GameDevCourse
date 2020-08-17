using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public CameraController camera;
    public PlayerController player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        camera.followPlayer = false;
        player.GameOver();
    }
}
