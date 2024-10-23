using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSelect : MonoBehaviour
{
    public GameObject target;

    private Color originalColor;
    private SpriteRenderer spriteRenderer;
    private Color highlightColor = new Color(0.7f, 0.9f, 1f, 1f); // Light blue

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector2 raycastposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(raycastposition, Vector2.zero);


            if ((hit.collider != null) && (hit.collider.gameObject.CompareTag("Enemy")))
            {
                if (target != null)
                {
                    // Reset the color of the previously selected target
                    target.GetComponent<SpriteRenderer>().color = originalColor;
                }

                // The target gets the GameObject
                target = hit.collider.gameObject;
                spriteRenderer = target.GetComponent<SpriteRenderer>();

                //Save the original colour and highlight the target
                if (spriteRenderer != null)
                {
                    originalColor = spriteRenderer.color;
                    spriteRenderer.color = highlightColor;
                }
            }
            /*else
            {
                if (target != null)
                {
                    target.GetComponent<SpriteRenderer>().color = originalColor;
                    target = null;
                }
            }*/
        }
    }
    //reset at the end of round
}
