using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Sepet.Models
{
    public class Card
    {
        Dictionary<int, CardItem> _myCart = new Dictionary<int, CardItem>();


        public List<CardItem> myCart
        {
            get
            {
                return _myCart.Values.ToList();
            }
        }

        public void AddItem(CardItem cardItem)
        {
            if (_myCart.ContainsKey(cardItem.ID))
            {
                _myCart[cardItem.ID].Quantity += cardItem.Quantity;
                return;
            }
            _myCart.Add(cardItem.ID, cardItem);
        }


    }
}
    
