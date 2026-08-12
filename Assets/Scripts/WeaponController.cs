using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [Header("Weapon Stats")]
    public string weaponName = "Assault Rifle";
    public int currentAmmo = 30;
    public int maxMagazine = 30;
    public float fireRate = 0.15f;
    private float nextFireTime = 0f;

    public void Shoot()
    {
        if (Time.time >= nextFireTime && currentAmmo > 0)
        {
            nextFireTime = Time.time + fireRate;
            currentAmmo--;
            Debug.Log(weaponName + " fired! Ammo remaining: " + currentAmmo + "/" + maxMagazine);
        }
        else if (currentAmmo <= 0)
        {
            Debug.Log("Out of ammo! Reload required.");
        }
    }

    public void Reload()
    {
        currentAmmo = maxMagazine;
        Debug.Log(weaponName + " reloaded. Ammo full: " + currentAmmo);
    }
}
