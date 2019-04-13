using UnityEngine;
using UnityEngine.UI;
public class Car : MonoBehaviour {

	public Rigidbody2D rb;
    
	public float minSpeed = 0;
	public float maxSpeed = 0f;
   	public float speed = 1f;

	void Start ()
	{
        minSpeed = DropDownSelect1.theMinSpeed;
        maxSpeed = DropDownSelect1.theMaxSpeed;
        speed = Random.Range(minSpeed, maxSpeed);
	}

	void FixedUpdate () {
		Vector2 forward = new Vector2(transform.right.x, transform.right.y);
		rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
	}

}
