using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Invector.vCharacterController;
public class UnlockCursor : MonoBehaviour
{
    public vThirdPersonInput tpInput;
    public GameObject _player;

    void Start()
    {
        _player = GameObject.Find("Player");
        tpInput = _player.GetComponent<vThirdPersonInput>();

        // call these methods when you open your menu
        tpInput.LockCursor(false);
        tpInput.ShowCursor(true);
    }
}
