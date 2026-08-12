using UnityEngine;

public class AirdropController : MonoBehaviour
{
    [Header("Airdrop Properties")]
    public float descentSpeed = 3f;
    public bool hasLandred = false;

    void Update()
    {
        if (!hasLandred)
        {
            transform.Translate(Vector3.down * descentSpeed * Time.deltaTime);

            if (transform.position.y <= 0f)
            {
                hasLandred = true;
                Debug.Log("Airdrop has landed. High-tier gear available.");
            }
        }
    }
}
