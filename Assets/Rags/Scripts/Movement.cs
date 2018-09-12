using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
  [SerializeField]
  private float torque = 100f;

  private float turn = 0;

  // Update is called once per frame
  private void Update()
  {
    if (Input.GetButton("Horizontal"))
    {
      turn = Input.GetAxisRaw("Horizontal");
      transform.Rotate(0f, 0f, (turn > 0 ? -torque : torque) * Time.deltaTime);
    }
  }
}
