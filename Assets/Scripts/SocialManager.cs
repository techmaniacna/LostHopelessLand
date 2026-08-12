using UnityEngine;
using System.Collections.Generic;

public class SocialManager : MonoBehaviour
{
    [Header("Friends List")]
    public List<string> onlineFriends = new List<string>();

    public void AddFriend(string friendName)
    {
        if (!onlineFriends.Contains(friendName))
        {
            onlineFriends.Add(friendName);
            Debug.Log("Added friend: " + friendName);
        }
    }

    public void InviteToGame(string friendName)
    {
        if (onlineFriends.Contains(friendName))
        {
            Debug.Log("Game invite sent to: " + friendName);
        }
        else
        {
            Debug.Log("Friend is not online or not in your list.");
        }
    }
}
