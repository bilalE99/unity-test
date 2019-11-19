using UnityEngine.UI;
using UnityEngine;

public class Tracker : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0") + "m";
    }
}