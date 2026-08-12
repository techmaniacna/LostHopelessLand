using UnityEngine;

public class CharacterCustomization : MonoBehaviour
{
    [Header("Cosmetic Settings")]
    public string selectedOutfit = "Default Commando";
    public string selectedHelmet = "Tactical MK1";

    public void EquipOutfit(string outfitName)
    {
        selectedOutfit = outfitName;
        Debug.Log("Equipped outfit: " + selectedOutfit);
    }

    public void EquipHelmet(string helmetName)
    {
        selectedHelmet = helmetName;
        Debug.Log("Equipped helmet: " + selectedHelmet);
    }
}
