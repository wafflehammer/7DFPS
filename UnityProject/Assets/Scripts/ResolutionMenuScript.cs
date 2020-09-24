﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Dropdown))]
public class ResolutionMenuScript : OptionInitializerBase {
    private Dropdown dropdown;

    public override void Initialize() {
        UpdateDropdown();
    }

    private void UpdateDropdown() {
        dropdown = GetComponent<Dropdown>();

        // Clear previous options
        dropdown.ClearOptions();

        List<string> strings = new List<string>();
        foreach (var resolution in Screen.resolutions)
            strings.Add(resolution.ToString());

        // Add new options
        dropdown.AddOptions(strings);
    }
}
