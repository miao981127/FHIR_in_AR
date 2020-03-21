using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jsonTest : MonoBehaviour
{
    private string testString = "{\"test\":[\"josh1\",\"josh2\",\"josh3\"]}";


    void Start()
    {
        TestClass tc = JsonUtility.FromJson<TestClass>(testString);
        Debug.Log(tc.test);
        Debug.Log(tc.test[0]);
        Debug.Log(tc.test[1]);
        Debug.Log(tc.test[2]);
    }
}

public class TestClass
{
    public List<string> test;
}

/*
[System.Serializable]
public class Name
{
    public string first;
    public string last;
}

[System.Serializable]
public class NameList
{
    public List<Name> name;
    public Name getName(int index)
    {
        return name[index];
    }
}

[System.Serializable]
public class Patient
{
    public string id;
    public NameList names;

    public static Patient CreateFromJson(string testString)
    {
        Debug.Log(testString);
        Patient p = JsonUtility.FromJson<Patient>(testString);
        Debug.Log(p.id);
        Debug.Log(testString);
        NameList nali = JsonUtility.FromJson<NameList>(testString);
        Debug.Log(nali.getName(0).first + "-" + nali.getName(0).last);
        Debug.Log(nali.getName(1).first + "-" + nali.getName(1).last);
        p.names = nali;
        Debug.Log(p.id);
        Debug.Log(p.names.getName(0).first);
        return p;
    }
}
*/