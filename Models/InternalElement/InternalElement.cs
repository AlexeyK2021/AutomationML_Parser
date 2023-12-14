﻿using System;
using System.Collections.Generic;
using System.Text;
using Attribute = amlWeb.Models.Attribute;

namespace amlWeb.Models.InternalElement;

public class InternalElement
{
    public String name;
    public List<InternalElement> children;
    public List<Attribute> attributes;

    public InternalElement(string name, List<InternalElement> children, List<Attribute> attributes)
    {
        this.name = name;
        this.children = children;
        this.attributes = attributes;
    }

    public InternalElement(string name, List<InternalElement> children)
    {
        this.name = name;
        this.children = children;
    }

    public override string ToString()
    {
        // var attrListString = new StringBuilder();
        var childrenList = new StringBuilder();
        foreach (var child in children)
        {
            childrenList.Append(child.ToString());
        }
        var attrsList = new StringBuilder();
        foreach (var attr in attributes)
        {
            attrsList.Append(attr.ToString());
        }
        return $"[" +
               $"name={name} " +
               $"attributes=[{attrsList.ToString()}] "+
               $"children=[{childrenList.ToString()}]" +
               $"]";
    }
}