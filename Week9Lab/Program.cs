using System;

namespace Week9Lab
{
	public class TestDemo
	{

		public static void Main(string[] args)
		{
			CreditCardPayment x = new CreditCardPayment(2.12, "George bush", "11/27", "************1234");

			CashPayment p = new CashPayment(20.03);

			CreditCardPayment y = new CreditCardPayment(11.22, "Trump Henry", "22/11", "987654321");

			CashPayment q = new CashPayment(55.12);

			x.paymentDetails();
			p.paymentDetails();
			y.paymentDetails();
			q.paymentDetails();
		}

	}
	public abstract class Payment
	{
		protected internal double cash;
		internal Payment(double val)
		{
			this.cash = (long)Math.Round(val * 100, MidpointRounding.AwayFromZero) / 100.0;
		}
		public virtual double getcash()
		{
			return cash;
		}
		public virtual void setcash(double newval)
		{
			this.cash = newval;
		}
		public virtual void paymentDetails()
		{
			Console.WriteLine("The payment of cash: $" + this.cash);
		}
	}
	public class CashPayment : Payment
	{

		internal CashPayment(double val) : base(val)
		{
		}

		public virtual void paymentDetails()
		{
			Console.WriteLine("The payment of cash:  $" + this.cash);
		}
	}
	public class CreditCardPayment : Payment
	{

		public string name, expDate, number;

		internal CreditCardPayment(double value, string name, string expDate, string number) : base(value)
		{
			this.number = number;
			this.expDate = expDate;
			this.name = name;
		}

		public virtual void paymentDetails()
		{
			Console.WriteLine("The payment of $" + this.cash + " through the card " + this.number + ",  and expire date " + this.expDate + ", and the owner name: " + this.name + ".");
		}

	}
}

