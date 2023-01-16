using UnityEngine;

public class Trail : MonoBehaviour
{
    public GameObject trailPrefab;
    public float trailInterval = 0.1f;
    private float timeSinceLastTrail = 0f;
    private Transform previousTrail;
    private Vector3 startPos;
    private Vector3 endPos;
    private bool isMouseDown = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition;
            isMouseDown = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            endPos = Input.mousePosition;
            isMouseDown = false;
        }

        if (isMouseDown)
        {
            timeSinceLastTrail += Time.deltaTime;
            if (timeSinceLastTrail >= trailInterval)
            {
                timeSinceLastTrail = 0f;
                GameObject trail = Instantiate(trailPrefab, transform.position, Quaternion.identity);
                trail.transform.parent = transform;
                if (previousTrail != null)
                {
                    Destroy(previousTrail.gameObject, 1f);
                }
                previousTrail = trail.transform;
            }

            //Calculate the direction of throw and add force to the rigidbody
            Vector3 direction = endPos - startPos;
            GetComponent<Rigidbody>().AddForce(direction);
        }
    }
}
