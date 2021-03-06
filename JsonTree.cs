﻿using System.Collections.Generic;

namespace JosnReaderFramework
{
    abstract class JsonTree
    {
        public string name;
        public string value;
        public List<JsonTree> nodes;
        public bool isArrayElement;
        public JsonTree()
        {
            nodes = new List<JsonTree>();
            isArrayElement = false;
        }
        public abstract void constract();
    }
}
