using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
  [SerializeField]
  private float torque = 100f;

  private Rigidbody2D rb;
  private float turn = 0;

  private void Start()
  {
    rb = GetComponent<Rigidbody2D>();
  }

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
