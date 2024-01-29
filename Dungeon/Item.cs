
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Item {

    public enum ITEM_TYPE
    {
    }

    public enum ITEM_CLASS
    {
    }

    public class Item
    {
        public int LifePoint { get; set; }
        public bool IsDead { get; set; }
        public ITEM_TYPE Type { get; set; }
        public ITEM_CLASS Class { get; set; }
        public string SelectionPhrase { get; set; }
        public int Value { get; set; }
    }
