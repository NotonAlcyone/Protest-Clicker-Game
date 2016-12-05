using UnityEngine;
using System.Collections;

public class NewsFeedMovement : MonoBehaviour
{

    public float speed;

    void Update()
    {
        transform.Translate(-speed, 0, 0);

    }
}
