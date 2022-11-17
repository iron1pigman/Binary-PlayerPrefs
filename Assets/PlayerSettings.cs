using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class PlayerSettings : MonoBehaviour
{
    [Header("Int")]
    [SerializeField] int intValue = 32;
    [SerializeField] TMP_Text intValueTxt;
    [Header("Float")]
    [SerializeField] float floatValue = 32.0155f;
    [SerializeField] TMP_Text floatValueTxt;
    [Header("String")]
    [SerializeField] string stringValue;
    [SerializeField] TMP_InputField inputField;
    [SerializeField] TMP_Text stringValueTxt;
    [Header("Bool")]
    [SerializeField] bool boolValue;
    [SerializeField] TMP_Text boolValueTxt;
    [SerializeField] Toggle toggle;

    private void Start()
    {
        Debug.Log(Application.persistentDataPath);

        if (BinaryPlayerPrefs.HasKey("int"))
        {
            intValue = BinaryPlayerPrefs.GetInt("int");
        }

        if (BinaryPlayerPrefs.HasKey("float"))
        {
            floatValue = BinaryPlayerPrefs.GetFLoat("float");
        }

        if (BinaryPlayerPrefs.HasKey("string"))
        {
            stringValue = BinaryPlayerPrefs.GetString("string");
        }

        if (BinaryPlayerPrefs.HasKey("bool"))
        {
            boolValue = BinaryPlayerPrefs.GetBool("bool");
        }


        //update values
        UpdateInt();
        UpdateFloat();
        UpdateString();
        UpdateBool();
    }


    //int
    public void IntAdd()
    {
        intValue++;
        UpdateInt();
        BinaryPlayerPrefs.SetInt("int", intValue);
    }
    public void IntSub()
    {
        intValue--;
        UpdateInt();
        BinaryPlayerPrefs.SetInt("int", intValue);
    }
    void UpdateInt()
    {
        intValueTxt.text = intValue.ToString(); 
    }
    
    
    // float
    public void FloatAdd()
    {
        floatValue += 0.5f;
        UpdateFloat();
        BinaryPlayerPrefs.SetFloat("float", floatValue);
    }
    public void FLoatSub()
    {
        floatValue -= 0.5f;
        UpdateFloat();
        BinaryPlayerPrefs.SetFloat("float", floatValue);
    }
    void UpdateFloat()
    {
        floatValueTxt.text = floatValue.ToString();
    }

    //string
    public void StringSet(string name)
    {
        stringValue = name;
        BinaryPlayerPrefs.SetString("string", stringValue);
        UpdateString();
    }
    
    void UpdateString()
    {
        stringValueTxt.text = stringValue;
        inputField.text = stringValue;
    }

    //bool
    public void BoolSet(bool b)
    {
        boolValue = b;
        BinaryPlayerPrefs.SetBool("bool", boolValue);
        UpdateBool();
    }

    void UpdateBool()
    {
        if (boolValue)
        {
            boolValueTxt.text = "True";
        }
        else
        {
            boolValueTxt.text = "False";
        }
        toggle.isOn = boolValue;
    }
}
