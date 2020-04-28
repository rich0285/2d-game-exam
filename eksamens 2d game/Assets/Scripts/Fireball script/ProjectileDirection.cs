using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDirection : MonoBehaviour
{
    private SpriteRenderer mySpriteRenderer;

    // This function is called just one time by Unity the moment the component loads
    private void Awake()
    {
        // get a reference to the SpriteRenderer component on this gameObject
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        Vector3 targetDir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = (Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg);
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        mySpriteRenderer.flipX = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
