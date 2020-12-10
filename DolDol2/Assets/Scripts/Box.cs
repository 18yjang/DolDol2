﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : DolObject
{
  private bool correctSwitch = false;
  // Start is called before the first frame update
  void Start()
  {
    Init();
  }

  // Update is called once per frame
  void Update()
  {
    
  }

  private void OnCollisionEnter2D(Collision2D collision)
  {
    float left = transform.position.x - transform.localScale.x / 2;
    float right = transform.position.x + transform.localScale.x / 2;

    //if (collision.transform.position.y > transform.position.y &&
    // (collision.transform.position.x >= (transform.position.x - transform.localScale.x / 2) &&
    // collision.transform.position.x <= (transform.position.x + transform.localScale.x / 2)))

    if (collision.transform.position.y > transform.position.y &&
     (collision.transform.position.x >= left &&
     collision.transform.position.x <= right))

    // if (collision.transform.position.y > transform.position.y)
    {
      collision.transform.SetParent(transform);
    }
  }

  private void OnCollsionStay2D(Collision collision)
  {
    
  }

  private void OnCollisionExit2D(Collision2D collision)
  {
    collision.transform.SetParent(null);
  }
}
