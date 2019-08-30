using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text scoreText;
    public Transform playerTransform;

    void Update() {
        scoreText.text = playerTransform.position.z.ToString("0");
    }
}
