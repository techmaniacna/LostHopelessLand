using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [Header("Weapon Stats")]
    public string weaponName = "Assault Rifle";
    public int currentAmmo = 30;
    public int maxMagazine = 30;
    public float fireRate = 0.15f;

    public void Shoot()
    {
        if (currentAmmo > 0)
        {
            currentAmmo--;
            Debug.Log(weaponName + " fired! Ammo remaining: " + currentAmmo);
        }
        else
        {
            Debug.Log("Out of ammo! Reload required.");
        }
    }
}
