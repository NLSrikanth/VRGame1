//-----------------------------------------------------------------------
// <copyright file="CameraPointer.cs" company="Google LLC">
// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//-----------------------------------------------------------------------

using System.Collections;
using UnityEngine;

/// <summary>
/// Sends messages to gazed GameObject.
/// </summary>
public class CameraPointer : MonoBehaviour
{
    private const float _maxDistance = 10;
    private GameObject _gazedAtObject = null;

    /// <summary>
    /// Update is called once per frame.
    /// </summary>
    public void Update()
    {
        // Casts ray towards camera's forward direction, to detect if a GameObject is being gazed
        // at.
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, _maxDistance))
        {
            // GameObject detected in front of the camera.
            if (_gazedAtObject != hit.transform.gameObject)
            {
                // New GameObject.
                _gazedAtObject?.SendMessage("OnPointerExit");
                _gazedAtObject = hit.transform.gameObject;
                if(_gazedAtObject.name == "Sphere") {
                    _gazedAtObject.SendMessage("SphereFocusOnListener");
                }
                if(_gazedAtObject.name == "Icosahedron") {    
                    _gazedAtObject.SendMessage("IcosahedronFocusOnListener");
                }
                if(_gazedAtObject.name == "ParticleSystem") {    
                    _gazedAtObject.SendMessage("SparkleFocusOnListener");
                }
                if(_gazedAtObject.name == "Object4") {    
                    _gazedAtObject.SendMessage("Object4FocusOnListener");
                }
                if(_gazedAtObject.name == "Object4Cube") {    
                    _gazedAtObject.SendMessage("Object4FocusOnListener");
                }
                if(_gazedAtObject.name == "Object4Sphere") {    
                    _gazedAtObject.SendMessage("Object4FocusOnListener");
                }
            }
        }
        else
        {
            // No GameObject detected in front of the camera.
            _gazedAtObject?.SendMessage("OnPointerExit");
            _gazedAtObject = null;
        }
    }
}
