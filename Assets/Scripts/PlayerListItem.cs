using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI;

public class PlayerListItem : MonoBehaviourPunCallbacks
{
    [SerializeField] private Text text;
    private Player player;
    
    public void Setup(Player _player)
    {
        player = _player;
        text.text = _player.NickName;
    }

    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        if (player == otherPlayer)
        {
            Debug.Log("isDestroy?1");
            Destroy(gameObject);
        }
    }

    public override void OnLeftRoom()
    {
        Debug.Log("isDestroy?2");
        Destroy(gameObject);
    }
   
    
}
