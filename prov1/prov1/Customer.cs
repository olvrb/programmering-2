using System;
using System.Collections.Generic;
using System.Text;

namespace prov1
{
    class Customer
    {

        // Receipts are stored in the customer in case they want to return their purchased product 
        // (to verify that they actually did purchase it here).
        // The amount of money a customer has is 

        // Could be useful... maybe?
        private Dictionary<Book, decimal> Receipts = new Dictionary<Book, decimal>();
        private decimal money;
        public void BuyBook(Book book)
        {
            // Make sure the customer has enough money to buy the book.
            if (money > book.Price)
            {
                // Spend the money.
                money -= book.Price;

                Receipts.Add(book, book.Price);
            }
        }
        public void ReturnBook(Book book)
        {
            // Refund the money.
            money += book.Price;

            // ~~Undefined behaviour if the customer has purchased multiple books with the same title.~~ Nevermind.
            Receipts.Remove(book);
        } 
    }
}
