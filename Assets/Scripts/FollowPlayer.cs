using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {


    public GameObject target;
    public Vector3 targetPosition;
    public float minDistance;
    public float speed;
    public bool customer;

	// Use this for initialization
	void Start () {
        int random = Random.Range(0, 5);
        customer = random == 4;
	}
	
	// Update is called once per frame
	void Update () {
 
    if(customer)
    {
        Follow();
    }    
   
 }

    private void Follow()
    {
        targetPosition = target.transform.position;
        targetPosition.y = transform.position.y;
        transform.LookAt(targetPosition);


        float distance = Vector3.Distance(transform.position, targetPosition);

        if (distance > minDistance)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, speed * Time.deltaTime);
        }
    }

}

