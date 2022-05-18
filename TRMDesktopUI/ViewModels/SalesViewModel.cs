using Caliburn.Micro;
using System.ComponentModel;

namespace TRMDesktopUI.ViewModels
{
    public class SalesViewModel : Screen
    {
        private BindingList<string> _products;
        private BindingList<string> _cart;

        private string _itemQuantity;

        public BindingList<string> Products
        {
            get 
            { 
                return _products; 
            }
            set 
            { 
                _products = value; 
                NotifyOfPropertyChange(() => Products);
            }
        }

        public BindingList<string> Cart
        {
            get 
            { 
                return _cart; 
            }
            set 
            { 
                _cart = value; 
                NotifyOfPropertyChange(() => Cart);
            }
        }

        public string ItemQuantity
        {
            get 
            { 
                return _itemQuantity; 
            }
            set 
            { 
                _itemQuantity = value;
                NotifyOfPropertyChange(() => Products);
            }
        }

        public string SubTotal
        {
            get
            {
                // TODO Calculation
                return "$0.00";
            }
        }

        public string Tax
        {
            get
            {
                // TODO Calculation
                return "$0.00";
            }
        }

        public string Total
        {
            get
            {
                // TODO Calculation
                return "$0.00";
            }
        }

        public bool CanAddToCart
        {
            get
            {
                bool output = false;

                // TODO Logic for validation

                return output;
            }
        }

        public void AddToCart()
        {

        }

        public bool CanRemoveFromCart
        {
            get
            {
                bool output = false;

                // TODO Logic for validation

                return output;
            }
        }

        public void RemoveFromCart()
        {

        }

        public bool CanCheckOut
        {
            get
            {
                bool output = false;

                // TODO Logic for validation

                return output;
            }
        }

        public void CheckOut()
        {

        }
    }
}
