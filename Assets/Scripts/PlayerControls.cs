using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerControls : MonoBehaviour
{

  #region Variables
  public float moveSpeed = 5f;
  private float xInput;
  private float zInput;
  public CharacterController playerController;
  private Vector3 moveDirection;

  public GameObject[] abilities;
  public bool stackAbilities = true;


  #endregion

    // Start is called before the first frame update
    void Start()
    {
      playerController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
     xInput = Input.GetAxis("Horizontal");
     zInput = Input.GetAxis("Vertical");   
    }

    private void FixedUpdate()
    {
      moveDirection = new Vector3(xInput, 0, zInput);
      playerController.Move(moveDirection * moveSpeed * Time.deltaTime);
    }


}
