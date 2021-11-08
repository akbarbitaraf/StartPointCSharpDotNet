using System;
using System.Collections.Generic;
using System.Text;

namespace NutShellChapFour
{
 public class PriceChangedEventArgs :EventArgs
    {
        public readonly decimal LastPrice;
        public readonly decimal NewPrice;
        public PriceChangedEventArgs(decimal lastPrice, decimal newPrice)
        {
            LastPrice = lastPrice; NewPrice = newPrice;
        }


    }

    delegate int Transformer(int i);
    public class Stock
    {
        
                
        private string symbol;
        public decimal price;
        public Stock(string symbol)
        {
            this.symbol = symbol;

        }
        public event EventHandler<PriceChangedEventArgs> PriceChanged;
        public virtual void OnChanged(PriceChangedEventArgs e)
        {
            PriceChanged.Invoke(this, e);

        }


        public decimal Price
        {



            get
            {
                return price;

            }
            set
            {
                if (price == value) return;
                decimal oldPrice;
                oldPrice = price; 
                price = value;
                OnChanged(new PriceChangedEventArgs(oldPrice, price));

            }
        }

    }
}
