﻿using System.Collections.Generic; using UnityEngine;  public class panSelector : MonoBehaviour {     public Material highlightMat;     public Material normalMat;     private int highlighted;     public GameObject pan1, pan2, pan3;     public GameObject smoke, lightt, burning;     public GameObject[] MyObjects;     public GameObject[] particalSys;     Dictionary<GameObject, GameObject[]> dict = new Dictionary<GameObject, GameObject[]>();      // Start is called before the first frame update     void Start()     {         MyObjects = new GameObject[4];         MyObjects[1] = pan1;         MyObjects[2] = pan2;         MyObjects[3] = pan3;          GameObject s = MyObjects[2];         s.GetComponentInChildren<Renderer>().material = highlightMat;         highlighted = 2;          particalSys = new GameObject[4];         particalSys[1] = smoke;         particalSys[2] = lightt;         particalSys[3] = burning;         dict.Add(pan1, particalSys);         dict.Add(pan2, particalSys);         dict.Add(pan3, particalSys);      }      // Update is called once per frame     void Update()     {          if (Input.GetKeyDown(KeyCode.D))         {             if((highlighted - 1) == 0)             {                 highlighted = 3;                 GameObject o = MyObjects[1];                 o.GetComponentInChildren<Renderer>().material = normalMat;                  GameObject p = MyObjects[highlighted];                 p.GetComponentInChildren<Renderer>().material = highlightMat;             }             else             {                 GameObject o = MyObjects[highlighted];                 o.GetComponentInChildren<Renderer>().material = normalMat;                  highlighted -= 1;                 GameObject p = MyObjects[highlighted];                 p.GetComponentInChildren<Renderer>().material = highlightMat;              }           }         else if (Input.GetKey(KeyCode.A))         {           }          if(Input.GetKey(KeyCode.O) )         {             GameObject pa = MyObjects[highlighted];           }      } }