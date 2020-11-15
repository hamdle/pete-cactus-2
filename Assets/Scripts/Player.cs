using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{
    [SerializeField] float runSpeed = 7f;

    Rigidbody2D playerRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Run();
        FlipSprite();
    }

    private void Run()
    {
        float controlThrow = CrossPlatformInputManager.GetAxis("Horizontal"); // from -1 to +1
        playerRigidbody.velocity = new Vector2(controlThrow * runSpeed, playerRigidbody.velocity.y);
    }

    private void FlipSprite()
    {
        if (Mathf.Abs(playerRigidbody.velocity.x) > Mathf.Epsilon) // Epsilon == 0
        {
            transform.localScale = new Vector2(Mathf.Sign(playerRigidbody.velocity.x), 1f);
        }
    }
}
