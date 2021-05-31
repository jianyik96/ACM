using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }
        private string _productName;
        public string ProductName
        {
            get
            {
                //var stringHandler = new StringHandler();
                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value;
            }
        }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }

        public string Log() =>
        $"{ProductId} {ProductName} Detail: {ProductDescription} Status: {EntityState}";

        public override string ToString() => ProductName;

        /// <summary>
        /// Retrieve one product
        /// </summary>
        //public Product Retrieve(int productId)
        //{
        //    // Code that retrieves the defined product

        //    return new Product();
        //}

        /// <summary>
        /// Save the current product
        /// </summary>
        /// <returns></returns>
        //public bool Save()
        //{
        //    // Code that saves the defined product

        //    return true;
        //}

        /// <summary>
        /// Validates the product data
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

    }
}
