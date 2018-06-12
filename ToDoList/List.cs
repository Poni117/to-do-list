using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class List
    {
        private Item _headItem;
        public List()
        {
            _headItem = null;
        }
        
        public void Add(string value)
        {
            if(_headItem == null)
            {
                _headItem = new Item(0, value);
            }
            else
            {
                // 1. last item
                Item lastItem = _headItem;
                for(; lastItem.GetNextItem() != null;)
                {
                    lastItem = lastItem.GetNextItem();
                }
                // 2.make  new item be next of last item
                Item newItem = new Item(lastItem.GetIndex() + 1, value);
                lastItem.SetNextItem(newItem); 
            }

        }
        public int GetLength()
        {
            if(_headItem == null)
            {
                return 0;
            }
            Item lastItem = _headItem;
            for (; lastItem.GetNextItem() != null;)
            {
                lastItem = lastItem.GetNextItem();
            }
            return lastItem.GetIndex() + 1;
        }
        public string GetItem(int index)
        {
            Item nextItem = _headItem;
            for(;nextItem != null; )
            {
                if (index != nextItem.GetIndex())
                {
                    nextItem = nextItem.GetNextItem();
                }
                else
                {
                    return nextItem.GetValue();
                }
            }

            throw new Exception($"Нет элемента с индексом {index}");
        }

        class Item
        {
            private int _index;
            private string _value;
            private Item _nextItem;

            public Item(int index, string value)
            {
                _index = index;
                _value = value;
                _nextItem = null;
            }

            public int GetIndex()
            {
                return _index;
            }
            public string GetValue()
            {
                return _value;
            }
            public Item GetNextItem()
            {
                return _nextItem;
            }
            public void SetNextItem(Item nextItem)
            {
                _nextItem = nextItem;
            }

        }
    }
}
