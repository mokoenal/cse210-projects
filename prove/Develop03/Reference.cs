using System;
using System.Collections.Generic;
using System.Linq;

// Class to encapsulate the responsibilities of a Reference (including handling multiple verses)
public class ScriptureReference
{
    private string _reference;

    public string Reference
    {
        
        get { return _reference; }
        private set { _reference = value; }
    }

    public ScriptureReference(string reference)
    {
        _reference = reference; // Set the private field directly in the constructor
    }

    // Make SetReference private to prevent external modifications
    private void SetReference(string reference)
    {
        Reference = reference;
    }

    public override string ToString()
    {
        return Reference;
    }
}