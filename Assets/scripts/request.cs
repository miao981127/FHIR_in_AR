using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class request : MonoBehaviour
{
    private string serverResponse;
    public static bool showImage = false;
    public GameObject cube;
    public GameObject board;
    public GameObject background;
    public Text idField;
    public Text titleField;
    public Text firstField;
    public Text lastField;
    public Text nameUse;
    public Text genderField;
    public Text bDateFiled;
    public Text MBBFiled;
    public Text teleUse;
    public Text teleSys;
    public Text teleVal;
    public Text addLine;
    public Text addPC;
    public Text addCity;
    public Text addState;
    public Text addCountry;


    private void Start()
    {
        StartCoroutine(getInfo());
        Invoke("create", 5f);
    }

    private void Update()
    {
        if (showImage)
        {
            background.SetActive(true);
        }
        else
        {
            background.SetActive(false);
        }
    }

    IEnumerator getInfo()
    {
        ServicePointManager.ServerCertificateValidationCallback = TrustCertificate;

        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://localhost:5001/api/Patient/8f789d0b-3145-4cf2-8504-13159edaa747");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();

        Stream dataStream = response.GetResponseStream();
        StreamReader reader = new StreamReader(dataStream);
        serverResponse = reader.ReadToEnd();

        Debug.Log(serverResponse);
        yield return 0;
    }

    private static bool TrustCertificate(object sender, X509Certificate x509Certificate, X509Chain x509Chain, SslPolicyErrors sslPolicyErrors)
    {
        // all Certificates are accepted
        return true;
    }

    public void unshow()
    {
        showImage = false;
    }

    public void create()
    {
        Patient p = Patient.CreateFromJson(serverResponse);
        Debug.Log("created!!");
        Instantiate(cube, new Vector3(0, 2, 0), Quaternion.identity);
        Instantiate(board, new Vector3(0, 3, 1), Quaternion.identity);
        idField.text = p.id;
        genderField.text = p.gender;
        bDateFiled.text = p.birthDate;
        if (p.multipleBirthBoolean)
        {
            MBBFiled.text = "Yes";
        }
        else
        {
            MBBFiled.text = "No";
        }
        nameUse.text = p.names.getName(0).use;
        lastField.text = p.names.getName(0).family;
        firstField.text = p.names.getName(0).given[0];
        titleField.text = p.names.getName(0).prefix[0];
        teleUse.text = p.telecoms.getTelecom(0).use;
        teleSys.text = p.telecoms.getTelecom(0).system;
        teleVal.text = p.telecoms.getTelecom(0).value;
        addLine.text = p.addresses.getAddress(0).line[0];
        addCity.text = p.addresses.getAddress(0).city;
        addState.text = p.addresses.getAddress(0).state;
        addPC.text = p.addresses.getAddress(0).postalCode;
        addCountry.text = p.addresses.getAddress(0).country;
    }
}

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
