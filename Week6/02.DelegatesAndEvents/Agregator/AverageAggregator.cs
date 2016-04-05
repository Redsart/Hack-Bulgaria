using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregator
{
    public delegate void ChangeEventHandler(object sender,EventArgs e);

    public class AverageAggregator
    {
        public event ChangeEventHandler Change;

        private decimal average;
        private ICollection<int> numbers;

        public AverageAggregator()
        {
            this.numbers = new List<int>();
        }

        public decimal Average
        {
            get
            {
                return this.average;
            }
        }

        public void AddNumber(int number)
        {
            var currentAverage = this.average;
            this.numbers.Add(number);
            CalculateAverage();
            if (currentAverage != this.average)
            {
                OnChanged();
            }
        }

        private void CalculateAverage()
        {
            var sum = 0;
            foreach (var number in this.numbers)
            {
                sum += number;
            }
            this.average = sum / this.numbers.Count;
        }

        private void OnChanged()
        {
            if (this.Change != null)
            {
                this.Change(this, EventArgs.Empty);
            }
        }
    }
}
