
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManagerr;
    private void OnTriggerEnter() 
    {
        gameManagerr.completeLevel();
    }

}
