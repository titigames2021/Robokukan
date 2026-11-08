using UnityEngine;

public class PlayerBounds : MonoBehaviour
{
    private float halfWidth;
    private Camera mainCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCamera = Camera.main;
        //Get halfWidth of player Sprite 
        SpriteRenderer playerSprite = GetComponent<SpriteRenderer>();
        if (playerSprite != null)
        {
            halfWidth = playerSprite.bounds.extents.x;
        }
        else
        {
            halfWidth = 0.5f;
        }
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        #region Camera Clamp
        // Convert screen edges (Viewport 0 to 1) to world coordinates
        Vector3 minScreen = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, 0));
        Vector3 maxScreen = mainCamera.ViewportToWorldPoint(new Vector3(1, 1, 0));

        float minX = minScreen.x + halfWidth;
        float maxX = maxScreen.x - halfWidth;
        float minY = minScreen.y + halfWidth;
        float maxY = maxScreen.y - halfWidth;

        // Clamp player X position within world screen limits
        Vector3 clampedPosition = transform.position;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, minX, maxX);
        clampedPosition.y = Mathf.Clamp(clampedPosition.y, minY, maxY);

        transform.position = clampedPosition;

        #endregion
    }
}
