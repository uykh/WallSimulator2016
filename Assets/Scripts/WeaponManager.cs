using UnityEngine;
using UnityEngine.UI;

public class WeaponManager : MonoBehaviour {

    public int CurrentWeapon = 0;

    public static bool SmgEnabled = false;
    public static bool ShotgunEnabled = false;
    public static bool MinigunEnabled = false;

    public GameObject PistolObject;
    public GameObject SmgObject;
    public GameObject ShotgunObject;
    public GameObject MinigunObject;

    public Sprite PistolSprite;
    public Sprite SmgSprite;
    public Sprite ShotgunSprite;
    public Sprite MinigunSprite;

    public float SwitchingSpeed = 0.25f;

    public Image WeaponImage;

    private float timer = 0f;
	// Use this for initialization
	void Start ()
    {
	    
	}

    void NextWeapon()
    {
        if (CurrentWeapon == 3)
            CurrentWeapon = 0;
        else
            CurrentWeapon++;

        switch (CurrentWeapon)
        {
            case 0:
                WeaponImage.sprite = PistolSprite;
                MinigunObject.SetActive(false);
                PistolObject.SetActive(true);
                break;

            case 1:
                WeaponImage.sprite = SmgSprite;
                PistolObject.SetActive(false);
                SmgObject.SetActive(true);
                break;

            case 2:
                WeaponImage.sprite = ShotgunSprite;
                SmgObject.SetActive(false);
                ShotgunObject.SetActive(true);
                break;

            case 3:
                WeaponImage.sprite = MinigunSprite;
                ShotgunObject.SetActive(false);
                MinigunObject.SetActive(true);
                break;

            default:
                CurrentWeapon = 0;
                goto case 0;
        }

        WeaponImage.SetNativeSize();


    }

    void PrevWeapon()
    {
        if (CurrentWeapon == 0)
            CurrentWeapon = 3;
        else
            CurrentWeapon--;

        switch (CurrentWeapon)
        {
            case 0:
                WeaponImage.sprite = PistolSprite;
                
                SmgObject.SetActive(false);
                PistolObject.SetActive(true);
                break;

            case 1:
                WeaponImage.sprite = SmgSprite;
                
                ShotgunObject.SetActive(false);
                SmgObject.SetActive(true);
                break;

            case 2:
                WeaponImage.sprite = ShotgunSprite;
                MinigunObject.SetActive(false);
                ShotgunObject.SetActive(true);
                break;

            case 3:
                WeaponImage.sprite = MinigunSprite;
                PistolObject.SetActive(false);
                MinigunObject.SetActive(true);
                break;

            default:
                CurrentWeapon = 0;
                goto case 0;
        }

        WeaponImage.SetNativeSize();
    }
	


	// Update is called once per frame
	void Update ()
    {
	    if (timer >= SwitchingSpeed)
        {
            if (Input.GetAxisRaw("Mouse ScrollWheel") != 0f)
            {

                if (Input.GetAxis("Mouse ScrollWheel") == 0.1f)
                    NextWeapon();

                if (Input.GetAxis("Mouse ScrollWheel") == -0.1f)
                    PrevWeapon();

                timer = 0f;
                
            }
        }
        timer += Time.deltaTime;
	}
}
