using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float moveSpeed = 5f;

        public Rigidbody2D rb;
        public Camera cam;

        Vector2 movement;
        Vector2 mousePos;
        SpriteRenderer srSprite;

    private void Start()
    {
    srSprite = GetComponent<SpriteRenderer>();

    }
    // Update is called once per frame
    void Update()
    {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
            mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

        private void FixedUpdate()
        {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

            Vector2 lookDir = mousePos - rb.position;
            float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
            rb.rotation = angle;
           // Debug.Log("Current angle: " + angle);
        if(angle<= -90 || angle>=90)
        {
            srSprite.flipY = true;
        }
        else
        {
            srSprite.flipY = false;
        }
            
        }
}
