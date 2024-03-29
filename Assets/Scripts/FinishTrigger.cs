﻿using UnityEngine;

public class FinishTrigger : MonoBehaviour {

    public GameManager gameManager;

    private void OnTriggerEnter(Collider other) {
        gameManager.LevelPassed();
        FindObjectOfType<PlayerMovement>().StopMovement();
    }
}
