using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crusher1 : MonoBehaviour
{
    public float speed;
<<<<<<< HEAD

    private void FixedUpdate()
    {
        if (transform.position.x <= -8 || transform.position.x >= 8)
        {
            speed *= -1;
        }
        float newXPosition = transform.position.x + speed * Time.fixedDeltaTime;
        float newYPosition = transform.position.y;
        Vector2 newPosition = new Vector2(newXPosition, newYPosition);
        transform.position = newPosition;
    }
}
=======
}
>>>>>>> 2d4892225803a807e82d07c25e5e1357fe243e21
