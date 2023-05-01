using System;

namespace DigitalStore
{
    public class User
    {
        public string name;
        public string surname;
        public string email;
        private string password;
        private string address;
        private string DNI;
        private string phone;

    }

    public class Customer : User
    {
        public DateTime registration;
        public List<String> wishlist;

        public void addToWishlist(String item)
        {
            wishlist.Add(item);
        }

    }

    public class ProductReview
    {
        public float stars;
        public string comment;
        public bool addStars()
        {
            return true;
        }

        public bool addComment()
        {
            return true;
        }

    }

    public class ShoppingCart
    {

        private float totalPrice;

        Dictionary<Product, int> productDictionary = new Dictionary<Product, int>();

        public bool addProduct()
        {
            return true;
        }

        public bool removeProduct()
        {
            return true;
        }

        public bool addPaymentMethod()
        {
            return true;
        }
    }

    public class Order
    {
        public int orderNumber;
        public DateTime orderDate;
        public int quantity;
        public float finalPrice;

        public bool getOrderDetails()
        {
            return true;
        }

        Dictionary<Product, int> productDictionary = new Dictionary<Product, int>();
        

    }

    public class Product
    {
        public int id;
        public string name;
        public string brand;
        public string images;
        public string description;
        public float basePrice;
        public float discount;
        public string category;
        public string subcategory1;
        public string subcategory2;
        public string subsubcategory2;
        public string labels;

    }
}