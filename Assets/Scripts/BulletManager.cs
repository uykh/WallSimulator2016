using UnityEngine;

public class BulletManager : MonoBehaviour {

    public int Speed = 1000;

    public int Damage;

    private Rigidbody2D rigid;
    
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 2f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<EnemyManager>().TakeDamage(Damage);
            Destroy(gameObject);
        }
        else if (other.gameObject.tag != "Player")
        {
            Destroy(gameObject);
        }

    }

    void FixedUpdate()
    {
        rigid.velocity = new Vector2(Speed, 0);
    }
}