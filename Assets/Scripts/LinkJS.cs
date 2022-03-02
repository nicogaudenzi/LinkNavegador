using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkJS : MonoBehaviour
{
[SerializeField]
GameObject go;
  public void TestJS(){
      Instantiate(go);
  } 
}
