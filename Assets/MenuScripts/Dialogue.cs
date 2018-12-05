using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//removed ': MonoBehaviour' from 'public class Dialogue' so that you can view the name field in unity to edit there.
[System.Serializable]
public class Dialogue {

    public string name;

    [TextArea(5,10)]
    public string[] sentences;

}
