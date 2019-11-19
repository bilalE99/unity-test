
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager1;

    public void OnTriggerEnd()
    {
        gameManager1.completeLevel();
    }
}
