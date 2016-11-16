using UnityEngine;

public class PlayerController : MonoBehaviour {

    public int PlayerSpeed = 10000;

    private Rigidbody2D rigid;

	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        rigid.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * Time.fixedDeltaTime * 10000, Input.GetAxisRaw("Vertical") * Time.fixedDeltaTime * 10000);
	
	}
}
