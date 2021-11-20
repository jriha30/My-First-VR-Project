using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HandInput : MonoBehaviour
{
   public InputDevice rightHand;
   // public InputDevice rightHand;

    // Start is called before the first frame update
    void Start()
    {
        List<InputDevice> devices = new List<InputDevice>();

       InputDeviceCharacteristics rightControllerChar = InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;

      InputDevices.GetDevicesWithCharacteristics(rightControllerChar, devices);

        

        foreach (var item in devices)
        {
            rightHand = item;
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        rightHand.TryGetFeatureValue(CommonUsages.grip, out float gripValue);
        if(gripValue > .1f)
        {
            print("Grip");
        }
        rightHand.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue);
        if (triggerValue > .1f)
        {
            print("Trigger");
        }
    }
}
