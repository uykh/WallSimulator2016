using UnityEngine;

public class GunShoot : MonoBehaviour {


    public float Spread = 0.1f;
    public float Speed = 1f;
    public int Damage = 1;

    public GameObject BulletPrefab;
    public Transform GunTip;

    private float timer = 0f;
    private bool shooting = false;

	
    void Shoot()
    {
        GameObject Bullet = (GameObject)Instantiate(BulletPrefab, GunTip.position, GunTip.rotation);
        Bullet.GetComponent<BulletManager>().Damage = Damage;
    }

	// Update is called once per frame
	void Update ()
    {
	    if (Input.GetAxisRaw("Fire1") > 0.25f)
        {
            shooting = true;
        }

        if (timer >= Speed)
        {

            if (shooting)
            {
                Shoot();
                timer = 0f;
            }
        }
        timer += Time.deltaTime;
        shooting = false;
        
    }
}
