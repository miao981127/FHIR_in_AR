using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatientClasses : MonoBehaviour
{
}
/*
[System.Serializable]
public class Patient
{
    public string id;
    public string gender;
    public string birthDate;
    public bool multipleBirthBoolean;

    public NameList names;
    public TelecomList telecoms;
    public AddressList addresses;

    public static Patient CreateFromJson(string jsonString)
    {
        Debug.Log(jsonString);
        Patient p = JsonUtility.FromJson<Patient>(jsonString);
        NameList nali = JsonUtility.FromJson<NameList>(jsonString);
        p.names = nali;
        TelecomList teli = JsonUtility.FromJson<TelecomList>(jsonString);
        p.telecoms = teli;
        AddressList adli = JsonUtility.FromJson<AddressList>(jsonString);
        p.addresses = adli;
        return p;
    }
}

#region name

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
public class Name
{
    public string use;
    public string family;
    public List<string> given;
    public List<string> prefix;
}

#endregion

#region telecom

[System.Serializable]
public class TelecomList
{
    public List<Telecom> telecom;
    public Telecom getTelecom(int index)
    {
        return telecom[index];
    }
}

[System.Serializable]
public class Telecom
{
    public string system;
    public string value;
    public string use;
}

#endregion

#region address
[System.Serializable]
public class AddressList
{
    public List<Address> address;
    public Address getAddress(int index)
    {
        return address[index];
    }
}

[System.Serializable]
public class Address
{
    public List<string> line;
    public string city;
    public string state;
    public string postalCode;
    public string country;
}
#endregion
*/
